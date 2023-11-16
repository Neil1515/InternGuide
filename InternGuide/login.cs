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

namespace InternGuide
{
    public partial class login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        
        public login()
        {
            InitializeComponent();
            idpassnotfountlabel.Text = " ";
        }
        
        private void login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1");
            cn.Open();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
        }
        private void InsertLoginHistory(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO historylogstbl (userId, datetimein) VALUES (@userId, @loginTime)", connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@loginTime", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                int userId; 

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;


                    cmd.CommandText = "SELECT * FROM admintable WHERE id = @id AND password = @password";
                    cmd.Parameters.AddWithValue("@id", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) 
                    {
                        dr.Read(); 
                        string adminfName = dr["fname"].ToString(); 
                        userId = Convert.ToInt32(dr["id"]); 
                        dr.Close(); 

                        InsertLoginHistory(userId);
                        MessageBox.Show("Login Successful as Admin.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        this.Hide();


                        AdminDashboard AdminDashboard = new AdminDashboard(userId);
                        AdminDashboard.AdminfName = adminfName;
                        AdminDashboard.ShowDialog();
                        return; 
                    }


                    dr.Close(); // Close the SqlDataReader

                    // If not found in admintable, check the deanstable table
                    cmd.CommandText = "SELECT * FROM departmentdeanstable WHERE id = @id AND password = @password";
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) // Check if any rows were returned
                    {
                        dr.Read(); // Move to the first row
                        string deansName = dr["deansfname"].ToString();
                        userId = Convert.ToInt32(dr["id"]);
                        dr.Close(); // Close the SqlDataReader after reading data

                        InsertLoginHistory(userId);
                        MessageBox.Show("Login Successful as Deans Account.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DeansDashboard DeansDashboard = new DeansDashboard();//(userId);
                        //DeansDashboard.DeansName = deansName; // Set the accounting member's name
                        DeansDashboard.ShowDialog();
                        return;
                    }

                    dr.Close(); // Close the SqlDataReader
                }

                idpassnotfountlabel.Text = "No Account available with this username and password.";
            }
            else
            {
                idpassnotfountlabel.Text = "Please enter values in all fields.";
            }
        }
    }
}
