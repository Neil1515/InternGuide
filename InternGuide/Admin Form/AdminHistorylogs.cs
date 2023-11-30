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
    public partial class AdminHistorylogs : Form
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=CanteenDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public AdminHistorylogs(int adminId)
        {
            InitializeComponent();
            try
            {
                // Initialize the SqlConnection and open it
                connection = new SqlConnection(connectionString);
                connection.Open();

                // Load data into the DataGridView for the specified adminId, ordered by LogDateTime in descending order
                string query = "SELECT * FROM historylogstbl WHERE userId = @adminId ORDER BY datetimein DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@adminId", adminId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    datetimeinoutdataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void AdminHistorylogs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internGuideDBDataSetMain.historylogstbl' table. You can move, or remove it, as needed.
            this.historylogstblTableAdapter.Fill(this.internGuideDBDataSetMain.historylogstbl);

        }
    }
}
