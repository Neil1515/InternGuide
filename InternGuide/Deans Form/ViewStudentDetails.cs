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
        private int deansId;
        public ViewStudentDetails(int deansId)
        {
            InitializeComponent();
            this.deansId = deansId;
        }

        private void ViewStudentDetails_Load(object sender, EventArgs e)
        {
            populateitems();
        }
        private void populateitems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Retrieve the dean's department
                    string deanDepartmentQuery = "SELECT department FROM departmentdeanstable WHERE Id = @deansId";

                    using (SqlCommand deanDepartmentCmd = new SqlCommand(deanDepartmentQuery, connection))
                    {
                        deanDepartmentCmd.Parameters.AddWithValue("@deansId", deansId);

                        string deanDepartment = deanDepartmentCmd.ExecuteScalar() as string;

                        if (deanDepartment != null)
                        {
                            // Set the department text in studdepartmentlabel
                            studdepartmentlabel.Text = $"{deanDepartment} Students";

                            // Now that we have the dean's department, retrieve the students from the same department
                            string query = "SELECT id, fname, mname, lname, yrlvl, course, email, image FROM studenttable WHERE department = @department";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@department", deanDepartment);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        int studentID = reader.GetInt32(reader.GetOrdinal("id"));
                                        string studentName = reader["fname"].ToString() + " " + reader["mname"].ToString() + " " + reader["lname"].ToString();
                                        string yrlvlcourse = reader["yrlvl"].ToString()+" Year-"+ reader["course"].ToString();
                                        string studemail = reader["email"].ToString();

                                        // Check if the 'image' column is DBNull
                                        byte[] imageData = reader["image"] == DBNull.Value ? null : (byte[])reader["image"];

                                        // Create a new StudentWidget
                                        StudentWidget widget = new StudentWidget
                                        {
                                            StudID = studentID,
                                            StudentName = studentName,
                                            Yrcourse = yrlvlcourse,
                                            Studemail = studemail,
                                            StudentImage = imageData != null ? Image.FromStream(new MemoryStream(imageData)) : null
                                        };

                                        // Add the widget to the FlowLayoutPanel
                                        flowLayoutPanel1.Controls.Add(widget);

                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dean not found or department not specified for the dean.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
