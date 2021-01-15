using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Real_Estate_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usenameField.Text;
            string type = typeField.Text;
            string pass = passwordField.Text;
            string query = "SELECT * FROM [dbo].UserTable WHERE [username]=@uname "+
                "AND [type]=@tp AND [password]=@pas";

            Helper.con.Open();
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@tp", type);
            cmd.Parameters.AddWithValue("@pas", pass);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                this.Hide();
                new addApartment(type).Show();
            }
            else
            {
                MessageBox.Show("Invalid Login attempt", "Error");
            }
            Helper.con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
