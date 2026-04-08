using Business_Logic;
using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        private int _UserID { get; set; }
        private int _PersonID { get; set; }
        private clsUser _User;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmAddEditUser(int UserID, int PersonID)
        {
            InitializeComponent();

            _UserID = UserID;
            _PersonID= PersonID;
            ctrlPersonCard1.PersonID = PersonID;
            gbFilter.Enabled = false;
            _Mode = enMode.Update;
        }

        public frmAddEditUser()
        {
            InitializeComponent();

            _UserID = -1;
            _PersonID = -1;
            btnChangePassword.Enabled = false;
            _Mode = enMode.AddNew;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        void _FillFieldsByUserData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No User with ID = " + _UserID);
                this.Close();
                return;
            }

            lblUserID.Text = _UserID.ToString();
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            tbPassword.Enabled = tbConfirmPassword.Enabled = false;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;

            if (_Mode == enMode.Update)
            {
                _FillFieldsByUserData();
                lblHeader.Text = "Update User";
            }
            else
            {
                _User = new clsUser();
                lblHeader.Text = "Add New User";
            }
        }

        void _FillUserWithData()
        {
            _User.UserName = tbUserName.Text;
            _User.PersonID = _PersonID;
            _User.IsActive = chkIsActive.Checked;
            _User.Password = tbPassword.Text;
        }

        void IDSentBack(object sender, int PersonID)
        {
            _PersonID = PersonID;
            ctrlPersonCard1.FillCardWithData(_PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.SendIDBackEvent += IDSentBack;
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFilterValue.Text))
            {
                return;
            }

            if (cbFilter.SelectedItem.ToString()=="PersonID")
            {
                _PersonID = int.Parse(tbFilterValue.Text);

                if (clsPerson.IsPersonHasUser(_PersonID))
                {
                    MessageBox.Show("Person is Already a User", "Ops",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _PersonID = ctrlPersonCard1.FillCardWithData(_PersonID);

                if (_PersonID == -1)
                {
                    MessageBox.Show("Person is Not Found", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (clsPerson.IsPersonHasUser(tbFilterValue.Text))
                {
                    MessageBox.Show("Person is Already a User", "Ops",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                _PersonID = ctrlPersonCard1.FillCardWithData(tbFilterValue.Text);

                if (_PersonID == -1)
                {
                    MessageBox.Show("Person is Not Found", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Text = "";
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    errorProvider1.SetError(((TextBox)sender), "Please Insert a Nuber");
                    e.Handled = true;
                }
            }
        }

        private bool _Validation()
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Please Set a Person", "Missed Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl1.SelectedIndex = 0;
                return false;
            }

            if (_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserNameExist(tbUserName.Text))
                {
                    errorProvider1.SetError(tbUserName, "UserName Is Already Exist");
                    return false;
                }
            }
            else
            {
                if(tbUserName.Text!=_User.UserName)
                {
                    if (clsUser.IsUserNameExist(tbUserName.Text))
                    {
                        errorProvider1.SetError(tbUserName, "UserName Is Already Exist");
                        return false;
                    }
                }
            }

            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                return false;
            }

            return true;
        }

        private void AdjustControls()
        {
            tbPassword.Enabled = tbConfirmPassword.Enabled = false;
            btnChangePassword.Enabled = true;
            gbFilter.Enabled = false;
            lblHeader.Text = "Update User";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (!_Validation())
                return;

            _FillUserWithData();

            if (_User.Save())
            {
                MessageBox.Show("User Saved Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                AdjustControls();
                _UserID = _User.UserID;
                lblUserID.Text = _UserID.ToString();
                DataUpdatedEvent?.Invoke();
            }
            else
                MessageBox.Show("User Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
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
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Please Confirm Password");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(_UserID);
            frm.ShowDialog();
        }
    }
}
