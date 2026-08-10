namespace DVLD.Licenses
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.ctrlDriverLicenseInfo1 = new DVLD.Controls.ctrlDriverLicenseInfo();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lalel = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.labl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(15, 223);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(1184, 435);
            this.ctrlDriverLicenseInfo1.TabIndex = 121;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoEllipsis = true;
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLicenseID.Location = new System.Drawing.Point(744, 51);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(49, 29);
            this.lblLicenseID.TabIndex = 113;
            this.lblLicenseID.Text = "???";
            this.lblLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(878, 881);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 46);
            this.btnClose.TabIndex = 125;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDetain.Enabled = false;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(1053, 881);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(146, 46);
            this.btnDetain.TabIndex = 124;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(458, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(310, 52);
            this.lblHeader.TabIndex = 123;
            this.lblHeader.Text = "Detain License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(504, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "License ID:             ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalel
            // 
            this.lalel.AutoSize = true;
            this.lalel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalel.Image = ((System.Drawing.Image)(resources.GetObject("lalel.Image")));
            this.lalel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lalel.Location = new System.Drawing.Point(504, 97);
            this.lalel.Name = "lalel";
            this.lalel.Size = new System.Drawing.Size(233, 29);
            this.lalel.TabIndex = 111;
            this.lalel.Text = "Created By:            ";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoEllipsis = true;
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetainDate.Location = new System.Drawing.Point(296, 97);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(49, 29);
            this.lblDetainDate.TabIndex = 110;
            this.lblDetainDate.Text = "???";
            this.lblDetainDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoEllipsis = true;
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreatedBy.Location = new System.Drawing.Point(743, 97);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(49, 29);
            this.lblCreatedBy.TabIndex = 108;
            this.lblCreatedBy.Text = "???";
            this.lblCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(333, 890);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(209, 29);
            this.llblShowLicenseInfo.TabIndex = 127;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // llblShowLicensesHistory
            // 
            this.llblShowLicensesHistory.AutoSize = true;
            this.llblShowLicensesHistory.Enabled = false;
            this.llblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llblShowLicensesHistory.Location = new System.Drawing.Point(26, 890);
            this.llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            this.llblShowLicensesHistory.Size = new System.Drawing.Size(256, 29);
            this.llblShowLicensesHistory.TabIndex = 126;
            this.llblShowLicensesHistory.TabStop = true;
            this.llblShowLicensesHistory.Text = "Show Licenses History";
            this.llblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicensesHistory_LinkClicked);
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoEllipsis = true;
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetainID.Location = new System.Drawing.Point(295, 51);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(49, 29);
            this.lblDetainID.TabIndex = 105;
            this.lblDetainID.Text = "???";
            this.lblDetainID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(15, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(279, 29);
            this.label20.TabIndex = 102;
            this.label20.Text = "Application Fees:         ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(15, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 29);
            this.label6.TabIndex = 99;
            this.label6.Text = "Detain Date:                 ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFineFees);
            this.groupBox1.Controls.Add(this.lblLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lalel);
            this.groupBox1.Controls.Add(this.lblDetainDate);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblDetainID);
            this.groupBox1.Controls.Add(this.labl);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(31, 664);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 196);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // tbFineFees
            // 
            this.tbFineFees.Location = new System.Drawing.Point(300, 140);
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(211, 35);
            this.tbFineFees.TabIndex = 114;
            this.tbFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFineFees_KeyPress);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Image = ((System.Drawing.Image)(resources.GetObject("labl.Image")));
            this.labl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labl.Location = new System.Drawing.Point(15, 51);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(274, 29);
            this.labl.TabIndex = 103;
            this.labl.Text = "Detain ID:                     ";
            this.labl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSearch.Location = new System.Drawing.Point(475, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 57);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(242, 48);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(215, 35);
            this.tbFilterValue.TabIndex = 2;
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID :";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbFilter.Location = new System.Drawing.Point(31, 87);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(760, 113);
            this.gbFilter.TabIndex = 128;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1214, 940);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.llblShowLicensesHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDetainLicense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalel;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llblShowLicensesHistory;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbFineFees;
    }
}