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

namespace InternGuide.Student_Form
{
    public partial class ManageStudentAccount : UserControl
    {
        private string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private int studentId;
        public event Action<byte[]> StudentPictureUpdated;
        private byte[] selectedImageBytes;

        private Timer updateTimer;
        public ManageStudentAccount(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentInformation(studentId);
            updatecompltelabel.Text = " ";

            // Initialize the Timer
            updateTimer = new Timer();
            updateTimer.Interval = 1000; 
            updateTimer.Tick += timer1_Tick;
        }
        private void LoadStudentInformation(int studentId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT Id, fname, mname, lname, image, department, course, yrlvl, email FROM studenttable WHERE Id = @studentId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display student details in the textboxes
                            studidlabel.Text = "Student ID: " + reader["Id"].ToString();
                            studentnamelabel.Text = "Student Name: " + $"{reader["fname"]} {reader["mname"]} {reader["lname"]}".Trim();
                            departmentlabel.Text = "Department: " + reader["department"].ToString();
                            yearcourselabel.Text = "Year Level/Course: " + $"{reader["yrlvl"]} {reader["course"]}".Trim();
                            emaillabel.Text = "Student Email: " + reader["email"].ToString();

                            byte[] imageBytes = reader["image"] as byte[];
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    browsestudentpicture.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void ManageStudentAccount_Load(object sender, EventArgs e)
        {

        }

        private void browsestudentpicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Validate file type and size if needed

                    byte[] imageBytes = File.ReadAllBytes(filePath);

                    // Call the method to update the image in the database and notify the dashboard
                    if (UpdateStudentInfo(imageBytes, studentId))
                    {
                        updatecompltelabel.Text = "Image updated successfully.";
                        // Optionally, update the displayed image
                        browsestudentpicture.Image = new Bitmap(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Clear the label text
            updatecompltelabel.Text = " ";

            // Stop the Timer
            updateTimer.Stop();
        }
        private bool UpdateStudentInfo(byte[] imageBytes, int studentId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to update admin information
                    string sqlQuery = "UPDATE studenttable SET image = @image WHERE id = @studentId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@image", imageBytes);
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Raise the event to notify about the student picture update
                        StudentPictureUpdated?.Invoke(imageBytes);

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating Student information: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
