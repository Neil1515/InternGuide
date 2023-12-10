using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InternGuide.Admin_Form.AddDepartmentAdmin;

namespace InternGuide.Deans_Form.Requirements
{
    public partial class AddPrelimReqs : Form
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string deanDepartment;
        public AddPrelimReqs(int deansId, string deanDepartment)
        {
            InitializeComponent();
            this.deanDepartment = deanDepartment; 
            filePathLabel.Text = "";
        }

        private void AddPrelimReqs_Load(object sender, EventArgs e)
        {

        }

        private void titletextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptiontextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void browsesampledocumentbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                // Display the file path in a label or any other control if needed
                filePathLabel.Text = filePath;
            }
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titletextbox.Text) || string.IsNullOrWhiteSpace(descriptiontextbox.Text)) //|| string.IsNullOrWhiteSpace(filePathLabel.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Open a new SqlConnection
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO prelimrequirementtable (department, requiremtitle, description, filesample, status) " +
                     "VALUES (@department, @requiremtitle, @description, @filesample, @status)";

                    command = new SqlCommand(insertQuery, connection);

                    command.Parameters.AddWithValue("@department", deanDepartment);
                    command.Parameters.AddWithValue("@requiremtitle", titletextbox.Text);
                    command.Parameters.AddWithValue("@description", descriptiontextbox.Text);

                    if (!string.IsNullOrEmpty(filePathLabel.Text))
                    {
                        // Read the selected file content and convert it to bytes
                        byte[] fileBytes = GetFileBytes(filePathLabel.Text);
                        command.Parameters.Add("@filesample", SqlDbType.VarBinary).Value = fileBytes;
                    }
                    else
                    {
                        // If no file is selected, you can omit adding the parameter
                        command.Parameters.Add("@filesample", SqlDbType.VarBinary).Value = DBNull.Value;
                    }

                    command.Parameters.AddWithValue("@status", "Active");

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Prelim Requirements added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear all fields
                        titletextbox.Text = "";
                        descriptiontextbox.Text = "";
                        filePathLabel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] GetFileBytes(string filePath)
        {
            // Check if filePath is not empty
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                try
                {
                    // Read the selected file content and convert it to bytes
                    return File.ReadAllBytes(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // If filePath is empty or the file doesn't exist, return null or an empty byte array
            return null;
        }
    }
}
