using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Management
{
    public partial class ViewApartments : Form
    {
        public ViewApartments()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new addApartment().Show();
        }

        private void ViewApartments_Load(object sender, EventArgs e)
        {
            List<Apartment> apartments = Helper.GetApartments();
            apartmentTable.Rows.Clear();
            foreach (Apartment ap in apartments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(apartmentTable);
                row.Cells[0].Value = ap.ID;
                row.Cells[1].Value = ap.description;
                row.Cells[2].Value = ap.perceivedValue;
                row.Cells[3].Value = ap.materialsPrice;
                row.Cells[4].Value = ap.workForcePrice;
                row.Cells[5].Value = ap.currentExpenditure;
                row.Cells[6].Value = ap.squareMeters;
                row.Cells[7].Value = ap.noRooms;
                row.Cells[8].Value = ap.perceivedComfort;
                row.Cells[9].Value = ap.metroProximity;
                row.Cells[10].Value = ap.zone;

                apartmentTable.Rows.Add(row);
            }
        }
    }
}
