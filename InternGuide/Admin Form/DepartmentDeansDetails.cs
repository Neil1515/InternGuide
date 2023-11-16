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
    public partial class DepartmentDeansDetails : UserControl
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public DepartmentDeansDetails()
        {
            InitializeComponent();
        }

        private void DepartmentAdminDetails_Load(object sender, EventArgs e)
        {
            populateitems();
        }

        private void populateitems()
        {
            string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, deansfname, deanslname, department, image FROM departmentdeanstable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int deansID = reader.GetInt32(reader.GetOrdinal("id"));
                            string deansName = reader["deansfname"].ToString() + " " + reader["deanslname"].ToString();
                            string department = reader["department"].ToString();
                            byte[] imageData = (byte[])reader["image"];

                            // Create a new DepartmentAdminDetailsWidget
                            deanwidget widget = new deanwidget
                            {
                                DeansID = deansID,
                                DeansName = deansName,
                                Department = department,
                                DeansImage = Image.FromStream(new MemoryStream(imageData))
                            };

                            // Add the widget to the FlowLayoutPanel
                            flowLayoutPanel1.Controls.Add(widget);
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
}
