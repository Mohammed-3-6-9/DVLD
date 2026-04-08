namespace DVLD.People
{
    partial class frmAddEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPerson));
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHeader.Location = new System.Drawing.Point(468, 33);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(345, 52);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Add New Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "PersonID :        ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPersonID.Location = new System.Drawing.Point(220, 119);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(62, 32);
            this.lblPersonID.TabIndex = 3;
            this.lblPersonID.Text = "???";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(762, 283);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(247, 35);
            this.dtpDateOfBirth.TabIndex = 99;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 3, 25, 0, 0, 0, 0);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.llRemoveImage.Location = new System.Drawing.Point(1113, 567);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(94, 26);
            this.llRemoveImage.TabIndex = 98;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.Visible = false;
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.llSetImage.Location = new System.Drawing.Point(1104, 527);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(112, 26);
            this.llSetImage.TabIndex = 97;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(659, 596);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 47);
            this.btnClose.TabIndex = 96;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(848, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 47);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Location = new System.Drawing.Point(218, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 42);
            this.panel1.TabIndex = 94;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMale.Image = ((System.Drawing.Image)(resources.GetObject("rbMale.Image")));
            this.rbMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbMale.Location = new System.Drawing.Point(3, 5);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(123, 33);
            this.rbMale.TabIndex = 58;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbFemale.Image = ((System.Drawing.Image)(resources.GetObject("rbFemale.Image")));
            this.rbFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbFemale.Location = new System.Drawing.Point(132, 5);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(152, 33);
            this.rbFemale.TabIndex = 57;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbFemale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(1115, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 29);
            this.label12.TabIndex = 93;
            this.label12.Text = "Last";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbLastName.Location = new System.Drawing.Point(1034, 226);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(247, 35);
            this.tbLastName.TabIndex = 92;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(569, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 29);
            this.label11.TabIndex = 91;
            this.label11.Text = "Second";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(308, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "First";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(853, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 89;
            this.label3.Text = "Third";
            // 
            // tbThirdName
            // 
            this.tbThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbThirdName.Location = new System.Drawing.Point(762, 226);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(247, 35);
            this.tbThirdName.TabIndex = 88;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSecondName.Location = new System.Drawing.Point(490, 226);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(247, 35);
            this.tbSecondName.TabIndex = 87;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(762, 403);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(247, 37);
            this.cbCountry.TabIndex = 86;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPhone.Location = new System.Drawing.Point(762, 344);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(247, 35);
            this.tbPhone.TabIndex = 85;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEmail.Location = new System.Drawing.Point(218, 404);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(247, 35);
            this.tbEmail.TabIndex = 84;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNationalNo.Location = new System.Drawing.Point(218, 283);
            this.tbNationalNo.MaxLength = 14;
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(247, 35);
            this.tbNationalNo.TabIndex = 83;
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAddress.Location = new System.Drawing.Point(218, 461);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(791, 119);
            this.tbAddress.TabIndex = 82;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFirstName.Location = new System.Drawing.Point(218, 226);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(247, 35);
            this.tbFirstName.TabIndex = 81;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(595, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 29);
            this.label10.TabIndex = 80;
            this.label10.Text = "Country:      ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(609, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 79;
            this.label8.Text = "Phone:      ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(14, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 29);
            this.label9.TabIndex = 78;
            this.label9.Text = "Address:           ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(535, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 29);
            this.label6.TabIndex = 77;
            this.label6.Text = "Date Of Birth:      ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(15, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 76;
            this.label7.Text = "Email:               ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(15, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "Gendor:            ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(14, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 74;
            this.label5.Text = "National No:     ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(13, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 29);
            this.label13.TabIndex = 73;
            this.label13.Text = "Name:               ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(1034, 283);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(247, 230);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 72;
            this.pbPersonImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1331, 670);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.llRemoveImage);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNationalNo);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPerson";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}