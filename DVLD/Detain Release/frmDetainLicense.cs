using Business_Logic;
using DVLD.ApplicationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmDetainLicense : Form
    {
        private int _LicenseID = -1;
        private clsDetainReleaseLicense _DetainLicense = new clsDetainReleaseLicense();

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void ResetDefaultValues()
        {
            lblLicenseID.Text = "???";
            lblDetainID.Text = "???";
            lblDetainDate.Text = "???";
            lblCreatedBy.Text = "???";
        }

        private void PrePrepareFields()
        {
            lblDetainDate.Text = DateTime.Now.ToString();
            lblLicenseID.Text = _LicenseID.ToString();
            lblCreatedBy.Text = clsSessionInfo.CurrentUser.UserName;
        }

        private void Search()
        {
            if (ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(_LicenseID))
            {
                if (!Validation())
                    return;

                PrePrepareFields();

                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnDetain.Enabled = true;
                tbFineFees.Enabled = true;
            }
            else
            {
                llblShowLicenseInfo.Enabled = false;
                llblShowLicensesHistory.Enabled = false;
                btnDetain.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text))
            {
                MessageBox.Show("Please Inser A License ID",
                        "Required License ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                ResetDefaultValues();
            
            _LicenseID = Convert.ToInt32(tbFilterValue.Text.Trim());

            Search();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(((TextBox)sender), "Please Insert a Number");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError((TextBox)sender, "");
            }
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                errorProvider1.SetError(((TextBox)sender), "Please Insert a Number");
                e.Handled = true;
            }
            else
            {
                errorProvider1.SetError((TextBox)sender, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfo1._DriverLicenseData["NationalNo"].ToString());
            frm.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = frmLicenseInfo.CreateByLicenseID(_LicenseID);
            frm.ShowDialog();
        }

        private void PrepareProbertiesAfterSave()
        {
            gbFilter.Enabled = false;
            tbFineFees.Enabled = false;
            llblShowLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            lblDetainID.Text = _DetainLicense.DetainID.ToString();
        }

        private bool Validation()
        {
            if (clsDetainReleaseLicense.IsLicenseDetained(_LicenseID))
            {
                MessageBox.Show("License Is Detained", "Detained License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnDetain.Enabled = false;
                tbFineFees.Enabled = false;
                return false;
            }

            return true;
        }

        private bool FillProperties()
        {
            if(string.IsNullOrEmpty(tbFineFees.Text))
            {
                MessageBox.Show("Please Insert The Fees",
                "Required Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (decimal.TryParse(tbFineFees.Text, out decimal fees))
                _DetainLicense.FineFees = fees;
            else
            {
                MessageBox.Show("Please Insert A Valid Fees",
                "Corrupted Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return  false;
            }

            _DetainLicense.LicenseID = _LicenseID;
            _DetainLicense.DetainDate = DateTime.Now;
            _DetainLicense.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
            return true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(!FillProperties())
            {
                return;
            }

            if (MessageBox.Show("Are You Sure That You Want To Detain License", "Detain License", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            if (_DetainLicense.Save())
            {
                MessageBox.Show("License Detained Successfully with ID = " + _DetainLicense.DetainID, "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdatedEvent?.Invoke();
                PrepareProbertiesAfterSave();
            }
            else
                MessageBox.Show("License Didn't Detained", "Detaine License", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}