using Business_Logic;
using DVLD.Licenses;
using DVLD.Licenses.internationalLicenses;
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
    public partial class frmRenewLocalDrivingLicense : Form
    {
        private int _LocalLicenseID = -1;
        private clsLicenses _LocalLicense = new clsLicenses();

        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void ResetDefaultValues()
        {
            lblRenewedLicenseID.Text = "???";
            lblRenewLicenseApplicationID.Text = "???";
            lblApplicationDate.Text = "???";
            lblIssueData.Text = "???";
            lblApplicationFees.Text = "???";
            lblLicenseFees.Text = "???";
            lblOldLicenseID.Text = "???";
            lblExpirationDate.Text = "???";
            lblCreatedBy.Text = "???";
            lblTotalFees.Text = "???";
        }

        private void PrePrepareFields()
        {
            byte DefaultValidityLength = 0;
            decimal LicenseClassFees = -1;
            clsLicenceClass.GetRenewLicenseRequiredData(_LocalLicense.LicenseClass, ref DefaultValidityLength, ref LicenseClassFees);
            decimal appfees = clsApplicationType.GetApplicationFees((int)clsGeneral.enApplicationType.RenewDrivingLicenseService);

            lblApplicationDate.Text = DateTime.Now.ToString();
            lblIssueData.Text = DateTime.Now.ToString();
            lblApplicationFees.Text = appfees.ToString();
            lblLicenseFees.Text = LicenseClassFees.ToString();
            lblOldLicenseID.Text = _LocalLicenseID.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(DefaultValidityLength).ToString();
            lblCreatedBy.Text = clsSessionInfo.CurrentUser.UserName;
            lblTotalFees.Text = (appfees + LicenseClassFees).ToString();
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

            _LocalLicenseID = Convert.ToInt32(tbFilterValue.Text.Trim());

            if (ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(_LocalLicenseID))
            {
                _LocalLicense = clsLicenses.Find(_LocalLicenseID);

                if (_LocalLicense == null)
                {
                    MessageBox.Show("License Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnReNew.Enabled = false;
                    return;
                }

                if (!Validation())
                    return;

                PrePrepareFields();

                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnReNew.Enabled = true;
            }
            else
            {
                llblShowLicenseInfo.Enabled = false;
                llblShowLicensesHistory.Enabled = false;
                btnReNew.Enabled = false;
            }
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
            frmLicenseInfo frm = frmLicenseInfo.CreateByLicenseID(_LocalLicenseID);
            frm.ShowDialog();
        }

        private void PrepareProbertiesAfterSave(clsLicenses NewLicense)
        {
            gbFilter.Enabled = false;
            llblShowLicenseInfo.Enabled = true;
            btnReNew.Enabled = false;
            _LocalLicenseID = NewLicense.LicenseID;
            ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(_LocalLicenseID);
            lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();
            lblRenewLicenseApplicationID.Text = NewLicense.ApplicationID.ToString();
        }

        private bool Validation()
        {
            if (_LocalLicense.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("License Didn't ReNewed, Today Is Before ExpirationDate", "ReNew License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnReNew.Enabled = false;
                return false;
            }

            if (!_LocalLicense.IsActive)
            {
                MessageBox.Show("License Didn't ReNewed, License Isn't Active", "ReNew License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnReNew.Enabled = false;
                return false;
            }

            return true;
        }

        private void btnReNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Renew License", "ReNew License", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            
            clsLicenses NewLicense = _LocalLicense.RenewLicense(ctrlDriverLicenseInfo1._DriverLicenseData["NationalNo"].ToString(), tbNotes.Text);

            if (NewLicense != null)
            {
                MessageBox.Show("License ReNewed Successfully", "ReNew License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrepareProbertiesAfterSave(NewLicense);
            }
            else
                MessageBox.Show("License Didn't ReNewed", "ReNew License", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
