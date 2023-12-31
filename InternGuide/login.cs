﻿using System;
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

            this.AcceptButton = loginbtn;
        }
        
        private void login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1");
            cn.Open();
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
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtusername.Text))
            {
                idpassnotfountlabel.Text = "Please enter your ID and password";
                return;
            }

            int userId;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;

                cmd.CommandText = "SELECT * FROM admintable WHERE id = @id AND password = @password";
                cmd.Parameters.AddWithValue("@id", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        string adminfName = dr["fname"].ToString();
                        userId = Convert.ToInt32(dr["id"]);
                        InsertLoginHistory(userId);
                       // MessageBox.Show("Login Successful as Admin.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdminDashboard adminDashboard = new AdminDashboard(userId);
                        adminDashboard.AdminfName = adminfName;
                        adminDashboard.ShowDialog();
                        return;
                    }
                }

                //dr.Close(); // Close the SqlDataReader

                //// If not found in admintable, check the deanstable table
                //cmd.CommandText = "SELECT * FROM departmentdeanstable WHERE id = @id AND password = @password";
                //using (dr = cmd.ExecuteReader())
                //{
                //    if (dr.HasRows)
                //    {
                //        dr.Read();
                //        string deansfName = dr["deansfname"].ToString();
                //        string deanDepartment = dr["department"].ToString(); // Retrieve the department
                //        userId = Convert.ToInt32(dr["id"]);
                //        dr.Close(); // Close the SqlDataReader after reading data

                //        InsertLoginHistory(userId);
                //        this.Hide();
                //        DeansDashboard deansDashboard = new DeansDashboard(userId, deanDepartment);
                //        deansDashboard.DeansfName = deansfName;
                //        deansDashboard.ShowDialog();
                //        return;
                //    }
                //}

                dr.Close(); // Close the SqlDataReader

                // Check tblaccounting table
                cmd.CommandText = "SELECT * FROM departmentdeanstable WHERE id = @id AND password = @password";
                dr = cmd.ExecuteReader();

                if (dr.Read()) // Check if any rows were returned
                {
                    string status = dr["status"].ToString();
                    if (status == "Active")
                    {
                        //dr.Close();
                        string deansfName = dr["deansfname"].ToString();
                        string deanDepartment = dr["department"].ToString(); // Retrieve the department
                        userId = Convert.ToInt32(dr["id"]);
                        dr.Close();

                        InsertLoginHistory(userId);
                        this.Hide();
                        DeansDashboard deansDashboard = new DeansDashboard(userId, deanDepartment);
                        deansDashboard.DeansfName = deansfName;
                        deansDashboard.ShowDialog();
                        return;
                    }
                    else
                    {
                        dr.Close();
                        idpassnotfountlabel.Text = "User is inactive. Contact admin for access.";
                        return;
                    }
                }
                dr.Close();

                cmd.CommandText = "SELECT * FROM studenttable WHERE id = @id AND password = @password";
                using (dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        string studentfName = $"{dr["fname"]} {dr["mname"]} {dr["lname"]}".Trim();
                        userId = Convert.ToInt32(dr["id"]);
                        dr.Close();

                        InsertLoginHistory(userId);
                       // MessageBox.Show("Login Successful as Student Account.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        InternStudentDashboard internStudentDashboard = new InternStudentDashboard(userId);
                        internStudentDashboard.StudentfName = studentfName;
                        internStudentDashboard.ShowDialog();
                        return;
                    }
                }
            }

            // If no account is found, show the error message
            idpassnotfountlabel.Text = "Invalid Login Credentials";
        }
    }
}
