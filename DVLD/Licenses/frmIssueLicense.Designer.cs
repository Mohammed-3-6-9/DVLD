namespace DVLD.Licenses
{
    partial class frmIssueLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueLicense));
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.ctrlApplicationDetails1 = new DVLD.Controls.ctrlApplicationDetails();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(1012, 788);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(146, 46);
            this.btnIssue.TabIndex = 18;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(837, 788);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 46);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(12, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "Notes :        ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(155, 545);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(997, 218);
            this.tbNotes.TabIndex = 77;
            // 
            // ctrlApplicationDetails1
            // 
            this.ctrlApplicationDetails1.Location = new System.Drawing.Point(7, 31);
            this.ctrlApplicationDetails1.Name = "ctrlApplicationDetails1";
            this.ctrlApplicationDetails1.Size = new System.Drawing.Size(1151, 496);
            this.ctrlApplicationDetails1.TabIndex = 0;
            // 
            // frmIssueLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1164, 846);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ctrlApplicationDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmIssueLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Driving License For First Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlApplicationDetails ctrlApplicationDetails1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNotes;
    }
}