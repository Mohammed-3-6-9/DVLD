using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        public frmChangePassword(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void frmChangePasswordForm1_Load(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(_UserID);

            if (User == null)
            {
                MessageBox.Show($"Couldn't Find User");
                this.Close();
                return;
            }

            ctrlPersonCard1.PersonID = User.PersonID;
            ctrlLoginInformation1.UserID = User.UserID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.UseSystemPasswordChar == true)
            {
                tbCurrentPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;
                tbNewPassword.UseSystemPasswordChar = false;
                btnShowHide.Text = "🔒";
            }
            else
            {
                tbCurrentPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;
                tbNewPassword.UseSystemPasswordChar = true;
                btnShowHide.Text = "👁";
            }
        }

        private bool _Validation()
        {
            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                return false;
            }

            return true;
        }

        private void _SetFields()
        {
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPassword.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (!_Validation())
                return;

            if (clsUser.ChangePassword(_UserID,tbCurrentPassword.Text, tbNewPassword.Text))
            {
                _SetFields();
               MessageBox.Show("Password Cahnged Successfully","Done");
            }
            else
            {
                MessageBox.Show("Current Password isn't Correct, Password doesn't Changed", "Fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                //((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "Please Insert a Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Please Confirm Password");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
