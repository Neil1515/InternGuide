using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Deans_Form
{
    public partial class DeanManageAccount : UserControl
    {
        public event Action<byte[]> DeanPictureUpdated;
        public event Action<string> DeanfNameUpdated;
        private int deansId;
        private byte[] selectedImageBytes;
        private Timer updateTimer;
        public DeanManageAccount(int deansId)
        {
            InitializeComponent();
            this.deansId = deansId;
            LoadDeanInformation(deansId);
            updatecompltelabel.Text = " ";

            // Instantiate and initialize the timer
            updateTimer = new Timer();
            updateTimer.Tick += timer1_Tick;
            updateTimer.Interval = 5000;
        }
        private void LoadDeanInformation(int deansId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT Id, deansfname, deanslname, image, department FROM departmentdeanstable WHERE Id = @deansId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@deansId", deansId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin details in the textboxes
                            idtextBox.Text = reader["Id"].ToString();
                            departmentlabel.Text = reader["department"].ToString();
                            fnametextBox.Text = reader["deansfname"].ToString();
                            lnameTextBox.Text = reader["deanslname"].ToString();

                            // Display the admin's image
                            byte[] imageBytes = reader["image"] as byte[];
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    deanpicture.Image = Image.FromStream(ms);
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
        private void DeanManageAccount_Load(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string newfname = fnametextBox.Text;
            string newlname = lnameTextBox.Text;

            if (UpdateDeansInfo(newfname, newlname, selectedImageBytes, deansId))
            {
                updatecompltelabel.Text = "Update Successfully.";
                DeanfNameUpdated?.Invoke(newfname);

                // Start the timer to clear the label after 5 seconds
                updateTimer.Start();
            }
            else
            {
                MessageBox.Show("Failed to update Deans information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool UpdateDeansInfo(string newfname, string newlname, byte[] imageBytes, int deansId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to update admin information
                    string sqlQuery = "UPDATE departmentdeanstable SET deansfname = @deansfname, deanslname = @deanslname";

                    // Include image update only if an image is selected
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        sqlQuery += ", image = @image";
                    }

                    sqlQuery += " WHERE id = @deansId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@deansfname", newfname);
                        cmd.Parameters.AddWithValue("@deanslname", newlname);

                        // Add image parameter only if an image is selected
                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            cmd.Parameters.AddWithValue("@image", imageBytes);

                            // Raise the event to notify about admin picture update
                            DeanPictureUpdated?.Invoke(imageBytes);
                        }


                        cmd.Parameters.AddWithValue("@deansId", deansId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating Deans information: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Clear the label text and stop the Timer
            updatecompltelabel.Text = " ";
            updateTimer.Stop();
        }

        private void browsepicturebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image for the admin
                    deanpicture.Image = new Bitmap(openFileDialog.FileName);

                    // Convert the selected image to a byte array for storage in the database
                    selectedImageBytes = File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }

        private void deanpicture_Click(object sender, EventArgs e)
        {

        }
    }
}
