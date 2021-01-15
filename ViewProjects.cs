using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Real_Estate_Management
{
    public partial class ViewProjects : Form
    {
        List<EstateProject> projects = new List<EstateProject>();
        public ViewProjects()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProject().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Modify the project
                if (e.ColumnIndex == 5)
                {
                    this.Hide();
                    new ModifyProject(projects[e.RowIndex]).Show();
                }
                // Delete the project
                else if (e.ColumnIndex == 6)
                {
                    // To confirm delete action
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Project ? ", "Delete Project", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Delete from the list
                        string id = projects[e.RowIndex].ID;
                        projects.RemoveAt(e.RowIndex);

                        // Remove from the database
                        Helper.con.Open();
                        string query = "DELETE FROM [dbo].[ProjectsTable] WHERE id = @id";
                        SqlCommand cmd = new SqlCommand(query, Helper.con);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        Helper.con.Close();

                        // Show the message and reload
                        MessageBox.Show("Apartment Deleted successfully");
                        new ViewProjects().Show();
                        this.Hide();
                    }
                }
                // View the details of a project's detail
                else if (e.ColumnIndex == 7)
                {
                    this.Hide();
                    new ProjectDetails(projects[e.RowIndex]).Show();
                }
            }
        }

        private void ViewProjects_Load(object sender, EventArgs e)
        {

        }
    }
}
