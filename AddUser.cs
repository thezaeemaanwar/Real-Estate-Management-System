using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Real_Estate_Management
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string uname = usenameField.Text;
            string type = typeField.SelectedItem.ToString();
            string passs = passwordField.Text;
            string email = emailField.Text;

            Helper.con.Open();
            
            string query = "INSERT INTO [dbo].[UserTable] VALUES (@uname, @type, @mail, @pass)";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pass", passs);

            cmd.ExecuteNonQuery();
            Helper.con.Close();

            MessageBox.Show("User added successfully !");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new addApartment().Show();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
