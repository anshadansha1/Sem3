using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class ViewMarksForm : Form
    {
        private const string PlaceholderText = "Enter Student Name";

        public ViewMarksForm()
        {
            InitializeComponent();
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            textBoxStudentName.Text = PlaceholderText;
            textBoxStudentName.ForeColor = Color.Gray;
            textBoxStudentName.Enter += RemovePlaceholder;
            textBoxStudentName.Leave += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (textBoxStudentName.Text == PlaceholderText)
            {
                textBoxStudentName.Text = "";
                textBoxStudentName.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                textBoxStudentName.Text = PlaceholderText;
                textBoxStudentName.ForeColor = Color.Gray;
            }
        }

        private void buttonFetchMarks_Click(object sender, EventArgs e)
        {
            string studentName = textBoxStudentName.Text;

            if (studentName == PlaceholderText || string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter a valid Student Name.");
                return;
            }

            using (SqlConnection connection = new SqlConnection("Data Source=ANSHADANSHA1;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True"))
            {
                // Updated query to fetch marks by student name
                string query = @"
                    SELECT m.Subject, m.Mark 
                    FROM Mark m
                    INNER JOIN Student s ON m.StudentId = s.Id
                    WHERE s.Name = @StudentName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listBoxMarks.Items.Clear();
                            while (reader.Read())
                            {
                                string subject = reader["Subject"].ToString();
                                string mark = reader["Mark"].ToString();
                                listBoxMarks.Items.Add($"{subject}: {mark}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashboard studentdashboard = new StudentDashboard();
            studentdashboard.Show();
            this.Hide();
        }
    }
}
