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

namespace InternGuide.Deans_Form.Requirements
{
    public partial class PrelimRequirements : UserControl
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        private int deansId;
        private string deanDepartment;
        public PrelimRequirements(int deansId, string deanDepartment)
        {
            InitializeComponent();
            this.deansId = deansId;
            this.deanDepartment = deanDepartment;
        }

        private void PrelimRequirements_Load(object sender, EventArgs e)
        {
            populateitems();
        }

        private void addprelimrequirements_Click(object sender, EventArgs e)
        {
            AddPrelimReqs addPrelimReqsForm = new AddPrelimReqs(deansId, deanDepartment);
            addPrelimReqsForm.ShowDialog();
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

                            // Now that we have the dean's department, retrieve the students from the same department
                            string query = "SELECT requiremtitle, description FROM prelimrequirementtable WHERE department = @department";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@department", deanDepartment);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string requiremTitle = reader["requiremtitle"].ToString();
                                        string description = reader["description"].ToString();
                                        //string fileSample = reader["filesample"].ToString();

                                        // Create a new StudentWidget
                                        widgetprelim widget = new widgetprelim
                                        {
                                            Title = requiremTitle,
                                            Description = description,
                                            //Samplefiletitle = fileSample,
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
