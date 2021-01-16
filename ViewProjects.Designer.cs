
namespace Real_Estate_Management
{
    partial class ViewProjects
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
            this.projectsTable = new System.Windows.Forms.DataGridView();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noWorkersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detailsCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addProjectBton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsTable
            // 
            this.projectsTable.AllowUserToDeleteRows = false;
            this.projectsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectID,
            this.descriptionCol,
            this.noWorkersCol,
            this.apartments,
            this.usersCol,
            this.addBtnCol,
            this.delBtnCol,
            this.detailsCol});
            this.projectsTable.Location = new System.Drawing.Point(12, 100);
            this.projectsTable.Name = "projectsTable";
            this.projectsTable.ReadOnly = true;
            this.projectsTable.Size = new System.Drawing.Size(841, 381);
            this.projectsTable.TabIndex = 0;
            this.projectsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            // 
            // descriptionCol
            // 
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
            // 
            // noWorkersCol
            // 
            this.noWorkersCol.HeaderText = "No Of Workers";
            this.noWorkersCol.Name = "noWorkersCol";
            this.noWorkersCol.ReadOnly = true;
            // 
            // apartments
            // 
            this.apartments.HeaderText = "Apartments";
            this.apartments.Name = "apartments";
            this.apartments.ReadOnly = true;
            // 
            // usersCol
            // 
            this.usersCol.HeaderText = "Users";
            this.usersCol.Name = "usersCol";
            this.usersCol.ReadOnly = true;
            // 
            // addBtnCol
            // 
            this.addBtnCol.HeaderText = "Modify";
            this.addBtnCol.Name = "addBtnCol";
            this.addBtnCol.ReadOnly = true;
            this.addBtnCol.Text = "Modify";
            this.addBtnCol.UseColumnTextForButtonValue = true;
            // 
            // delBtnCol
            // 
            this.delBtnCol.HeaderText = "Delete";
            this.delBtnCol.Name = "delBtnCol";
            this.delBtnCol.ReadOnly = true;
            this.delBtnCol.Text = "Delete";
            this.delBtnCol.UseColumnTextForButtonValue = true;
            // 
            // detailsCol
            // 
            this.detailsCol.HeaderText = "Details";
            this.detailsCol.Name = "detailsCol";
            this.detailsCol.ReadOnly = true;
            this.detailsCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detailsCol.UseColumnTextForButtonValue = true;
            // 
            // addProjectBton
            // 
            this.addProjectBton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectBton.Location = new System.Drawing.Point(700, 502);
            this.addProjectBton.Name = "addProjectBton";
            this.addProjectBton.Size = new System.Drawing.Size(153, 40);
            this.addProjectBton.TabIndex = 1;
            this.addProjectBton.Text = "Add New Project";
            this.addProjectBton.UseVisualStyleBackColor = true;
            this.addProjectBton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 554);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addProjectBton);
            this.Controls.Add(this.projectsTable);
            this.Name = "ViewProjects";
            this.Text = "ViewProjects";
            this.Load += new System.EventHandler(this.ViewProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectsTable;
        private System.Windows.Forms.Button addProjectBton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn noWorkersCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersCol;
        private System.Windows.Forms.DataGridViewButtonColumn addBtnCol;
        private System.Windows.Forms.DataGridViewButtonColumn delBtnCol;
        private System.Windows.Forms.DataGridViewButtonColumn detailsCol;
    }
}