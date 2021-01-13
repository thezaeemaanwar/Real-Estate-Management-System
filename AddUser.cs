using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Real_Estate_Management
{
    public partial class AddUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Real Estate Management\Database1.mdf;Integrated Security=True");
        public AddUser()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = usenameField.Text;
            string type = typeField.Text;
            string pass = passwordField.Text;
            string email = emailField.Text;
            con.Open();
            string query = "INSERT INTO [dbo].UserTable (username, type, password, email) VALUES()"
        }
    }
}
