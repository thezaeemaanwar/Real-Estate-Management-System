
namespace Real_Estate_Management
{
    partial class ViewApartments
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pValCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wfPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqMetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRoomsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pComfortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mProxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentTable
            // 
            this.apartmentTable.AllowUserToDeleteRows = false;
            this.apartmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descriptionCol,
            this.pValCol,
            this.mPriceCol,
            this.wfPriceCol,
            this.cExpCol,
            this.sqMetCol,
            this.nRoomsCol,
            this.pComfortCol,
            this.mProxCol,
            this.zone});
            this.apartmentTable.Location = new System.Drawing.Point(12, 91);
            this.apartmentTable.Name = "apartmentTable";
            this.apartmentTable.ReadOnly = true;
            this.apartmentTable.Size = new System.Drawing.Size(1143, 252);
            this.apartmentTable.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Apartment ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descriptionCol
            // 
            this.descriptionCol.HeaderText = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.ReadOnly = true;
            // 
            // pValCol
            // 
            this.pValCol.HeaderText = "Prcieved Value";
            this.pValCol.Name = "pValCol";
            this.pValCol.ReadOnly = true;
            // 
            // mPriceCol
            // 
            this.mPriceCol.HeaderText = "Materials Price";
            this.mPriceCol.Name = "mPriceCol";
            this.mPriceCol.ReadOnly = true;
            // 
            // wfPriceCol
            // 
            this.wfPriceCol.HeaderText = "Work Force Price";
            this.wfPriceCol.Name = "wfPriceCol";
            this.wfPriceCol.ReadOnly = true;
            // 
            // cExpCol
            // 
            this.cExpCol.HeaderText = "Current Expenditure Column";
            this.cExpCol.Name = "cExpCol";
            this.cExpCol.ReadOnly = true;
            // 
            // sqMetCol
            // 
            this.sqMetCol.HeaderText = "Square Meters";
            this.sqMetCol.Name = "sqMetCol";
            this.sqMetCol.ReadOnly = true;
            // 
            // nRoomsCol
            // 
            this.nRoomsCol.HeaderText = "No of Rooms";
            this.nRoomsCol.Name = "nRoomsCol";
            this.nRoomsCol.ReadOnly = true;
            // 
            // pComfortCol
            // 
            this.pComfortCol.HeaderText = "Percieved Comfort";
            this.pComfortCol.Name = "pComfortCol";
            this.pComfortCol.ReadOnly = true;
            // 
            // mProxCol
            // 
            this.mProxCol.HeaderText = "MetroProximity";
            this.mProxCol.Name = "mProxCol";
            this.mProxCol.ReadOnly = true;
            // 
            // zone
            // 
            this.zone.HeaderText = "Zone";
            this.zone.Name = "zone";
            this.zone.ReadOnly = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 39);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ViewApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.apartmentTable);
            this.Name = "ViewApartments";
            this.Text = "ViewApartments";
            this.Load += new System.EventHandler(this.ViewApartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apartmentTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView apartmentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pValCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn wfPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExpCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqMetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRoomsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pComfortCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mProxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn zone;
        private System.Windows.Forms.Button backButton;
    }
}