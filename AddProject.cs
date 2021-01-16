using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Real_Estate_Management
{
    public partial class AddProject : Form
    {
        EstateProject project = new EstateProject();
        List<Apartment> apartments;
        List<User> users;
        public AddProject()
        {
            InitializeComponent();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            List<string> apIDs = new List<string>();
            List<string> usernames = new List<string>();
            apartments = Helper.GetApartments();
            foreach (Apartment ap in apartments)
                apIDs.Add(ap.ID);
            users = Helper.GetUsers();
            foreach (User us in users)
                usernames.Add(us.username);
            var source = new AutoCompleteStringCollection();
            apartmentIDFIeld.AutoCompleteCustomSource = source;
        }

        private void assignUserButton_Click(object sender, EventArgs e)
        {
            string uname = usenameField.Text;
            project.AssignManager(uname);
        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pComfortField_TextChanged(object sender, EventArgs e)
        {

        }

        private void nRoomsField_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqMeterField_TextChanged(object sender, EventArgs e)
        {

        }

        private void cExpField_TextChanged(object sender, EventArgs e)
        {

        }

        private void zoneField_TextChanged(object sender, EventArgs e)
        {

        }

        private void wfPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void mPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pValField_TextChanged(object sender, EventArgs e)
        {

        }

        private void apDescField_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProjectButton_Click(object sender, EventArgs e)
        {
            project.description = descriptionField.Text;
            project.noWorkers = Convert.ToInt32(noWorkersField.Text);
            Helper.con.Open();
            string query = "INSERT INTO [dbo].[ProjectsTable] VALUES (@id,@desc, @nWorkers, @apts, @users)";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id",project.ID);
            cmd.Parameters.AddWithValue("@desc",project.description);
            cmd.Parameters.AddWithValue("@nWorkers",project.noWorkers);
            cmd.Parameters.AddWithValue("@id",project.ID);
            cmd.Parameters.AddWithValue("@id",project.ID);
            Helper.con.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            project.AssignApartment(apDescField.Text);
        }

        private void apartmentIDFIeld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Apartment ap = Helper.FindApartment(apartmentIDFIeld.Text);
                apDescField.Text = ap.description;
                pValField.Text = ap.perceivedValue.ToString();
                mPriceField.Text = ap.materialsPrice.ToString();
                wfPriceField.Text = ap.workForcePrice.ToString();
                cExpField.Text = ap.currentExpenditure.ToString();
                sqMeterField.Text = ap.squareMeters.ToString();
                nRoomsField.Text = ap.noRooms.ToString();
                pComfortField.Text = ap.perceivedComfort.ToString();
                zoneField.Text = ap.zone;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new addApartment().Show();
        }
    }
}
