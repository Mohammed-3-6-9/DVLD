namespace DVLD.ApplicationForms
{
    partial class frmReplaceForDamageOrLost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplaceForDamageOrLost));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lalel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.ctrlDriverLicenseInfo1 = new DVLD.Controls.ctrlDriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoEllipsis = true;
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(803, 51);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(49, 29);
            this.lblReplacedLicenseID.TabIndex = 113;
            this.lblReplacedLicenseID.Text = "???";
            this.lblReplacedLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbFilter.Location = new System.Drawing.Point(30, 85);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(760, 113);
            this.gbFilter.TabIndex = 119;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReplacedLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lalel);
            this.groupBox1.Controls.Add(this.lblApplicationDate);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.lblApplicationID);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.labl);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(30, 662);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 196);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoEllipsis = true;
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationDate.Location = new System.Drawing.Point(280, 97);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(49, 29);
            this.lblApplicationDate.TabIndex = 110;
            this.lblApplicationDate.Text = "???";
            this.lblApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoEllipsis = true;
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreatedBy.Location = new System.Drawing.Point(806, 143);
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
            this.lblOldLicenseID.Location = new System.Drawing.Point(807, 97);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(49, 29);
            this.lblOldLicenseID.TabIndex = 107;
            this.lblOldLicenseID.Text = "???";
            this.lblOldLicenseID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoEllipsis = true;
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationID.Location = new System.Drawing.Point(280, 51);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(49, 29);
            this.lblApplicationID.TabIndex = 105;
            this.lblApplicationID.Text = "???";
            this.lblApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoEllipsis = true;
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicationFees.Location = new System.Drawing.Point(282, 143);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(49, 29);
            this.lblApplicationFees.TabIndex = 104;
            this.lblApplicationFees.Text = "???";
            this.lblApplicationFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(332, 888);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(209, 29);
            this.llblShowLicenseInfo.TabIndex = 118;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // llblShowLicensesHistory
            // 
            this.llblShowLicensesHistory.AutoSize = true;
            this.llblShowLicensesHistory.Enabled = false;
            this.llblShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llblShowLicensesHistory.Location = new System.Drawing.Point(25, 888);
            this.llblShowLicensesHistory.Name = "llblShowLicensesHistory";
            this.llblShowLicensesHistory.Size = new System.Drawing.Size(256, 29);
            this.llblShowLicensesHistory.TabIndex = 117;
            this.llblShowLicensesHistory.TabStop = true;
            this.llblShowLicensesHistory.Text = "Show Licenses History";
            this.llblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicensesHistory_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(266, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(613, 52);
            this.lblHeader.TabIndex = 114;
            this.lblHeader.Text = "Replacement For Lost License";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(877, 879);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 46);
            this.btnClose.TabIndex = 116;
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
            this.btnReNew.Location = new System.Drawing.Point(1052, 879);
            this.btnReNew.Name = "btnReNew";
            this.btnReNew.Size = new System.Drawing.Size(146, 46);
            this.btnReNew.TabIndex = 115;
            this.btnReNew.Text = "ReNew";
            this.btnReNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReNew.UseVisualStyleBackColor = true;
            this.btnReNew.Click += new System.EventHandler(this.btnReNew_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(504, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "Replaced License ID:     ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalel
            // 
            this.lalel.AutoSize = true;
            this.lalel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalel.Image = ((System.Drawing.Image)(resources.GetObject("lalel.Image")));
            this.lalel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lalel.Location = new System.Drawing.Point(504, 143);
            this.lalel.Name = "lalel";
            this.lalel.Size = new System.Drawing.Size(296, 29);
            this.lalel.TabIndex = 111;
            this.lalel.Text = "Created By:                     ";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Image = ((System.Drawing.Image)(resources.GetObject("Label.Image")));
            this.Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label.Location = new System.Drawing.Point(504, 97);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(297, 29);
            this.Label.TabIndex = 106;
            this.Label.Text = "Old License ID:               ";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.Image = ((System.Drawing.Image)(resources.GetObject("labl.Image")));
            this.labl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labl.Location = new System.Drawing.Point(15, 51);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(270, 29);
            this.labl.TabIndex = 103;
            this.labl.Text = "L.R.Application ID:      ";
            this.labl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(15, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(272, 29);
            this.label20.TabIndex = 102;
            this.label20.Text = "Application Fees:        ";
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
            this.label6.Size = new System.Drawing.Size(267, 29);
            this.label6.TabIndex = 99;
            this.label6.Text = "Application Date:        ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbReplacementFor.Location = new System.Drawing.Point(842, 85);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(341, 113);
            this.gbReplacementFor.TabIndex = 120;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For";
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(6, 34);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(233, 33);
            this.rbDamagedLicense.TabIndex = 122;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Checked = true;
            this.rbLostLicense.Location = new System.Drawing.Point(6, 74);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(173, 33);
            this.rbLostLicense.TabIndex = 123;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(14, 221);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(1184, 435);
            this.ctrlDriverLicenseInfo1.TabIndex = 112;
            // 
            // frmReplaceForDamageOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1214, 940);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReNew);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.llblShowLicensesHistory);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReplaceForDamageOrLost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReplaceForDamageOrLost";
            this.Load += new System.EventHandler(this.frmReplaceForDamageOrLost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReNew;
        private Controls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalel;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llblShowLicensesHistory;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}