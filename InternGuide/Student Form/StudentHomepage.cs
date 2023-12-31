﻿using System;
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
using static InternGuide.Deans_Form.InsertInternStudent;

namespace InternGuide.Student_Form
{
    public partial class StudentHomepage : UserControl
    {
        public StudentHomepage(int studentId)
        {
            InitializeComponent();
            DisplayDeansName(studentId);
            DisplayCompanyPartners(studentId);
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
                            string deanQuery = "SELECT TOP 1 deansfname, deanslname, departmentemail, image FROM departmentdeanstable WHERE department = @department";

                            using (SqlCommand cmd = new SqlCommand(deanQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@department", department);

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Display dean's name in the label
                                        deansnamelabel.Text = "Dean: " + $"{reader["deansfname"]} {reader["deanslname"]}".Trim();
                                        departmentemaillabel.Text = $"{reader["departmentemail"]}".ToString();

                                        // Convert the byte array to Image
                                        byte[] imageBytes = reader["image"] as byte[];
                                        if (imageBytes != null && imageBytes.Length > 0)
                                        {
                                            using (MemoryStream ms = new MemoryStream(imageBytes))
                                            {
                                                dashdeanpicture.Image = Image.FromStream(ms);
                                            }
                                        }
                                        else
                                        {
                                            // Handle the case when no image is found
                                            dashdeanpicture.Image = null;
                                        }
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
        private void DisplayCompanyPartners(int studentId)
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
                            // Now that we have the student's department, retrieve company partners for that department
                            string companyQuery = "SELECT Status, Companyname, Address, Contactperson, Designation, Contactnumber, Emailaddress, Yearstartedaspartner, Remark " +
                                "FROM departmentpartnershipcompanytable WHERE department = @department";

                            using (SqlCommand cmd = new SqlCommand(companyQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@department", department);

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Bind the data to the DataGridView
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                        else
                        {
                            // Handle the case when no department is found for the student
                            MessageBox.Show("Department not found for the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading company partners: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    private void StudentHomepage_Load(object sender, EventArgs e)
        {

        }
    }
}
