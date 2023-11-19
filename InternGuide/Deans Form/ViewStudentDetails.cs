using InternGuide.Admin_Form;
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
    public partial class ViewStudentDetails : UserControl
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public ViewStudentDetails()
        {
            InitializeComponent();
        }

        private void ViewStudentDetails_Load(object sender, EventArgs e)
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

                    string query = "SELECT id, fname, mname, lname, yrlvl, course, email, image FROM studenttable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentID = reader.GetInt32(reader.GetOrdinal("id"));
                            string studentName = reader["fname"].ToString() + " " + reader["mname"].ToString() + " " + reader["lname"].ToString();
                            string yrlvlcourse = reader["yrlvl"].ToString() + "/" + reader["course"].ToString();
                            string studemail = reader["email"].ToString();

                            // Check if the 'image' column is DBNull
                            byte[] imageData = reader["image"] == DBNull.Value ? null : (byte[])reader["image"];

                            // Skip adding the widget if the image is DBNull
                            if (imageData == null)
                            {
                                continue;
                            }

                            // Create a new DepartmentAdminDetailsWidget
                            StudentWidget widget = new StudentWidget
                            {
                                StudID = studentID,
                                StudentName = studentName,
                                Yrcourse = yrlvlcourse,
                                Studemail = studemail,
                                StudentImage = Image.FromStream(new MemoryStream(imageData))
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
