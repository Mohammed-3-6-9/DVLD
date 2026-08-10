namespace DVLD.Detain_Release
{
    partial class frmManageDetainedLicenses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            this.cbIsReleasedFilterValue = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.btnAddInternationalLicense = new System.Windows.Forms.Button();
            this.dgvManageDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltersType = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDetainedLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIsReleasedFilterValue
            // 
            this.cbIsReleasedFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleasedFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsReleasedFilterValue.FormattingEnabled = true;
            this.cbIsReleasedFilterValue.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleasedFilterValue.Location = new System.Drawing.Point(441, 282);
            this.cbIsReleasedFilterValue.Name = "cbIsReleasedFilterValue";
            this.cbIsReleasedFilterValue.Size = new System.Drawing.Size(258, 37);
            this.cbIsReleasedFilterValue.TabIndex = 46;
            this.cbIsReleasedFilterValue.SelectedIndexChanged += new System.EventHandler(this.cbIsReleasedFilterValue_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFilterValue.Location = new System.Drawing.Point(441, 282);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(258, 35);
            this.tbFilterValue.TabIndex = 44;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // btnAddInternationalLicense
            // 
            this.btnAddInternationalLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddInternationalLicense.BackgroundImage")));
            this.btnAddInternationalLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddInternationalLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInternationalLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddInternationalLicense.Location = new System.Drawing.Point(1349, 256);
            this.btnAddInternationalLicense.Name = "btnAddInternationalLicense";
            this.btnAddInternationalLicense.Size = new System.Drawing.Size(74, 57);
            this.btnAddInternationalLicense.TabIndex = 43;
            this.btnAddInternationalLicense.UseVisualStyleBackColor = true;
            this.btnAddInternationalLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // dgvManageDetainedLicenses
            // 
            this.dgvManageDetainedLicenses.AllowUserToAddRows = false;
            this.dgvManageDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvManageDetainedLicenses.AllowUserToOrderColumns = true;
            this.dgvManageDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvManageDetainedLicenses.Location = new System.Drawing.Point(15, 336);
            this.dgvManageDetainedLicenses.Name = "dgvManageDetainedLicenses";
            this.dgvManageDetainedLicenses.ReadOnly = true;
            this.dgvManageDetainedLicenses.RowHeadersWidth = 62;
            this.dgvManageDetainedLicenses.RowTemplate.Height = 28;
            this.dgvManageDetainedLicenses.Size = new System.Drawing.Size(1408, 363);
            this.dgvManageDetainedLicenses.TabIndex = 42;
            this.dgvManageDetainedLicenses.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManageDetainedLicenses_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(408, 197);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(407, 40);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(407, 40);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHToolStripMenuItem
            // 
            this.showPersonLicenseHToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHToolStripMenuItem.Image")));
            this.showPersonLicenseHToolStripMenuItem.Name = "showPersonLicenseHToolStripMenuItem";
            this.showPersonLicenseHToolStripMenuItem.Size = new System.Drawing.Size(407, 40);
            this.showPersonLicenseHToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image")));
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(407, 40);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbMainPhoto.Image")));
            this.pbMainPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMainPhoto.InitialImage")));
            this.pbMainPhoto.Location = new System.Drawing.Point(589, 13);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(292, 165);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 41;
            this.pbMainPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(500, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 52);
            this.label2.TabIndex = 40;
            this.label2.Text = "List Detained Licenses";
            // 
            // cbFiltersType
            // 
            this.cbFiltersType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltersType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltersType.FormattingEnabled = true;
            this.cbFiltersType.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "IsReleased",
            "NationalNo",
            "FullName",
            "ReleaseApplicationID"});
            this.cbFiltersType.Location = new System.Drawing.Point(157, 281);
            this.cbFiltersType.Name = "cbFiltersType";
            this.cbFiltersType.Size = new System.Drawing.Size(258, 37);
            this.cbFiltersType.TabIndex = 39;
            this.cbFiltersType.SelectedIndexChanged += new System.EventHandler(this.cbFiltersType_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1300, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Filtered by :";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsNumber.Location = new System.Drawing.Point(152, 727);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(49, 29);
            this.lblRecordsNumber.TabIndex = 36;
            this.lblRecordsNumber.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "# Records :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(1244, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 57);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1435, 779);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbIsReleasedFilterValue);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.btnAddInternationalLicense);
            this.Controls.Add(this.dgvManageDetainedLicenses);
            this.Controls.Add(this.pbMainPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltersType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmManageDetainedLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDetainedLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIsReleasedFilterValue;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Button btnAddInternationalLicense;
        private System.Windows.Forms.DataGridView dgvManageDetainedLicenses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltersType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}