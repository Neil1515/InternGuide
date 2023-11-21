using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InternGuide.Deans_Form.InsertInternStudent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InternGuide.Deans_Form
{
    public partial class DepartmentPartnersComp : UserControl
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string currentDeanId;

        static DepartmentPartnersComp()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
        public DepartmentPartnersComp(int deanId)
        {
            InitializeComponent();
             currentDeanId = deanId.ToString();
        }

        public class CompanyPartners
        {
            public string Companyname { get; set; }
            public string Address { get; set; }
            public string Contactperson { get; set; }
            public string Designation { get; set; }
            public string Contactnumber { get; set; }
            public string Emailaddress { get; set; }
            public string Yearstartedaspartner { get; set; }
            public string Remark { get; set; }

        }
        private void DepartmentPartnersComp_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialize the SqlConnection and open it
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch the department information for the current dean
                    string departmentQuery = "SELECT [department] FROM [dbo].[departmentdeanstable] WHERE [Id] = @deanId";
                    using (var departmentCommand = new SqlCommand(departmentQuery, connection))
                    {
                        departmentCommand.Parameters.AddWithValue("@deanId", currentDeanId);
                        string department = departmentCommand.ExecuteScalar() as string;

                        // Load data into the DataGridView only for the specific department
                        string query = "SELECT * FROM departmentpartnershipcompanytable WHERE department = @department";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@department", department);

                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void ImportStudentExcelfilesbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportExcelFile(filePath);
            }
        }
        private void ImportExcelFile(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;
                    List<CompanyPartners> newCompanyPartners = new List<CompanyPartners>();

                    for (int row = 2; row <= rowCount; row++)
                    {
                        string companyname = worksheet.Cells[row, 1].Value?.ToString();
                        string address = worksheet.Cells[row, 2].Value?.ToString();
                        string contactperson = worksheet.Cells[row, 3].Value?.ToString();
                        string designation = worksheet.Cells[row, 4].Value?.ToString();
                        string contactnumber = worksheet.Cells[row, 5].Value?.ToString();
                        string emailaddress = worksheet.Cells[row, 6].Value?.ToString();
                        string yearstartedaspartner = worksheet.Cells[row, 7].Value?.ToString();
                        string remark = worksheet.Cells[row, 8].Value?.ToString();

                        // Ensure that required fields are not null or empty before adding to the list
                        if (!string.IsNullOrEmpty(companyname))
                        {
                            // Create a Student object and add it to the list
                            CompanyPartners companypartners = new CompanyPartners
                            {
                                Companyname = companyname,
                                Address = address,
                                Contactperson = contactperson,
                                Designation = designation,
                                Contactnumber = contactnumber,
                                Emailaddress = emailaddress,
                                Yearstartedaspartner = yearstartedaspartner,
                                Remark = remark
                            };

                            newCompanyPartners.Add(companypartners);
                        }
                    }

                    // Call the InsertStudent method with the currentDeanId
                    InsertCompanyPartners(newCompanyPartners, currentDeanId);

                    MessageBox.Show("Data imported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertCompanyPartners(List<CompanyPartners> companypartners, string currentDeanId)
        {
            string department = "";
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch the department information for the current dean
                    string departmentQuery = "SELECT [department] FROM [dbo].[departmentdeanstable] WHERE [Id] = @deanId";
                    using (var departmentCommand = new SqlCommand(departmentQuery, connection))
                    {
                        departmentCommand.Parameters.AddWithValue("@deanId", currentDeanId);
                        department = departmentCommand.ExecuteScalar() as string;
                    }

                    // Begin a transaction
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            foreach (CompanyPartners companypartner in companypartners)
                            {
                                // Check if a company with the same name already exists
                                string checkQuery = "SELECT COUNT(*) FROM departmentpartnershipcompanytable WHERE companyname = @companyname";
                                using (var checkCommand = new SqlCommand(checkQuery, connection, transaction))
                                {
                                    checkCommand.Parameters.AddWithValue("@companyname", companypartner.Companyname);
                                    int countResult = (int)checkCommand.ExecuteScalar();

                                    if (countResult == 0)
                                    {
                                        string insertQuery = "INSERT INTO departmentpartnershipcompanytable (companyname, address, contactperson, designation, contactnumber, emailaddress, yearstartedaspartner, remark, department, deanId, password, status) " +
                                                               "VALUES (@companyname, @address, @contactperson, @designation, @contactnumber, @emailaddress, @yearstartedaspartner, @remark, @department, @deanId, @password, @status)";

                                        using (var insertCommand = new SqlCommand(insertQuery, connection, transaction))
                                        {
                                            insertCommand.Parameters.AddWithValue("@companyname", companypartner.Companyname);
                                            insertCommand.Parameters.AddWithValue("@address", companypartner.Address);
                                            insertCommand.Parameters.AddWithValue("@contactperson", companypartner.Contactperson);
                                            insertCommand.Parameters.AddWithValue("@designation", companypartner.Designation);
                                            insertCommand.Parameters.AddWithValue("@contactnumber", companypartner.Contactnumber);
                                            insertCommand.Parameters.AddWithValue("@emailaddress", companypartner.Emailaddress);
                                            insertCommand.Parameters.AddWithValue("@yearstartedaspartner", companypartner.Yearstartedaspartner);
                                            insertCommand.Parameters.AddWithValue("@remark", companypartner.Remark);
                                            insertCommand.Parameters.AddWithValue("@department", department);
                                            insertCommand.Parameters.AddWithValue("@deanId", currentDeanId);
                                            insertCommand.Parameters.AddWithValue("@password", $"uclm-{companypartner.Companyname}");
                                            insertCommand.Parameters.AddWithValue("@status", "Active");

                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Company with Name {companypartner.Companyname} already exists. Skipping insertion.");
                                    }
                                }
                            }

                            // Commit the transaction if all inserts were successful
                            transaction.Commit();
                        }
                        catch (SqlException sqlEx)
                        {
                            // Handle SQL-specific exceptions here
                            transaction.Rollback();
                            MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            // Handle other exceptions here
                            transaction.Rollback();
                            MessageBox.Show($"Error occurred during the insert transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Reload data into the DataGridView to reflect the changes for the specific department
                    string query = "SELECT * FROM departmentpartnershipcompanytable WHERE department = @department";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@department", department);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
