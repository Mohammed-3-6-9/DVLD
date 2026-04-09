using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        enum enMode {Read=0,Write=1}

        private short NumOfTries = 0;

        private string _DestinationFile = Path.Combine(Application.StartupPath, "RememberMe.txt");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar == true)
            {
                tbPassword.UseSystemPasswordChar = false;
                btnShowHide.Text = "🔒";
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                btnShowHide.Text = "👁";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool _Validation()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "Please Insert a Value");
                IsValid= false;
            }
            else if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Please Insert a Value");
                IsValid= false;
            }
            else
            {
                errorProvider1.SetError(tbUserName, "");
                errorProvider1.SetError(tbPassword, "");
            }

            return IsValid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_Validation())
                return;

            clsSessionInfo.CurrentUser = clsUser.FindbyUserNameAndPassword(tbUserName.Text, tbPassword.Text);

            if(clsSessionInfo.CurrentUser == null)
            {
                MessageBox.Show("Username or Password Is NOT correct","Login Fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                NumOfTries++;
                return;
            }
            else 
            {
                if (clsSessionInfo.CurrentUser.IsActive)
                {
                    if (chkRememberMe.Checked)
                    {
                        _RememberMe(enMode.Write);
                    }
                    else
                    {
                        if (File.Exists(_DestinationFile))
                            File.Delete(_DestinationFile);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your Account Isn't Active, Call Your Admin", "Login Fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    NumOfTries++;
                }
            }
        }

        void _RememberMe(enMode Mode)
        {
            if(Mode == enMode.Read)
            {
                if (!System.IO.File.Exists(_DestinationFile))
                {
                    return;
                }

                string Line = File.ReadAllText(_DestinationFile);
                string[] Fields = Line.Split('#');
                tbUserName.Text = Fields[0];
                tbPassword.Text = clsUser.DecryptPassword(Fields[1]);
                chkRememberMe.Checked = true;
            }
            else if(Mode == enMode.Write && chkRememberMe.Checked)
            {
                string Line = $"{tbUserName.Text.Trim()}#{clsUser.EncryptPassword(tbPassword.Text.Trim())}";
                File.WriteAllText(_DestinationFile, Line);
                chkRememberMe.Checked = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _RememberMe(enMode.Read);
        }
    }
}
