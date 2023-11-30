using System;
using InternGuide.Admin_Form;
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

namespace InternGuide
{
    public partial class AdminDashboard : Form
    {
        private int adminId;
        //private PictureBox adminpicture;
        private PictureBox dashboardAdminPicture;

        public AdminDashboard(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;

            // Initialize dashboardDeanPicture
            dashboardAdminPicture = new PictureBox();
            dashboardAdminPicture.Name = "dashboardadminpicture";
            // Set other properties as needed
            this.Controls.Add(dashboardAdminPicture);

            AdminHomepage AdminHomepage = new AdminHomepage();
            addUserControl(AdminHomepage);
            LoadAdminInformation(adminId);
        }
        private void LoadAdminInformation(int adminId)
        {
            // Define your connection string
            string connectionString = "Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL query to retrieve dean's information based on the dean's ID
                    string sqlQuery = "SELECT fname, image FROM admintable WHERE Id = @adminId";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@adminId", adminId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display dean's details
                                AdminfName = reader["fname"].ToString();

                                // Display the dean's image
                                byte[] imageBytes = reader["image"] as byte[];
                                if (imageBytes != null && imageBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        dashboardadminpicture1.Image = Image.FromStream(ms);
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
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dashboardAdminPicture.Visible = true;
        }
        public string AdminfName
        {
            get { return adminnamelabel.Text; }
            set { adminnamelabel.Text = value; }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashpanel.Controls.Clear();
            dashpanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void UpdateAdminfName(string newAdminfName)
        {
            AdminfName = newAdminfName;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            AdminHomepage AdminHomepage = new AdminHomepage();
            addUserControl(AdminHomepage);
        }

        private void adminmanageaccountbtn_Click(object sender, EventArgs e)
        {
            ManageAdminAccount ManageAdminAccount = new ManageAdminAccount(adminId);
            ManageAdminAccount.AdminfNameUpdated += UpdateAdminfName;
            ManageAdminAccount.AdminPictureUpdated += UpdateAdminPicture;
            addUserControl(ManageAdminAccount);
        }
        private void UpdateAdminPicture(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                dashboardadminpicture1.Image = Image.FromStream(ms);
            }
        }
        private void departmentadminbtn_Click(object sender, EventArgs e)
        {
            DepartmentDeans DepartmentAdmin = new DepartmentDeans();
            addUserControl(DepartmentAdmin);
        }

        private void departmentadmindetailsbtn_Click(object sender, EventArgs e)
        {
            DepartmentDeansDetails DepartmentAdminDetails = new DepartmentDeansDetails();
            addUserControl(DepartmentAdminDetails);
        }

        private void Adminhistlogsbtn_Click(object sender, EventArgs e)
        {
            Adminhistlogs Adminhistlogs = new Adminhistlogs(adminId);
            addUserControl(Adminhistlogs);
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            // Update the logout time in the historylogstbl table
            UpdateLogoutHistory(adminId);

            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
