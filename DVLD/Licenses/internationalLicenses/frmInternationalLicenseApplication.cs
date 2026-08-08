using Business_Logic;
using DVLD.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.internationalLicenses
{
    public partial class frmInternationalLicenseApplication : Form
    {
        private int _LocalLicenseID = -1;
        private int _InternationalLicenseID = -1;
        private clsInternationalLicenses _InterNationalLicense = new clsInternationalLicenses();

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void PrePrepareFields()
        {
            _InterNationalLicense.ApplicantPersonID = clsPerson.GetPersonIDByNationalNo(ctrlDriverLicenseInfo1._DriverLicenseData["NationalNo"].ToString());
            _InterNationalLicense.PaidFees = clsApplicationType.GetApplicationFees(_InterNationalLicense.ApplicationTypeID);

            lblApplicationDate.Text = DateTime.Now.ToString();
            lblIssueData.Text= DateTime.Now.ToString();
            lblFees.Text = _InterNationalLicense.PaidFees.ToString();
            lblLocalLicenseID.Text = _LocalLicenseID.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            lblCreatedBy.Text = clsSessionInfo.CurrentUser.UserName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( tbFilterValue.Text))
            {
                MessageBox.Show("Please Inser A License ID",
                        "Required License ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalLicenseID = Convert.ToInt32(tbFilterValue.Text.Trim());

            if (ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(_LocalLicenseID))
            {
                PrePrepareFields();

                if (clsLicenses.IsLicenseClass3(_LocalLicenseID))
                {
                    llblShowLicensesHistory.Enabled = true;
                    btnIssue.Enabled = true;
                }
                else
                {
                    MessageBox.Show("License Isn't Class 3, You Can't Issue International License From This One",
                        "Required License Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIssue.Enabled = false;
                    llblShowLicenseInfo.Enabled = false;
                    return;
                }

                _InternationalLicenseID = clsInternationalLicenses.IsPersonHasInternationalLicense(_InterNationalLicense.ApplicantPersonID);
                if (_InternationalLicenseID != -1)
                {
                    llblShowLicensesHistory.Enabled = true;
                    llblShowLicenseInfo.Enabled = true;
                    btnIssue.Enabled = false;
                    MessageBox.Show($"Person Already Has InterNational License With ID = {_InternationalLicenseID}",
                    "Issue License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                llblShowLicenseInfo.Enabled = false;
                llblShowLicensesHistory.Enabled = false;
                btnIssue.Enabled = false;
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
            frmInterNationalLicenseInfo frm = new frmInterNationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }

        private void FillApplicationWithData()
        {
            //_InterNationalLicense.ApplicantPersonID = clsPerson.GetPersonIDByNationalNo(ctrlDriverLicenseInfo1._DriverLicenseData["NationalNo"].ToString());
            _InterNationalLicense.ApplicationDate = DateTime.Now;
            _InterNationalLicense.ApplicationStatus = (int)clsGeneral.enApplicationStatus.New;
            _InterNationalLicense.LastStatusDate = DateTime.Now;
            //_InterNationalLicense.PaidFees = clsApplicationType.GetApplicationFees(_InterNationalLicense.ApplicationTypeID);
            _InterNationalLicense.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
        }

        private void FillLicenseWithData()
        {
            _InterNationalLicense.DriverID = (int)ctrlDriverLicenseInfo1._DriverLicenseData["DriverID"];
            _InterNationalLicense.IssuedUsingLocalLicenseID = _LocalLicenseID;
            _InterNationalLicense.IssueDate = DateTime.Now;
            _InterNationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _InterNationalLicense.IsActive = true;
        }

        private void PrepareProbertiesAfterSave()
        {
            _InternationalLicenseID = _InterNationalLicense.InternationalLicenseID;
            llblShowLicenseInfo.Enabled = true;
            btnIssue.Enabled = false;
            lblInternationalLicenseID.Text = _InterNationalLicense.InternationalLicenseID.ToString();
            lblLicenseApplicationID.Text = _InterNationalLicense.ApplicationID.ToString();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            FillApplicationWithData();
            FillLicenseWithData();

            if (_InterNationalLicense.Save())
            {
                MessageBox.Show("License Issued Successfully", "Issue License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrepareProbertiesAfterSave();
                DataUpdatedEvent?.Invoke();
            }
            else
                MessageBox.Show("License Didn't Issued", "Issue License", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
