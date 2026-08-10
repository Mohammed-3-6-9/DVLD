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
    public partial class frmReplaceForDamageOrLost : Form
    {
        private int _LocalLicenseID = -1;
        private clsLicenses _LocalLicense = new clsLicenses();
        private clsGeneral.enApplicationType _applicationType = clsGeneral.enApplicationType.ReplacementforaLostDrivingLicense;
        decimal _AppFees = -1;
        public frmReplaceForDamageOrLost()
        {
            InitializeComponent();
        }

        private void ResetDefaultValues()
        {
            lblReplacedLicenseID.Text = "???";
            lblApplicationID.Text = "???";
            lblApplicationDate.Text = "???";
            lblApplicationFees.Text = "???";
            lblOldLicenseID.Text = "???";
            lblCreatedBy.Text = "???";
        }

        private void PrePrepareFields()
        {
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblApplicationFees.Text = _AppFees.ToString();
            lblOldLicenseID.Text = _LocalLicenseID.ToString();
            lblCreatedBy.Text = clsSessionInfo.CurrentUser.UserName;
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
            gbReplacementFor.Enabled=false;
            llblShowLicenseInfo.Enabled = true;
            btnReNew.Enabled = false;
            _LocalLicenseID = NewLicense.LicenseID;
            ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(_LocalLicenseID);
            lblReplacedLicenseID.Text = NewLicense.LicenseID.ToString();
            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
        }

        private bool Validation()
        {
            if (!_LocalLicense.IsActive)
            {
                MessageBox.Show("License Didn't Replaced, License Isn't Active", "ReNew License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnReNew.Enabled = false;
                return false;
            }

            if (_LocalLicense.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show("License Can't Replaced, License Is Expired", "Replace License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llblShowLicenseInfo.Enabled = true;
                llblShowLicensesHistory.Enabled = true;
                btnReNew.Enabled = false;

                if (MessageBox.Show("Are You Want To ReNew The License, License Is Expired", "ReNew License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense(_LocalLicenseID);
                    frm.ShowDialog();
                    this.Close();
                }


                return false;
            }

            return true;
        }

        private void btnReNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Replace License", "Replace License", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            clsLicenses NewLicense = _LocalLicense.ReplaceLicense(ctrlDriverLicenseInfo1._DriverLicenseData["NationalNo"].ToString(), _applicationType);

            if (NewLicense != null)
            {
                MessageBox.Show("License Replaced Successfully", "Replace License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrepareProbertiesAfterSave(NewLicense);
            }
            else
                MessageBox.Show("License Didn't Replaced", "Replace License", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmReplaceForDamageOrLost_Load(object sender, EventArgs e)
        {
            rbLostLicense.Checked= true;
            _AppFees = clsApplicationType.GetApplicationFees((int)_applicationType);
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if(rbLostLicense.Checked)
            {
                _applicationType = clsGeneral.enApplicationType.ReplacementforaLostDrivingLicense;
                lblHeader.Text = "Replacement For Lost License";
            }
            else
            {
                _applicationType = clsGeneral.enApplicationType.ReplacementforaDamagedDrivingLicense;
                lblHeader.Text = "Replacement For Damage License";
            }

            _AppFees = clsApplicationType.GetApplicationFees((int)_applicationType);
            lblApplicationFees.Text = _AppFees.ToString();
        }
    }
}
