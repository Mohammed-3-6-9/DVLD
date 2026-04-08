namespace DVLD
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltersType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainPhoto = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFilterValue.Location = new System.Drawing.Point(375, 282);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(196, 35);
            this.tbFilterValue.TabIndex = 20;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(290, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(290, 6);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Location = new System.Drawing.Point(15, 336);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(1208, 363);
            this.dgvUsers.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(294, 357);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(463, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 52);
            this.label2.TabIndex = 16;
            this.label2.Text = "Manage Users";
            // 
            // cbFiltersType
            // 
            this.cbFiltersType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltersType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFiltersType.FormattingEnabled = true;
            this.cbFiltersType.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName",
            "PersonID",
            "FullName",
            "IsActive"});
            this.cbFiltersType.Location = new System.Drawing.Point(157, 281);
            this.cbFiltersType.Name = "cbFiltersType";
            this.cbFiltersType.Size = new System.Drawing.Size(212, 37);
            this.cbFiltersType.TabIndex = 15;
            this.cbFiltersType.SelectedIndexChanged += new System.EventHandler(this.cbFiltersType_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filtered by :";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsNumber.Location = new System.Drawing.Point(152, 727);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(49, 29);
            this.lblRecordsNumber.TabIndex = 12;
            this.lblRecordsNumber.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "# Records :";
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cbIsActive.Location = new System.Drawing.Point(375, 285);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(196, 28);
            this.cbIsActive.TabIndex = 21;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.BackgroundImage")));
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAddPerson.Location = new System.Drawing.Point(1149, 260);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(74, 57);
            this.btnAddPerson.TabIndex = 19;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click_1);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.addNewPersonToolStripMenuItem.Text = "Add New User";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // pbMainPhoto
            // 
            this.pbMainPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbMainPhoto.Image")));
            this.pbMainPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMainPhoto.InitialImage")));
            this.pbMainPhoto.Location = new System.Drawing.Point(472, 12);
            this.pbMainPhoto.Name = "pbMainPhoto";
            this.pbMainPhoto.Size = new System.Drawing.Size(292, 165);
            this.pbMainPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainPhoto.TabIndex = 17;
            this.pbMainPhoto.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1100, 718);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 46);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1239, 779);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pbMainPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltersType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pbMainPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltersType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}