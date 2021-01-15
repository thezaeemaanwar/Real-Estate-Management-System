
namespace Real_Estate_Management
{
    partial class ModifyProject
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
            this.apartmentTable = new System.Windows.Forms.DataGridView();
            this.ApartmentIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnAssign = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectIDField = new System.Windows.Forms.TextBox();
            this.descField = new System.Windows.Forms.TextBox();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentTable
            // 
            this.apartmentTable.AllowUserToDeleteRows = false;
            this.apartmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApartmentIDs,
            this.UnAssign});
            this.apartmentTable.Location = new System.Drawing.Point(50, 162);
            this.apartmentTable.Name = "apartmentTable";
            this.apartmentTable.ReadOnly = true;
            this.apartmentTable.Size = new System.Drawing.Size(244, 243);
            this.apartmentTable.TabIndex = 0;
            this.apartmentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ApartmentIDs
            // 
            this.ApartmentIDs.HeaderText = "Apartment IDs";
            this.ApartmentIDs.Name = "ApartmentIDs";
            this.ApartmentIDs.ReadOnly = true;
            // 
            // UnAssign
            // 
            this.UnAssign.HeaderText = "Un-Assign";
            this.UnAssign.Name = "UnAssign";
            this.UnAssign.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description :";
            // 
            // projectIDField
            // 
            this.projectIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectIDField.Location = new System.Drawing.Point(150, 84);
            this.projectIDField.Name = "projectIDField";
            this.projectIDField.ReadOnly = true;
            this.projectIDField.Size = new System.Drawing.Size(428, 26);
            this.projectIDField.TabIndex = 4;
            // 
            // descField
            // 
            this.descField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descField.Location = new System.Drawing.Point(150, 116);
            this.descField.Name = "descField";
            this.descField.ReadOnly = true;
            this.descField.Size = new System.Drawing.Size(428, 26);
            this.descField.TabIndex = 5;
            // 
            // userTable
            // 
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumn1});
            this.userTable.Location = new System.Drawing.Point(334, 162);
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.Size = new System.Drawing.Size(244, 243);
            this.userTable.TabIndex = 6;
            this.userTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTable_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "User Names";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Un-Assign";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ModifyProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.descField);
            this.Controls.Add(this.projectIDField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apartmentTable);
            this.Name = "ModifyProject";
            this.Text = "ManageProjects";
            this.Load += new System.EventHandler(this.ModifyProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apartmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apartmentTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectIDField;
        private System.Windows.Forms.TextBox descField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentIDs;
        private System.Windows.Forms.DataGridViewButtonColumn UnAssign;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button backButton;
    }
}