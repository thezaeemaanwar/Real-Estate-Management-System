using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Real_Estate_Management
{
    public partial class addApartment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Real Estate Management\Database1.mdf;Integrated Security=True");
        List<Apartment> apartments = new List<Apartment>();
        public addApartment()
        {
            InitializeComponent();
            
        }

        private void addAppartmentButton_Click(object sender, EventArgs e)
        {
            openAppartmentDialog.CheckFileExists = true;
            openAppartmentDialog.AddExtension = true;
            openAppartmentDialog.Multiselect = false;
            openAppartmentDialog.Filter = "CSV File (*.csv)|*csv";
            if (openAppartmentDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openAppartmentDialog.FileName;
                var reader = new StreamReader(File.OpenRead(filePath));
                string line = reader.ReadLine();
                reader.Close();

                if (validateCSV(line)){
                    string temp = File.ReadAllText(filePath);
                    storeApartments(temp);
                }
                else
                {
                    MessageBox.Show("Make sure your csv has following columns in same order :" +
                        "\nDescription,Percieved Value,Materials Price, Workforce Price"+
                        "Current Expenditure, Square Meters, No of Rooms, Metro Proximity"+
                        "Percieved Comfort, Zone");
                }
            }

        }
        private bool validateCSV(string head)
        {
            string[] headData = head.Split(',');
            if (headData[0] == "Description" && headData[1] == "Percieved Value" && headData[2] == "Materials Price" &&
                headData[3] == "Workforce Price" && headData[4] == "Current Expenditure" && headData[5] == "Square Meters"
                && headData[6] == "No of Rooms" && headData[7] == "Metro Proximity" && headData[8] == "Percieved Comfort"
                && headData[9] == "Zone")
            {
                return true;
            }
            return false;
        }
        private void storeApartments(string apts)
        {
            string[] aptmnts = apts.Split('\n');
            aptmnts = aptmnts.Skip(1).ToArray();
            foreach (string apt in aptmnts)
            {
                string[] aptDetails = apt.Split(',');
                Apartment apartment = new Apartment(aptDetails[0], float.Parse(aptDetails[1]), float.Parse(aptDetails[2]), 
                    float.Parse(aptDetails[3]), float.Parse(aptDetails[4]), Convert.ToInt32( aptDetails[5]),
                    Convert.ToInt32(aptDetails[6]),Convert.ToBoolean( aptDetails[7]), Convert.ToInt32( aptDetails[8]), aptDetails[9]);
                apartments.Add(apartment);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // apply conditions for validation
            string description = descriptionField.Text;
            float perceivedValue = float.Parse(pValField.Text);
            float materialsPrice = float.Parse(mPriceField.Text);
            float workForcePrice = float.Parse(wfPriceField.Text);
            float currentExpenditure = float.Parse(cExpField.Text);
            int squareMeters = Convert.ToInt32(sqMeterField.Text);
            int noRooms = Convert.ToInt32(nRoomsField.Text);
            bool metroProximity = mProximityRadio.Checked;
            int perceivedComfort = Convert.ToInt32(pComfortField.Text);
            string zone = zoneField.Text;
            Apartment apartment = new Apartment(description, perceivedValue, materialsPrice,
                workForcePrice, currentExpenditure, squareMeters, noRooms, metroProximity,
                perceivedComfort, zone);
            apartments.Add(apartment);
            MessageBox.Show("Added Apertment successfully");
        }
        private void AddToDatabase()
        {
            con.Open();
            // Add every apaertment in db
            foreach (Apartment apartment in apartments)
            {
                string query = "INSERT INTO ApartmentTable VALUES (@id,@desc, @pVal," +
                    "@mPrice, @wfPrice, @cExp, @sqMtr, @nRooms, @pComf,  @mProx ,@zone)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", apartment.ID);
                cmd.Parameters.AddWithValue("@desc", apartment.description);
                cmd.Parameters.AddWithValue("@pVal",apartment.perceivedValue);
                cmd.Parameters.AddWithValue("@mPrice", apartment.materialsPrice);
                cmd.Parameters.AddWithValue("@wfPrice", apartment.workForcePrice);
                cmd.Parameters.AddWithValue("@cExp", apartment.currentExpenditure);
                cmd.Parameters.AddWithValue("@sqMtr",apartment.squareMeters);
                cmd.Parameters.AddWithValue("@nRooms",apartment.noRooms);
                cmd.Parameters.AddWithValue("@pComf",apartment.perceivedComfort);
                cmd.Parameters.AddWithValue("@mProx",apartment.metroProximity);
                cmd.Parameters.AddWithValue("@zone",apartment.zone);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Helper.userType == "Project Manager")
            {
                addUserMenuStrip.Visible = false;
                addProjectToolStrip.Visible = false;
            }
        }

        private void savetoDbButton_Click(object sender, EventArgs e)
        {
            AddToDatabase();
            MessageBox.Show("Saved in Database");
            // clear the list of apartments for next time
            apartments.Clear();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProject().Show();
        }

        private void manageProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewProjects().Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddUser().Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewApartments().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
