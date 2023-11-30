using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Admin_Form
{
    public partial class ManageAdminAccount : UserControl
    {
        public event Action<byte[]> AdminPictureUpdated;
        public event Action<string> AdminfNameUpdated;
        private int adminId;
        private byte[] selectedImageBytes;
        private Timer updateTimer;
        public ManageAdminAccount(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            LoadAdminInformation(adminId);
            updatecompltelabel.Text = " ";

            // Initialize the Timer
            updateTimer = new Timer();
            updateTimer.Interval = 2000; // 5000 milliseconds (5 seconds)
            updateTimer.Tick += timer1_Tick;
        }
        private void LoadAdminInformation(int adminId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT Id, fname, lname, image, email FROM admintable WHERE Id = @adminId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin details in the textboxes
                            idlabel.Text = reader["Id"].ToString();
                            fnametextBox.Text = reader["fname"].ToString();
                            lnametextBox.Text = reader["lname"].ToString();
                            emailtextBox.Text = reader["email"].ToString();

                            // Display the admin's image
                            byte[] imageBytes = reader["image"] as byte[];
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    adminpicture.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Admin not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image for the admin
                    adminpicture.Image = new Bitmap(openFileDialog.FileName);

                    // Convert the selected image to a byte array for storage in the database
                    selectedImageBytes = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string newfname = fnametextBox.Text;
            string newlname = lnametextBox.Text;
            string newemail = emailtextBox.Text;

            // Update the admin's information in the database
            if (UpdateAdminInfo(newfname, newlname, newemail, selectedImageBytes, adminId))
            {
                updatecompltelabel.Text = "Update Successfully.";
                AdminfNameUpdated?.Invoke(newfname);

                // Start the timer to clear the label after 5 seconds
                updateTimer.Start();
            }
            else
            {
                MessageBox.Show("Failed to update admin information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool UpdateAdminInfo(string newfname, string newlname, string newemail, byte[] imageBytes, int adminId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to update admin information
                    string sqlQuery = "UPDATE admintable SET fname = @fname, lname = @lname, email = @email";

                    // Include image update only if an image is selected
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        sqlQuery += ", image = @image";
                    }

                    sqlQuery += " WHERE id = @adminId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@fname", newfname);
                        cmd.Parameters.AddWithValue("@lname", newlname);
                        cmd.Parameters.AddWithValue("@email", newemail);

                        // Add image parameter only if an image is selected
                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            cmd.Parameters.AddWithValue("@image", imageBytes);

                            // Raise the event to notify about admin picture update
                            AdminPictureUpdated?.Invoke(imageBytes);
                        }


                        cmd.Parameters.AddWithValue("@adminId", adminId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating admin information: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Clear the label text and stop the Timer
            updatecompltelabel.Text = " ";
            updateTimer.Stop();
        }
    }
}
