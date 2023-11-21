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
//using System.Transactions;
using System.Windows.Forms;

namespace InternGuide.Admin_Form
{
    public partial class DepartmentDeans : UserControl
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public DepartmentDeans()
        {
            InitializeComponent();
        }

        private void addadmindetails_Click(object sender, EventArgs e)
        {
            using (AddDepartmentAdmin adddepartmentadmin = new AddDepartmentAdmin())
            {
                adddepartmentadmin.AdminAdded += adddepartmentadmin_AdminAdded;
                adddepartmentadmin.ShowDialog();
            }
        }
        private void adddepartmentadmin_AdminAdded(object sender, EventArgs e)
        {
            // Reload data into the DataGridView after a product is added
            LoadDataIntoDataGridView();
        }
        private void DepartmentAdmin_Load(object sender, EventArgs e)
        {
           
            this.departmentdeanstableTableAdapter.Fill(this.internGuideDBDataSetMain.departmentdeanstable);

            // Load data into the DataGridView
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    
                    string query = "SELECT * FROM departmentdeanstable";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
