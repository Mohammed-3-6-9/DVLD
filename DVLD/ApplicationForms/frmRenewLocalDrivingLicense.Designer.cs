namespace DVLD.ApplicationForms
{
    partial class frmRenewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLocalDrivingLicense));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lalel = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.lblRenewLicenseApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblIssueData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReNew = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlDriverLicenseInfo1 = new DVLD.Controls.ctrlDriverLicenseInfo();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbFilter.Location = new System.Drawing.Point(28, 83);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(760, 113);
            this.gbFilter.TabIndex = 111;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(333, 1001);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(209, 29);
            this.llblShowLicenseInfo.TabIndex = 110;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // llblShowLicensesHistory
            // 
            this.llblShowLicensesHistory.AutoSize = true;
            this.llblShowLicensesHistory.Enabled = false;
            this.llblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llblShowLicensesHistory.Location = new System.Drawing.Point(26, 1001);
            this.llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            this.llblShowLicensesHistory.Size = new System.Drawing.Size(256, 29);
            this.llblShowLicensesHistory.TabIndex = 109;
            this.llblShowLicensesHistory.TabStop = true;
            this.llblShowLicensesHistory.Text = "Show Licenses History";
            this.llblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicensesHistory_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(648, 52);
            this.label3.TabIndex = 106;
            this.label3.Text = "Internationa Licensel Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNotes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblLicenseFees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblRenewedLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lalel);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.lblRenewLicenseApplicationID);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.labl);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.lblIssueData);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(28, 660);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 326);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(289, 243);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(563, 77);
            this.tbNotes.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(19, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 29);
            this.label5.TabIndex = 118;
            this.label5.Text = "Notes:                         ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoEllipsis = true;
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalFees.Location = new System.Drawing.Point(803, 205);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(49, 29);
            this.lblTotalFees.TabIndex = 117;
            this.lblTotalFees.Text = "???";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(504, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 29);
            this.label9.TabIndex = 116;
            this.label9.Text = "Total Fees:                     ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoEllipsis = true;
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLicenseFees.Location = new System.Drawing.Point(283, 205);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(49, 29);
            this.lblLicenseFees.TabIndex = 115;
            this.lblLicenseFees.Text = "???";
            this.lblLicenseFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(16, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 29);
            this.label7.TabIndex = 114;
            this.label7.Text = "License Fees:             ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoEllipsis = true;
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(803, 41);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(49, 29);
            this.lblRenewedLicenseID.TabIndex = 113;
            this.lblRenewedLicenseID.Text = "???";
            this.lblRenewedLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(504, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "Renewed License ID:     ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalel
            // 
            this.lalel.AutoSize = true;
            this.lalel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalel.Image = ((System.Drawing.Image)(resources.GetObject("lalel.Image")));
            this.lalel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lalel.Location = new System.Drawing.Point(504, 164);
            this.lalel.Name = "lalel";
            this.lalel.Size = new System.Drawing.Size(296, 29);
            this.lalel.TabIndex = 111;
            this.lalel.Text = "Created By:                     ";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoEllipsis = true;
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationDate.Location = new System.Drawing.Point(280, 82);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(49, 29);
            this.lblApplicationDate.TabIndex = 110;
            this.lblApplicationDate.Text = "???";
            this.lblApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(504, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 29);
            this.label12.TabIndex = 109;
            this.label12.Text = "Expiration Date:              ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoEllipsis = true;
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreatedBy.Location = new System.Drawing.Point(806, 164);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(49, 29);
            this.lblCreatedBy.TabIndex = 108;
            this.lblCreatedBy.Text = "???";
            this.lblCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoEllipsis = true;
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOldLicenseID.Location = new System.Drawing.Point(807, 82);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(49, 29);
            this.lblOldLicenseID.TabIndex = 107;
            this.lblOldLicenseID.Text = "???";
            this.lblOldLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Image = ((System.Drawing.Image)(resources.GetObject("Label.Image")));
            this.Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label.Location = new System.Drawing.Point(504, 82);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(297, 29);
            this.Label.TabIndex = 106;
            this.Label.Text = "Old License ID:               ";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRenewLicenseApplicationID
            // 
            this.lblRenewLicenseApplicationID.AutoEllipsis = true;
            this.lblRenewLicenseApplicationID.AutoSize = true;
            this.lblRenewLicenseApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLicenseApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRenewLicenseApplicationID.Location = new System.Drawing.Point(280, 41);
            this.lblRenewLicenseApplicationID.Name = "lblRenewLicenseApplicationID";
            this.lblRenewLicenseApplicationID.Size = new System.Drawing.Size(49, 29);
            this.lblRenewLicenseApplicationID.TabIndex = 105;
            this.lblRenewLicenseApplicationID.Text = "???";
            this.lblRenewLicenseApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoEllipsis = true;
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationFees.Location = new System.Drawing.Point(282, 164);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(49, 29);
            this.lblApplicationFees.TabIndex = 104;
            this.lblApplicationFees.Text = "???";
            this.lblApplicationFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Image = ((System.Drawing.Image)(resources.GetObject("labl.Image")));
            this.labl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labl.Location = new System.Drawing.Point(15, 41);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(270, 29);
            this.labl.TabIndex = 103;
            this.labl.Text = "R.L.Application ID:      ";
            this.labl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(15, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(272, 29);
            this.label20.TabIndex = 102;
            this.label20.Text = "Application Fees:        ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoEllipsis = true;
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExpirationDate.Location = new System.Drawing.Point(806, 123);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(49, 29);
            this.lblExpirationDate.TabIndex = 101;
            this.lblExpirationDate.Text = "???";
            this.lblExpirationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIssueData
            // 
            this.lblIssueData.AutoEllipsis = true;
            this.lblIssueData.AutoSize = true;
            this.lblIssueData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIssueData.Location = new System.Drawing.Point(280, 123);
            this.lblIssueData.Name = "lblIssueData";
            this.lblIssueData.Size = new System.Drawing.Size(49, 29);
            this.lblIssueData.TabIndex = 100;
            this.lblIssueData.Text = "???";
            this.lblIssueData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 29);
            this.label6.TabIndex = 99;
            this.label6.Text = "Application Date:        ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 29);
            this.label4.TabIndex = 98;
            this.label4.Text = "Issue Date:                  ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(878, 992);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 46);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReNew
            // 
            this.btnReNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReNew.Enabled = false;
            this.btnReNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReNew.Image = ((System.Drawing.Image)(resources.GetObject("btnReNew.Image")));
            this.btnReNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReNew.Location = new System.Drawing.Point(1053, 992);
            this.btnReNew.Name = "btnReNew";
            this.btnReNew.Size = new System.Drawing.Size(146, 46);
            this.btnReNew.TabIndex = 107;
            this.btnReNew.Text = "ReNew";
            this.btnReNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReNew.UseVisualStyleBackColor = true;
            this.btnReNew.Click += new System.EventHandler(this.btnReNew_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(12, 219);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(1184, 435);
            this.ctrlDriverLicenseInfo1.TabIndex = 104;
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1214, 1050);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.llblShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmRenewLocalDrivingLicense";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llblShowLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalel;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lblRenewLicenseApplicationID;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblIssueData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Controls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}