using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternGuide.Admin_Form
{
    public partial class DeansInactiveStatus : Form
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public DeansInactiveStatus()
        {
            InitializeComponent();
        }

        private void DeansInactiveStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internGuideDBDataSetMain.departmentdeanstable' table. You can move, or remove it, as needed.
            this.departmentdeanstableTableAdapter.Fill(this.internGuideDBDataSetMain.departmentdeanstable);

            // Load data into the DataGridView
            LoadDataIntoDataGridView();

        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Open the connection if not already open
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }

                // Update the query to include a WHERE clause for the "status" column
                string query = "SELECT id, deansfname, deanslname, department, status, image FROM departmentdeanstable WHERE status = 'Inactive'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                // Hide the image column
                dataGridView1.Columns["image"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the one containing the picture
            if (e.ColumnIndex == dataGridView1.Columns["editimage"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["image"];

                if (cell != null && cell.Value != null)
                {
                    int deanId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    string fName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string lName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string department = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                    string imagePath = cell.Value.ToString();

                    // Example of how you might get the image data from your database
                    byte[] imageData = GetImageDataFromDatabase(deanId); // Implement this method to fetch the image data
                    using (EditDeanDetails editDeanDetails = new EditDeanDetails(deanId, fName, lName, department, imageData))
                    {
                        // Show the form
                        editDeanDetails.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("The image cell is null or the value is null.");
                }
            }
        }
        private byte[] GetImageDataFromDatabase(int deanId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT image FROM departmentdeanstable WHERE id = @deanId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@deanId", deanId);

                        // Execute the query and retrieve the image data
                        object imageData = command.ExecuteScalar();

                        // Check if the image data is not null
                        if (imageData != null && imageData != DBNull.Value)
                        {
                            return (byte[])imageData;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Return null if there was an error or if image data is not found
            return null;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from the text box
            string searchKeyword = txtsearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                LoadDataIntoDataGridView();
            }
            else
            {
                // Filter the data based on the search keyword
                FilterData(searchKeyword);
            }
        }
        private void FilterData(string searchKeyword)
        {
            try
            {
                // Open the connection if not already open
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }

                // Use a parameterized query to avoid SQL injection
                string query = "SELECT id, deansfname, deanslname, department, status, image FROM departmentdeanstable " +
                               "WHERE (id LIKE @searchKeyword OR deanslname LIKE @searchKeyword OR department LIKE @searchKeyword) AND status = 'Inactive'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", $"%{searchKeyword}%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Update the DataGridView with the filtered data
                dataGridView1.DataSource = dataTable;

                // Hide the image column
                dataGridView1.Columns["image"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            txtsearch.Text = "";
        }
    }
}
