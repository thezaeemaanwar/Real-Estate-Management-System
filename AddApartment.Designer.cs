
namespace Real_Estate_Management
{
    partial class addApartment
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
            this.openAppartmentDialog = new System.Windows.Forms.OpenFileDialog();
            this.savetoDbButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneField = new System.Windows.Forms.TextBox();
            this.pComfortField = new System.Windows.Forms.TextBox();
            this.mProximityRadio = new System.Windows.Forms.RadioButton();
            this.nRoomsField = new System.Windows.Forms.TextBox();
            this.sqMeterField = new System.Windows.Forms.TextBox();
            this.cExpField = new System.Windows.Forms.TextBox();
            this.wfPriceField = new System.Windows.Forms.TextBox();
            this.mPriceField = new System.Windows.Forms.TextBox();
            this.pValField = new System.Windows.Forms.TextBox();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.addAppartmentButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estateProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignApartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignProjectManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openAppartmentDialog
            // 
            this.openAppartmentDialog.FileName = "openFileDialog1";
            // 
            // savetoDbButton
            // 
            this.savetoDbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetoDbButton.Location = new System.Drawing.Point(590, 451);
            this.savetoDbButton.Name = "savetoDbButton";
            this.savetoDbButton.Size = new System.Drawing.Size(75, 32);
            this.savetoDbButton.TabIndex = 21;
            this.savetoDbButton.Text = "Save All";
            this.savetoDbButton.UseVisualStyleBackColor = true;
            this.savetoDbButton.Click += new System.EventHandler(this.savetoDbButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zoneField);
            this.groupBox1.Controls.Add(this.pComfortField);
            this.groupBox1.Controls.Add(this.mProximityRadio);
            this.groupBox1.Controls.Add(this.nRoomsField);
            this.groupBox1.Controls.Add(this.sqMeterField);
            this.groupBox1.Controls.Add(this.cExpField);
            this.groupBox1.Controls.Add(this.wfPriceField);
            this.groupBox1.Controls.Add(this.mPriceField);
            this.groupBox1.Controls.Add(this.pValField);
            this.groupBox1.Controls.Add(this.descriptionField);
            this.groupBox1.Location = new System.Drawing.Point(38, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 372);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Apartment ";
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(3, 338);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(621, 31);
            this.addButton.TabIndex = 41;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Zone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Percieved Comfort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "No of Rooms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Square Meters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Current Expenditure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Work Force Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Materials Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Percieved Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Description";
            // 
            // zoneField
            // 
            this.zoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneField.Location = new System.Drawing.Point(354, 291);
            this.zoneField.Name = "zoneField";
            this.zoneField.Size = new System.Drawing.Size(247, 26);
            this.zoneField.TabIndex = 31;
            // 
            // pComfortField
            // 
            this.pComfortField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pComfortField.Location = new System.Drawing.Point(354, 230);
            this.pComfortField.Name = "pComfortField";
            this.pComfortField.Size = new System.Drawing.Size(247, 26);
            this.pComfortField.TabIndex = 30;
            // 
            // mProximityRadio
            // 
            this.mProximityRadio.AutoSize = true;
            this.mProximityRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mProximityRadio.Location = new System.Drawing.Point(15, 293);
            this.mProximityRadio.Name = "mProximityRadio";
            this.mProximityRadio.Size = new System.Drawing.Size(134, 24);
            this.mProximityRadio.TabIndex = 29;
            this.mProximityRadio.TabStop = true;
            this.mProximityRadio.Text = "Merto Proximity";
            this.mProximityRadio.UseVisualStyleBackColor = true;
            // 
            // nRoomsField
            // 
            this.nRoomsField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRoomsField.Location = new System.Drawing.Point(354, 170);
            this.nRoomsField.Name = "nRoomsField";
            this.nRoomsField.Size = new System.Drawing.Size(247, 26);
            this.nRoomsField.TabIndex = 28;
            // 
            // sqMeterField
            // 
            this.sqMeterField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqMeterField.Location = new System.Drawing.Point(354, 113);
            this.sqMeterField.Name = "sqMeterField";
            this.sqMeterField.Size = new System.Drawing.Size(247, 26);
            this.sqMeterField.TabIndex = 27;
            // 
            // cExpField
            // 
            this.cExpField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cExpField.Location = new System.Drawing.Point(354, 51);
            this.cExpField.Name = "cExpField";
            this.cExpField.Size = new System.Drawing.Size(247, 26);
            this.cExpField.TabIndex = 26;
            // 
            // wfPriceField
            // 
            this.wfPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wfPriceField.Location = new System.Drawing.Point(18, 231);
            this.wfPriceField.Name = "wfPriceField";
            this.wfPriceField.Size = new System.Drawing.Size(247, 26);
            this.wfPriceField.TabIndex = 25;
            // 
            // mPriceField
            // 
            this.mPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPriceField.Location = new System.Drawing.Point(18, 171);
            this.mPriceField.Name = "mPriceField";
            this.mPriceField.Size = new System.Drawing.Size(247, 26);
            this.mPriceField.TabIndex = 24;
            // 
            // pValField
            // 
            this.pValField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pValField.Location = new System.Drawing.Point(18, 113);
            this.pValField.Name = "pValField";
            this.pValField.Size = new System.Drawing.Size(247, 26);
            this.pValField.TabIndex = 23;
            // 
            // descriptionField
            // 
            this.descriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionField.Location = new System.Drawing.Point(18, 51);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.Size = new System.Drawing.Size(247, 26);
            this.descriptionField.TabIndex = 22;
            // 
            // addAppartmentButton
            // 
            this.addAppartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppartmentButton.Location = new System.Drawing.Point(40, 451);
            this.addAppartmentButton.Name = "addAppartmentButton";
            this.addAppartmentButton.Size = new System.Drawing.Size(150, 31);
            this.addAppartmentButton.TabIndex = 21;
            this.addAppartmentButton.Text = "Choose File";
            this.addAppartmentButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estateProjectToolStripMenuItem,
            this.apartmentsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estateProjectToolStripMenuItem
            // 
            this.estateProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.assignApartmentsToolStripMenuItem,
            this.assignProjectManagerToolStripMenuItem,
            this.manageProjectsToolStripMenuItem});
            this.estateProjectToolStripMenuItem.Name = "estateProjectToolStripMenuItem";
            this.estateProjectToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.estateProjectToolStripMenuItem.Text = "Estate Project";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            // 
            // assignApartmentsToolStripMenuItem
            // 
            this.assignApartmentsToolStripMenuItem.Name = "assignApartmentsToolStripMenuItem";
            this.assignApartmentsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.assignApartmentsToolStripMenuItem.Text = "Assign Apartments";
            // 
            // assignProjectManagerToolStripMenuItem
            // 
            this.assignProjectManagerToolStripMenuItem.Name = "assignProjectManagerToolStripMenuItem";
            this.assignProjectManagerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.assignProjectManagerToolStripMenuItem.Text = "Assign Project Manager";
            // 
            // manageProjectsToolStripMenuItem
            // 
            this.manageProjectsToolStripMenuItem.Name = "manageProjectsToolStripMenuItem";
            this.manageProjectsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.manageProjectsToolStripMenuItem.Text = "Manage Projects";
            // 
            // apartmentsToolStripMenuItem
            // 
            this.apartmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
            this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.apartmentsToolStripMenuItem.Text = "Apartments";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageToolStripMenuItem.Text = "Manage ";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.manageToolStripMenuItem1});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.manageToolStripMenuItem1.Text = "Manage";
            // 
            // addApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savetoDbButton);
            this.Controls.Add(this.addAppartmentButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addApartment";
            this.Text = "Add Apartment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openAppartmentDialog;
        private System.Windows.Forms.Button savetoDbButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zoneField;
        private System.Windows.Forms.TextBox pComfortField;
        private System.Windows.Forms.RadioButton mProximityRadio;
        private System.Windows.Forms.TextBox nRoomsField;
        private System.Windows.Forms.TextBox sqMeterField;
        private System.Windows.Forms.TextBox cExpField;
        private System.Windows.Forms.TextBox wfPriceField;
        private System.Windows.Forms.TextBox mPriceField;
        private System.Windows.Forms.TextBox pValField;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.Button addAppartmentButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estateProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignApartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignProjectManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
    }
}