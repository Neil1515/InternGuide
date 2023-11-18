using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternGuide.Student_Form;
using InternGuide.Deans_Form;

namespace InternGuide
{
    public partial class InternStudentDashboard : Form
    {
        private int studentId;
        private PictureBox studentpicture;
        
        public InternStudentDashboard(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;

            // Add deanpicture dynamically
            studentpicture = new PictureBox();
            studentpicture.Name = "studentpicture";
            // Set other properties as needed
            this.Controls.Add(studentpicture);

            

            // Load dean's information and picture upon login
            LoadStudentInformation(studentId);
        }
        private void LoadStudentInformation(int studentId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to retrieve dean's information based on the dean's ID
                    string sqlQuery = "SELECT id, fname, mname, lname, image, course FROM studenttable WHERE Id = @studentId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display dean's details
                                StudentfName = $"{reader["fname"]} {reader["mname"]} {reader["lname"]}".Trim();
                                StudentID = reader["id"].ToString();
                                StudentCourse = reader["course"].ToString();


                                // Display the dean's image
                                byte[] imageBytes = reader["image"] as byte[];
                                if (imageBytes != null && imageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        dashboardstudentpicture1.Image = Image.FromStream(ms);
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading dean's information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InternStudent_Load(object sender, EventArgs e)
        {
            //dashboardStudentPicture.Visible = true;
        }
        public string StudentfName
        {
            get { return studentnamelabel.Text; }
            set { studentnamelabel.Text = value; }
        }

        public string StudentID
        {
            get { return studidlabel.Text; }
            set { studidlabel.Text = value; }
        }

        public string StudentCourse
        {
            get { return studcourselabel.Text; }
            set { studcourselabel.Text = value; }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashpanel.Controls.Clear();
            dashpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        

        private void studentmanageaccountbtn_Click(object sender, EventArgs e)
        {
            ManageStudentAccount ManageStudentAccount = new ManageStudentAccount(studentId);
            addUserControl(ManageStudentAccount);
        }

        private void studdashboardhomepage_Click(object sender, EventArgs e)
        {
            StudentHomepage StudentHomepage = new StudentHomepage();
            addUserControl(StudentHomepage);
        }

        private void myprofilebtn_Click(object sender, EventArgs e)
        {
            ManageStudentAccount ManageStudentAccount = new ManageStudentAccount(studentId);
            addUserControl(ManageStudentAccount);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            UpdateLogoutHistory(studentId);

            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
        private void UpdateLogoutHistory(int userId)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1"))
                {
                    cn.Open();

                    // Update the datetimeout in the historylogstbl table
                    using (SqlCommand cmd = new SqlCommand("UPDATE historylogstbl SET datetimeout = @logoutTime WHERE userId = @userId AND datetimeout IS NULL", cn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@logoutTime", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update logout history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
