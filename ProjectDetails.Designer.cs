
namespace Real_Estate_Management
{
    partial class ProjectDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pValGroup = new System.Windows.Forms.GroupBox();
            this.emailButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.wfPriceGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.pValGroup.SuspendLayout();
            this.wfPriceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(16, 32);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Percieved Value";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(372, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // pValGroup
            // 
            this.pValGroup.Controls.Add(this.emailButton);
            this.pValGroup.Controls.Add(this.saveButton);
            this.pValGroup.Controls.Add(this.chart2);
            this.pValGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pValGroup.Location = new System.Drawing.Point(23, 57);
            this.pValGroup.Name = "pValGroup";
            this.pValGroup.Size = new System.Drawing.Size(404, 389);
            this.pValGroup.TabIndex = 2;
            this.pValGroup.TabStop = false;
            this.pValGroup.Text = "Percieved Value";
            // 
            // emailButton
            // 
            this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.Location = new System.Drawing.Point(311, 343);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(77, 31);
            this.emailButton.TabIndex = 3;
            this.emailButton.Text = "Email";
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(16, 343);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 31);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // wfPriceGroup
            // 
            this.wfPriceGroup.Controls.Add(this.button1);
            this.wfPriceGroup.Controls.Add(this.button2);
            this.wfPriceGroup.Controls.Add(this.chart1);
            this.wfPriceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfPriceGroup.Location = new System.Drawing.Point(442, 57);
            this.wfPriceGroup.Name = "wfPriceGroup";
            this.wfPriceGroup.Size = new System.Drawing.Size(404, 389);
            this.wfPriceGroup.TabIndex = 4;
            this.wfPriceGroup.TabStop = false;
            this.wfPriceGroup.Text = "Work Force Price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(16, 32);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Work Force Price";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(372, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(77, 31);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 468);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.wfPriceGroup);
            this.Controls.Add(this.pValGroup);
            this.Name = "ProjectDetails";
            this.Text = "ProjectDetails";
            this.Load += new System.EventHandler(this.ProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.pValGroup.ResumeLayout(false);
            this.wfPriceGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox pValGroup;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox wfPriceGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}