namespace DVLD
{
    partial class frmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.dgvManageDrivers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltersType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.numUpDownNumOfActiveLicenses = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumOfActiveLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFilterValue.Location = new System.Drawing.Point(441, 282);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(258, 35);
            this.tbFilterValue.TabIndex = 32;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // dgvManageDrivers
            // 
            this.dgvManageDrivers.AllowUserToAddRows = false;
            this.dgvManageDrivers.AllowUserToDeleteRows = false;
            this.dgvManageDrivers.AllowUserToOrderColumns = true;
            this.dgvManageDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageDrivers.Location = new System.Drawing.Point(15, 336);
            this.dgvManageDrivers.Name = "dgvManageDrivers";
            this.dgvManageDrivers.ReadOnly = true;
            this.dgvManageDrivers.RowHeadersWidth = 62;
            this.dgvManageDrivers.RowTemplate.Height = 28;
            this.dgvManageDrivers.Size = new System.Drawing.Size(1160, 363);
            this.dgvManageDrivers.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(448, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 52);
            this.label2.TabIndex = 28;
            this.label2.Text = "Manage Drivers";
            // 
            // cbFiltersType
            // 
            this.cbFiltersType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltersType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltersType.FormattingEnabled = true;
            this.cbFiltersType.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "FullName",
            "CreatedDate",
            "NumberOfActiveLicenses"});
            this.cbFiltersType.Location = new System.Drawing.Point(157, 281);
            this.cbFiltersType.Name = "cbFiltersType";
            this.cbFiltersType.Size = new System.Drawing.Size(258, 37);
            this.cbFiltersType.TabIndex = 27;
            this.cbFiltersType.SelectedIndexChanged += new System.EventHandler(this.cbFiltersType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Filtered by :";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsNumber.Location = new System.Drawing.Point(152, 727);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(49, 29);
            this.lblRecordsNumber.TabIndex = 24;
            this.lblRecordsNumber.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "# Records :";
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbMainPhoto.Image")));
            this.pbMainPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMainPhoto.InitialImage")));
            this.pbMainPhoto.Location = new System.Drawing.Point(464, 12);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(292, 165);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 29;
            this.pbMainPhoto.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1052, 718);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // numUpDownNumOfActiveLicenses
            // 
            this.numUpDownNumOfActiveLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numUpDownNumOfActiveLicenses.Location = new System.Drawing.Point(441, 282);
            this.numUpDownNumOfActiveLicenses.Name = "numUpDownNumOfActiveLicenses";
            this.numUpDownNumOfActiveLicenses.Size = new System.Drawing.Size(258, 35);
            this.numUpDownNumOfActiveLicenses.TabIndex = 35;
            this.numUpDownNumOfActiveLicenses.ValueChanged += new System.EventHandler(this.numUpDownNumOfActiveLicenses_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(441, 283);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(258, 35);
            this.dtpStartDate.TabIndex = 36;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(798, 281);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(258, 35);
            this.dtpEndDate.TabIndex = 37;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1191, 779);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.numUpDownNumOfActiveLicenses);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.dgvManageDrivers);
            this.Controls.Add(this.pbMainPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltersType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDrivers";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumOfActiveLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.DataGridView dgvManageDrivers;
        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltersType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownNumOfActiveLicenses;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}