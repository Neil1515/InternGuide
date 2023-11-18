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

namespace InternGuide.Student_Form
{
    public partial class ManageStudentAccount : UserControl
    {
        private int studentId;
        public ManageStudentAccount(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentInformation(studentId);
        }
        private void LoadStudentInformation(int studentId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define the SQL query to retrieve admin information based on the admin ID
                string sqlQuery = "SELECT Id, fname, mname, lname, image, department, course, yrlvl, email FROM studenttable WHERE Id = @studentId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display admin details in the textboxes
                            studidlabel.Text = reader["Id"].ToString();
                            studentnamelabel.Text = $"{reader["fname"]} {reader["mname"]} {reader["lname"]}".Trim();
                            departmentlabel.Text = reader["department"].ToString();
                            yearcourselabel.Text = $"{reader["yrlvl"]} {reader["course"]}".Trim();
                            emaillabel.Text = reader["email"].ToString();

                            // Display the admin's image
                            byte[] imageBytes = reader["image"] as byte[];
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    studentpicture.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void ManageStudentAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
