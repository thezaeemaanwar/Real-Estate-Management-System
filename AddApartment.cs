using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Real_Estate_Management
{
    public partial class addApartment : Form
    {
        List<Apartment> apartments = new List<Apartment>();
        public addApartment(string userType)
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

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
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
