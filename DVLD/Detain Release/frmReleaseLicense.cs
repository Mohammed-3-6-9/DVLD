using Business_Logic;
using DVLD.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationForms
{
    public partial class frmReleaseLicense : Form
    {
        private int _LicenseID = -1;
        private clsDetainReleaseLicense _DetainedLicense;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmReleaseLicense()
        {
            InitializeComponent();
        }

        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
            gbFilter.Enabled = false;
            Search();
        }

        private void ResetDefaultValues()
        {
            lblLicenseID.Text = "???";
            lblDetainID.Text = "???";
            lblDetainDate.Text = "???";
            lblCreatedBy.Text = "???";
            lblApplicationFees.Text = "???";
            lblTotalFees.Text = "???";
            lblFineFees.Text = "???";
            lblReleaseAppID.Text = "???";
        }

        private void PrePrepareFields()
        {
            decimal appfees = clsApplicationType.GetApplicationFees((int)clsGeneral.enApplicationType.ReleaseDetainedDrivingLicsense);
            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lblTotalFees.Text = (_DetainedLicense.FineFees + appfees).ToString();
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            lblApplicationFees.Text = appfees.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToString();
            lblLicenseID.Text = _LicenseID.ToString();
            lblCreatedBy.Text = clsSessionInfo.CurrentUser.UserName;
        }

        private void Search()
        {
            if (ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(_LicenseID))
            {
                _DetainedLicense = clsDetainReleaseLicense.FindByLicenseID(_LicenseID);

                if (_DetainedLicense == null)
                {
                    MessageBox.Show("License Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDetain.Enabled = false;
                    return;
                }

                if (!Validation())
                    return;

                PrePrepareFields();

                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnDetain.Enabled = true;
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
            llblShowLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            lblReleaseAppID.Text = _DetainedLicense.ReleaseApplicationID.ToString();
            ctrlDriverLicenseInfo1.IsDetained = false;
        }

        private bool Validation()
        {
            if (!clsDetainReleaseLicense.IsLicenseDetained(_LicenseID))
            {
                MessageBox.Show("License Is Released", "Release License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnDetain.Enabled = false;
                return false;
            }

            return true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Release License", "Detain License", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            if (_DetainedLicense.ReleaseDetainedLicense(ctrlDriverLicenseInfo1._DriverLicenseData["NationalNo"].ToString(),
                clsSessionInfo.CurrentUser.UserID))
            {
                MessageBox.Show("License Released Successfully with ID = " + _DetainedLicense.ReleaseApplicationID, "Release License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdatedEvent?.Invoke();
                PrepareProbertiesAfterSave();
            }
            else
                MessageBox.Show("License Didn't Released", "Release License", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
