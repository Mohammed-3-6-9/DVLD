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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Licenses
{
    public partial class frmIssueLicense : Form
    {
        private int _LDLAppID;
        private clsLicenses _License;

        private int _ApplicationID = -1;
        private int _LicenseClassID = -1;
        private decimal _PaidFees = -1;
        private int _DefaultValidityLength = -1;
        private int _PersonID = -1;

        public frmIssueLicense(int LDLAppID)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
            ctrlApplicationDetails1.FindAppDetails(_LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool FillFieldsWithDate()
        {
            if (!clsLicenses.GetIssueLicenseRequiredData(_LDLAppID,ref _PersonID, ref _ApplicationID, ref _LicenseClassID, ref _PaidFees, ref _DefaultValidityLength))
                return false;

            _License = new clsLicenses();

            _License.ApplicationID = _ApplicationID;
            _License.LicenseClass = _LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.Notes = tbNotes.Text;
            _License.PaidFees = _PaidFees;
            _License.ExpirationDate = DateTime.Now.AddYears(_DefaultValidityLength);
            _License.IsActive = true;
            _License.IssueReason = 0;
            _License.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
            return true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!FillFieldsWithDate())
                return;

            if (_License.IssueLicense(_PersonID))
            {
                MessageBox.Show("License Issued Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("License Didn't Issued", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
