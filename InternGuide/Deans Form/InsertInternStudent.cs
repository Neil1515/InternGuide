using OfficeOpenXml;
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

using System.Windows.Input;
using static InternGuide.Deans_Form.InsertInternStudent;

namespace InternGuide.Deans_Form
{
    public partial class InsertInternStudent : UserControl
    {
        private string connectionString = @"Data Source=192.168.1.3;Initial Catalog=InternGuideDB;Persist Security Info=True;User ID=SuperAdmin1;Password=SuperAdmin1";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string currentDeanId;

        static InsertInternStudent()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
        public InsertInternStudent(int deanId)
        {
            InitializeComponent();
            currentDeanId = deanId.ToString();
        }

        public class Student
        {
            public string Id { get; set; }
            public string Email { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string Mname { get; set; }
            public string Course { get; set; }
            public string Yrlvl { get; set; }

        }

        private void InsertInternStudent_Load(object sender, EventArgs e)
        {
            StyleDataGridView();

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
                        string query = "SELECT * FROM studenttable WHERE department = @department";
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
                    List<Student> newStudents = new List<Student>();

                    for (int row = 2; row <= rowCount; row++) // Assuming the header is in the first row
                    {
                        string id = worksheet.Cells[row, 1].Value?.ToString();
                        string fname = worksheet.Cells[row, 2].Value?.ToString();
                        string lname = worksheet.Cells[row, 3].Value?.ToString();
                        string mname = worksheet.Cells[row, 4].Value?.ToString();
                        string course = worksheet.Cells[row, 5].Value?.ToString();
                        string yrlvl = worksheet.Cells[row, 6].Value?.ToString();
                        string email = worksheet.Cells[row, 7].Value?.ToString();

                        // Ensure that required fields are not null or empty before adding to the list
                        if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname))
                        {
                            // Create a Student object and add it to the list
                            Student student = new Student
                            {
                                Id = id,
                                Email = email,
                                Fname = fname,
                                Lname = lname,
                                Mname = mname,
                                Course = course,
                                Yrlvl = yrlvl
                            };

                            newStudents.Add(student);
                        }
                    }

                    // Call the InsertStudent method with the currentDeanId
                    InsertStudent(newStudents, currentDeanId);

                    MessageBox.Show("Data imported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertStudent(List<Student> students, string currentDeanId)
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
                            foreach (Student student in students)
                            {
                                // Check if a student with the same ID already exists
                                string checkQuery = "SELECT COUNT(*) FROM studenttable WHERE id = @id";
                                using (var checkCommand = new SqlCommand(checkQuery, connection, transaction))
                                {
                                    checkCommand.Parameters.AddWithValue("@id", student.Id);
                                    int count = (int)checkCommand.ExecuteScalar();

                                    if (count == 0)
                                    {
                                        // Student does not exist, insert it
                                        string insertQuery = "INSERT INTO studenttable (Id, deanId, fname, lname, mname, course, department, email, yrlvl, image, password, status, batch) " +
                                            "VALUES (@id, @deanId, @fname, @lname, @mname, @course, @department, @email, @yrlvl, NULL, @password, @status, @batch)";

                                        using (var insertCommand = new SqlCommand(insertQuery, connection, transaction))
                                        {
                                            insertCommand.Parameters.AddWithValue("@id", student.Id);
                                            insertCommand.Parameters.AddWithValue("@fname", student.Fname);
                                            insertCommand.Parameters.AddWithValue("@lname", student.Lname);
                                            insertCommand.Parameters.AddWithValue("@mname", student.Mname);
                                            insertCommand.Parameters.AddWithValue("@email", student.Email);
                                            insertCommand.Parameters.AddWithValue("@course", student.Course);
                                            insertCommand.Parameters.AddWithValue("@yrlvl", student.Yrlvl);
                                            insertCommand.Parameters.AddWithValue("@department", department); // Use the fetched department
                                            insertCommand.Parameters.AddWithValue("@deanId", currentDeanId);
                                            insertCommand.Parameters.AddWithValue("@password", $"uclm-{student.Id}");
                                            insertCommand.Parameters.AddWithValue("@status", "Active");
                                            // Dynamically generate batch year based on the current date
                                            DateTime currentDate = DateTime.Now;
                                            string batchYear = currentDate.Year.ToString();
                                            insertCommand.Parameters.AddWithValue("@batch", $"Batch-{batchYear}");

                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Student with ID {student.Id} already exists. Skipping insertion.");
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
                    string query = "SELECT * FROM studenttable WHERE department = @department";
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
        void StyleDataGridView()
        {
            dataGridView1.BackgroundColor = Color.White;
        }
    }
}
