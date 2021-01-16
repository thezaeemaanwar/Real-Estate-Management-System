using System;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Layout.Properties;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Real_Estate_Management
{
    public partial class ProjectDetails : Form
    {
        EstateProject project;
        public ProjectDetails(EstateProject p)
        {
            InitializeComponent();
            project = p;
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            chart1.DataSource = project.GetPercievedValues();
            chart2.DataSource = project.GetWorkforcePrice();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewProjects().Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);
                        var memoryStream = new MemoryStream();
                        chart1.SaveImage(memoryStream, ChartImageFormat.Png);

                        ImageData imageData = ImageDataFactory.Create(memoryStream.GetBuffer());
                        Image img = new Image(imageData);

                        document.Add(img);
                        document.Close();
                    }
                }
            }
        }
    }
}
