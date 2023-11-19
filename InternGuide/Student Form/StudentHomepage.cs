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
using static InternGuide.Deans_Form.InsertInternStudent;

namespace InternGuide.Student_Form
{
    public partial class StudentHomepage : UserControl
    {
        public StudentHomepage(int studentId)
        {
            InitializeComponent();
            DisplayDeansName(studentId);
        }

        private void DisplayDeansName(int studentId)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the student's department
                    string departmentQuery = "SELECT department FROM studenttable WHERE Id = @studentId";

                    using (SqlCommand departmentCmd = new SqlCommand(departmentQuery, connection))
                    {
                        departmentCmd.Parameters.AddWithValue("@studentId", studentId);

                        string department = departmentCmd.ExecuteScalar() as string;

                        if (department != null)
                        {
                            // Now that we have the student's department, retrieve the dean's information
                            string deanQuery = "SELECT TOP 1 deansfname, deanslname, departmentemail FROM departmentdeanstable WHERE department = @department";

                            using (SqlCommand cmd = new SqlCommand(deanQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@department", department);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Display dean's name in the label
                                        deansnamelabel.Text = $"{reader["deansfname"]} {reader["deanslname"]}".Trim();
                                        departmentemaillabel.Text = $"{reader["departmentemail"]}".ToString();
                                    }
                                    else
                                    {
                                        // Handle the case when no dean is found for the department
                                        deansnamelabel.Text = "Dean not found for the department";
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Handle the case when no department is found for the student
                            deansnamelabel.Text = "Department not found for the student";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading dean's information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
