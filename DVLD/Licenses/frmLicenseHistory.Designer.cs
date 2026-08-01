namespace DVLD.Licenses
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNational = new System.Windows.Forms.TabPage();
            this.tabInterNational = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.dgvInterNationalLicenses = new System.Windows.Forms.DataGridView();
            this.ctrlPersonCard1 = new DVLD.Controls.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabNational.SuspendLayout();
            this.tabInterNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationalLicensesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterNationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbFilter.Location = new System.Drawing.Point(347, 109);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1154, 113);
            this.gbFilter.TabIndex = 102;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.BackgroundImage")));
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddPerson.Location = new System.Drawing.Point(725, 36);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(74, 57);
            this.btnAddPerson.TabIndex = 21;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSearch.Location = new System.Drawing.Point(634, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 57);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(401, 51);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(215, 35);
            this.tbFilterValue.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "PersonID",
            "National Number"});
            this.cbFilter.Location = new System.Drawing.Point(168, 47);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(215, 37);
            this.cbFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(624, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 46);
            this.label2.TabIndex = 103;
            this.label2.Text = "License History";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecordsNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 627);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1489, 365);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNational);
            this.tabControl1.Controls.Add(this.tabInterNational);
            this.tabControl1.Location = new System.Drawing.Point(26, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1457, 265);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNational
            // 
            this.tabNational.Controls.Add(this.dgvNationalLicensesHistory);
            this.tabNational.Location = new System.Drawing.Point(4, 34);
            this.tabNational.Name = "tabNational";
            this.tabNational.Padding = new System.Windows.Forms.Padding(3);
            this.tabNational.Size = new System.Drawing.Size(1449, 227);
            this.tabNational.TabIndex = 0;
            this.tabNational.Text = "National";
            this.tabNational.UseVisualStyleBackColor = true;
            // 
            // tabInterNational
            // 
            this.tabInterNational.Controls.Add(this.dgvInterNationalLicenses);
            this.tabInterNational.Location = new System.Drawing.Point(4, 34);
            this.tabInterNational.Name = "tabInterNational";
            this.tabInterNational.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterNational.Size = new System.Drawing.Size(1449, 227);
            this.tabInterNational.TabIndex = 1;
            this.tabInterNational.Text = "InterNational";
            this.tabInterNational.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1329, 998);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 46);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "   Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsNumber.Location = new System.Drawing.Point(166, 322);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(49, 29);
            this.lblRecordsNumber.TabIndex = 16;
            this.lblRecordsNumber.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records :";
            // 
            // dgvNationalLicensesHistory
            // 
            this.dgvNationalLicensesHistory.AllowUserToAddRows = false;
            this.dgvNationalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvNationalLicensesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNationalLicensesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNationalLicensesHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvNationalLicensesHistory.Name = "dgvNationalLicensesHistory";
            this.dgvNationalLicensesHistory.ReadOnly = true;
            this.dgvNationalLicensesHistory.RowHeadersWidth = 62;
            this.dgvNationalLicensesHistory.RowTemplate.Height = 28;
            this.dgvNationalLicensesHistory.Size = new System.Drawing.Size(1443, 221);
            this.dgvNationalLicensesHistory.TabIndex = 0;
            // 
            // dgvInterNationalLicenses
            // 
            this.dgvInterNationalLicenses.AllowUserToAddRows = false;
            this.dgvInterNationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInterNationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterNationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterNationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInterNationalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvInterNationalLicenses.Name = "dgvInterNationalLicenses";
            this.dgvInterNationalLicenses.ReadOnly = true;
            this.dgvInterNationalLicenses.RowHeadersWidth = 62;
            this.dgvInterNationalLicenses.RowTemplate.Height = 28;
            this.dgvInterNationalLicenses.Size = new System.Drawing.Size(1443, 226);
            this.dgvInterNationalLicenses.TabIndex = 1;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(347, 240);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1166, 359);
            this.ctrlPersonCard1.TabIndex = 101;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1513, 1050);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabNational.ResumeLayout(false);
            this.tabInterNational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationalLicensesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterNationalLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNational;
        private System.Windows.Forms.TabPage tabInterNational;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvNationalLicensesHistory;
        private System.Windows.Forms.DataGridView dgvInterNationalLicenses;
    }
}