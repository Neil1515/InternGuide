using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InternGuide.Admin_Form
{
    public partial class AddDepartmentAdmin : Form
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1"; 
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string imagePath;
        public event EventHandler<AdminAddedEventArgs> AdminAdded;
        public AddDepartmentAdmin()
        {
            InitializeComponent();
        }

        private void AddDepartmentAdmin_Load(object sender, EventArgs e)
        {

        }

        public class AdminAddedEventArgs : EventArgs
        {
            public int DeanID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Department { get; set; }
            public string ImagePath { get; set; }

        }
        protected virtual void OnAdminAdded(AdminAddedEventArgs e)
        {
            AdminAdded?.Invoke(this, e);
        }
        private void browsepicturebtn_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                imagePath = openFileDialog.FileName;

                try
                {
                    // Load the selected image and set it to the PictureBox control
                    admindepartpicture.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading profile picture: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            idtextBox.Text = "";
            departmentcategorycomboBox.Text = "";
            fnametextbox.Text = "";
            lnametextbox.Text = "";
            admindepartpicture.Image = default;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please upload an image before saving the data.");
                return;
            }
            try
            {
                // Open a new SqlConnection
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if idtextBox.Text is a valid integer
                    if (!int.TryParse(idtextBox.Text, out int deanId))
                    {
                        MessageBox.Show("Please enter a valid Admin ID.");
                        return;
                    }


                    // Convert the image file to byte array
                    byte[] imageData = File.ReadAllBytes(imagePath);

                    string insertQuery = "INSERT INTO departmentdeanstable ( id, department, deansfname, deanslname, password, status, image) " +
                                         "VALUES ( @id, @department, @deansfname, @deanslname, @password, @status, @image)";
                    command = new SqlCommand(insertQuery, connection);

                    command.Parameters.AddWithValue("@id", deanId);
                    command.Parameters.AddWithValue("@department", departmentcategorycomboBox.Text);
                    command.Parameters.AddWithValue("@deansfname", fnametextbox.Text);
                    command.Parameters.AddWithValue("@deanslname", lnametextbox.Text);
                    command.Parameters.AddWithValue("@password", ("uclm-" + deanId));
                    command.Parameters.AddWithValue("@Status", productstatusToggleSwitch.Checked ? "Active" : "Inactive");
                    command.Parameters.AddWithValue("@Image", imageData);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Department Dean added successfully!");


                        OnAdminAdded(new AdminAddedEventArgs
                        {
                            DeanID = deanId,
                            FName = fnametextbox.Text,
                            LName = lnametextbox.Text,
                            Department = departmentcategorycomboBox.Text,

                            ImagePath = null
                        });

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void departmentcategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void admindepartpicture_Click(object sender, EventArgs e)
        {

        }
    }
}
