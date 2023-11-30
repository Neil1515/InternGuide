using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Admin_Form
{
    public partial class AdminChangePassword : Form
    {
        private int adminId;
        public AdminChangePassword(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            LoadAdminInformation(adminId);
            errorlabel.Text = " ";
        }

        private void AdminChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            string oldPassword = oldpassTextBox.Text;
            string newPassword = newpassTextBox.Text;
            string verifyPassword = verifynewpassTextBox.Text;

            // Perform basic validation
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(verifyPassword))
            {
                errorlabel.Text = "Please fill in all fields.";
                return;
            }

            // Check if the new password and verified password match
            if (newPassword != verifyPassword)
            {
                errorlabel.Text = "New password and verify password do not match.";
                return;
            }

            // Validate old password before changing it
            if (!ValidateOldPassword(adminId, oldPassword))
            {
                errorlabel.Text = "Invalid old password.";
                return;
            }

            // Change the password in the database
            if (ChangeAdminPassword(adminId, newPassword))
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful password change
            }
            else
            {
                MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateOldPassword(int adminId, string oldPassword)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to validate the old password
                    string sqlQuery = "SELECT COUNT(*) FROM admintable WHERE Id = @adminId AND password = @oldPassword";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@adminId", adminId);
                        cmd.Parameters.AddWithValue("@oldPassword", oldPassword);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while validating old password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ChangeAdminPassword(int adminId, string newPassword)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the new password is the same as the old password before updating
                    string checkOldPasswordQuery = "SELECT password FROM admintable WHERE Id = @adminId";
                    using (SqlCommand checkOldPasswordCmd = new SqlCommand(checkOldPasswordQuery, connection))
                    {
                        checkOldPasswordCmd.Parameters.AddWithValue("@adminId", adminId);

                        string oldPassword = checkOldPasswordCmd.ExecuteScalar()?.ToString();

                        // Check if the new password is the same as the old password
                        if (newPassword == oldPassword)
                        {
                            errorlabel.Text = "New password should be different from the old password.";
                            return false;
                        }
                    }

                    // Update the admin password if it's not the same as the old password
                    string sqlQuery = "UPDATE admintable SET password = @newPassword WHERE Id = @adminId";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@adminId", adminId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while changing the password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void LoadAdminInformation(int adminId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT fname, lname, image FROM admintable WHERE Id = @adminId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin name
                            namelabel.Text = $"{reader["fname"]} {reader["lname"]}";

                            // Display the admin's image
                            byte[] imageBytes = reader["image"] as byte[];
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes))
                                {
                                    pictureBox.Image = Image.FromStream(ms);
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
