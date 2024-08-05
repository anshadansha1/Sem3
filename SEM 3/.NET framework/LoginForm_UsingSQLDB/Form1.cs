using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace LoginForm_UsingSQLDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1.Establish Connection:
            SqlConnection con = new SqlConnection("Data Source=ANSHADANSHA1;Initial Catalog=loginapp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            //2.Define Query
            string query = "SELECT COUNT(*) FROM loginTable WHERE username=@username AND password=@password";

            SqlCommand cmd = new SqlCommand(query, con);
            //4.Pass parameters to query 
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error in Login!");
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
