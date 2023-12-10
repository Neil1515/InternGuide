using InternGuide.Admin_Form;
using InternGuide.Deans_Form;
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
using static InternGuide.Deans_Form.InsertInternStudent;

namespace InternGuide
{
    public partial class DeansDashboard : Form
    {
        private int deansId;
        private string deanDepartment;
        private PictureBox dashboardDeanPicture;

        public DeansDashboard(int deansId, string deanDepartment)
        {
            InitializeComponent();
            this.deansId = deansId;
            this.deanDepartment = deanDepartment;


            ViewStudentDetails ViewStudentDetails = new ViewStudentDetails(deansId);
            addUserControl(ViewStudentDetails);

            // Initialize dashboardDeanPicture
            dashboardDeanPicture = new PictureBox();
            dashboardDeanPicture.Name = "dashboarddeanpicture";
            // Set other properties as needed
            this.Controls.Add(dashboardDeanPicture);

            // Load dean's information and picture upon login
            LoadDeanInformation(deansId);
        }

        private void DeansDashboard_Load(object sender, EventArgs e)
        {
            // Optional: Set dashboardDeanPicture visible
            dashboardDeanPicture.Visible = true;
        }
        public string DeansfName
        {
            get { return deanfnamelabel.Text; }
            set { deanfnamelabel.Text = "Dean, "+value; }
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

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashpanel.Controls.Clear();
            dashpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void deanmanageaccountbtn_Click(object sender, EventArgs e)
        {
            DeansManageAccount DeansManageAccount = new DeansManageAccount(deansId);
            DeansManageAccount.DeansfNameUpdated += UpdateDeansfName;
            DeansManageAccount.DeansPictureUpdated += UpdateDeansPicture;
            addUserControl(DeansManageAccount);
        }

        private void UpdateDeansfName(string newDeanfName)
        {
            DeansfName = newDeanfName;
        }

        private void UpdateDeansPicture(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                dashboarddeanpicture1.Image = Image.FromStream(ms);
            }
        }

        private void insertstudentbtn_Click(object sender, EventArgs e)
        {
            InsertInternStudent InsertInternStudent = new InsertInternStudent(deansId);
            addUserControl(InsertInternStudent);
        }


        private void LoadDeanInformation(int deansId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to retrieve dean's information based on the dean's ID
                    string sqlQuery = "SELECT deansfname, image FROM departmentdeanstable WHERE Id = @deansId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@deansId", deansId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display dean's details
                                DeansfName = "Dean, "+reader["deansfname"].ToString();

                                // Display the dean's image
                                byte[] imageBytes = reader["image"] as byte[];
                                if (imageBytes != null && imageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        dashboarddeanpicture1.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dean not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            ViewStudentDetails ViewStudentDetails = new ViewStudentDetails(deansId);
            addUserControl(ViewStudentDetails);
        }

        private void Managemeetingsbtn_Click(object sender, EventArgs e)
        {
            ManageMeetings ManageMeetings = new ManageMeetings();
            addUserControl(ManageMeetings);
        }

        private void DepartmentPartnersCompbtn_Click(object sender, EventArgs e)
        {
            DepartmentPartnersComp DepartmentPartnersComp = new DepartmentPartnersComp(deansId);
            addUserControl(DepartmentPartnersComp);
        }

        private void studentrequirementbtn_Click(object sender, EventArgs e)
        {
            ManageStudentReq ManageStudentReq = new ManageStudentReq(deansId, deanDepartment);
            addUserControl(ManageStudentReq);
        }

        private void deanfnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            UpdateLogoutHistory(deansId);

            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
