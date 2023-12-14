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

namespace InternGuide.Admin_Form
{
    public partial class EditDeanDetails : Form
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        // Properties for dean details
        private int DeanId { get; set; }
        private string FName { get; set; }
        private string LName { get; set; }
        private string Department { get; set; }
        private byte[] ImageData { get; set; }
        public event EventHandler DeanUpdated;

        private byte[] imageData;

        //public event EventHandler<DeanUpdatedEventArgs> DeanUpdated;
        private void EditDeanDetails_Load(object sender, EventArgs e)
        {

        }
        public class DeanUpdatedEventArgs : EventArgs
        {
            // You can add more properties here if needed
            public int DeanID { get; set; }
        }

        protected virtual void OnDeanUpdated(DeanUpdatedEventArgs e)
        {
            DeanUpdated?.Invoke(this, e);
        }
        public EditDeanDetails(int deanId, string fName, string lName, string department, byte[] imageData)
        {
            InitializeComponent();

            // Set dean details
            DeanId = deanId;
            FName = fName;
            LName = lName;
            Department = department;
            ImageData = imageData; // Set class-level field

            // Subscribe to the FormClosing event
            this.FormClosing += EditDeanDetails_FormClosing;

            // Initialize controls with dean details
            idlabel.Text = "Dean ID "+deanId.ToString();
            firstnametextbox.Text = fName;
            lastnametextbox.Text = lName;
            departmenttextbox.Text = department;

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }

            // Assuming StatusToggleSwitch is a ToggleSwitch control, update its value accordingly
            StatusToggleSwitch.Checked = GetDeanStatusFromDatabase(); // Implement a method to get the dean's status from the database
        }
        private void EditDeanDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of the Image resources
            pictureBox.Image?.Dispose();
        }
        private bool GetDeanStatusFromDatabase()
        {
            // Replace with the actual logic to retrieve dean status from the database
            // Example: return true if active, false if inactive
            return true;
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Implement the logic to update dean details in the database
                UpdateDeanDetailsInDatabase();

                // Trigger the event to notify that dean details are updated
                OnDeanUpdated(new DeanUpdatedEventArgs { DeanID = DeanId });

                DeanUpdated?.Invoke(this, EventArgs.Empty);
                // Close the form
                this.Close();
            }
        }
        private void UpdateDeanDetailsInDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE departmentdeanstable SET deansfname = @fName, deanslname = @lName, department = @department, status = @status, image = @image WHERE id = @deanId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@fName", firstnametextbox.Text);
                        command.Parameters.AddWithValue("@lName", lastnametextbox.Text);
                        command.Parameters.AddWithValue("@department", departmenttextbox.Text);
                        command.Parameters.AddWithValue("@status", StatusToggleSwitch.Checked ? "Active" : "Inactive");
                        command.Parameters.AddWithValue("@deanId", DeanId);
                        command.Parameters.AddWithValue("@image", ImageData); // Use ImageData instead of imageData

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dean details updated successfully!");

                            // Trigger the event to notify that dean details are updated
                            OnDeanUpdated(new DeanUpdatedEventArgs { DeanID = DeanId });
                        }
                        else
                        {
                            MessageBox.Show("Failed to update dean details.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void resetpasswordbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Implement the logic to reset dean password in the database
                ResetDeanPasswordInDatabase();

                // Close the form or perform additional actions as needed
                // this.Close();
            }
        }
        private void ResetDeanPasswordInDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming you have a table named deanpasswordstable
                    string updatePasswordQuery = "UPDATE departmentdeanstable SET password = @newPassword WHERE Id = @deanId";

                    using (SqlCommand command = new SqlCommand(updatePasswordQuery, connection))
                    {
                        // Corrected the syntax error here
                        string newPassword = "uclm-" + DeanId;

                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.Parameters.AddWithValue("@deanId", DeanId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reset successfully! New password: " + newPassword);
                        }
                        else
                        {
                            MessageBox.Show("Failed to reset password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
