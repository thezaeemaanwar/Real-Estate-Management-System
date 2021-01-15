using System;
using System.Windows.Forms;

namespace Real_Estate_Management
{
    public partial class ModifyProject : Form
    {
        EstateProject project;
        public ModifyProject(EstateProject p)
        {
            InitializeComponent();
            this.project = p;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1)
                {
                    this.project.UnassignApartment(project.apartments[e.RowIndex]);
                    MessageBox.Show("Un assigned Apartment successfully !");
                    project.apartments.RemoveAt(e.RowIndex);
                    new ModifyProject(project).Show();
                    this.Hide();
                } 
            }
        }

        private void ModifyProject_Load(object sender, EventArgs e)
        {
            projectIDField.Text = this.project.ID;
            descField.Text = this.project.description;
            foreach (Apartment app in this.project.apartments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(apartmentTable);
                row.Cells[0].Value = app.ID;
            }
            foreach (User user in this.project.users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(userTable);
                row.Cells[0].Value = user.username;
            }

        }

        private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1)
                {
                    this.project.UnassignUser(project.users[e.RowIndex]);
                    MessageBox.Show("Un assigned User successfully !");
                    project.users.RemoveAt(e.RowIndex);
                    new ModifyProject(project).Show();
                    this.Hide();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewProjects().Show();
        }
    }
}
