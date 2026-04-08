namespace DVLD.Users
{
    partial class frmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new DVLD.Controls.ctrlPersonCard();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1211, 657);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.gbFilter);
            this.tbPersonInfo.Controls.Add(this.button1);
            this.tbPersonInfo.Controls.Add(this.ctrlPersonCard1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 38);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(1203, 615);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbFilterValue);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(18, 30);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1160, 113);
            this.gbFilter.TabIndex = 100;
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
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(401, 51);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(215, 35);
            this.tbFilterValue.TabIndex = 2;
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
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
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1017, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 99;
            this.button1.Text = "Next";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(18, 161);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.PersonID = -1;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1160, 360);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.btnChangePassword);
            this.tbLoginInfo.Controls.Add(this.label4);
            this.tbLoginInfo.Controls.Add(this.label3);
            this.tbLoginInfo.Controls.Add(this.label2);
            this.tbLoginInfo.Controls.Add(this.label6);
            this.tbLoginInfo.Controls.Add(this.tbConfirmPassword);
            this.tbLoginInfo.Controls.Add(this.tbPassword);
            this.tbLoginInfo.Controls.Add(this.lblUserID);
            this.tbLoginInfo.Controls.Add(this.chkIsActive);
            this.tbLoginInfo.Controls.Add(this.tbUserName);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 38);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(1203, 615);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangePassword.Location = new System.Drawing.Point(169, 455);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(234, 53);
            this.btnChangePassword.TabIndex = 79;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(107, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 78;
            this.label4.Text = "UserName :           ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(116, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Password :           ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(26, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "Confirm Password :           ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(149, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 29);
            this.label6.TabIndex = 75;
            this.label6.Text = "UserID :           ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(325, 309);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(191, 35);
            this.tbConfirmPassword.TabIndex = 8;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(325, 257);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(191, 35);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(320, 156);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(49, 29);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "???";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(325, 373);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(127, 33);
            this.chkIsActive.TabIndex = 2;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(325, 205);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(191, 35);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHeader.Location = new System.Drawing.Point(441, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(301, 52);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(873, 774);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 47);
            this.btnClose.TabIndex = 98;
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
            this.btnSave.Location = new System.Drawing.Point(1062, 774);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 47);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1239, 833);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Label lblHeader;
        private Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}