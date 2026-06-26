using Business_Logic;
using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Business_Logic.clsNewLocalDrivingLicenceApplication;

namespace DVLD.Controls
{
    public partial class ctrlApplicationDetails : UserControl
    {
        private int _LDLAppID = -1;

        private clsNewLocalDrivingLicenceApplication.stLDLAppFullDetails? _LDLAppFullDetails = new stLDLAppFullDetails();

        public ctrlApplicationDetails()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblDrivingLicenseAppID.Text = "[???]";
            lblAppliedForLicense.Text = "[???]";
            lblPassedTests.Text = "[???]";
            lblApplicationID.Text = "[???]";
            lblStatus.Text = "[???]";
            lblFees.Text = "[???]";
            lblType.Text = "[???]";
            lblApplicant.Text = "[???]";
            lblDate.Text = "[???]";
            lblStatusDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        private void _RefreshDetails()
        {
            _LDLAppFullDetails = clsNewLocalDrivingLicenceApplication.GetLDLAppFullDetailsByID(_LDLAppID);

            if (!_LDLAppFullDetails.HasValue)
            {
                _ResetDefaultValues();
                MessageBox.Show("Not Found");
                return;
            }

            lblDrivingLicenseAppID.Text = _LDLAppFullDetails.Value.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = _LDLAppFullDetails.Value.ClassName;
            lblPassedTests.Text = _LDLAppFullDetails.Value.PassedTests.ToString() + "/3";
            lblApplicationID.Text = _LDLAppFullDetails.Value.ApplicationID.ToString();
            lblStatus.Text = _LDLAppFullDetails.Value.Status.ToString();
            lblFees.Text = _LDLAppFullDetails.Value.PaidFees.ToString();
            lblType.Text = _LDLAppFullDetails.Value.ApplicationTypeTitle.ToString();
            lblApplicant.Text = _LDLAppFullDetails.Value.FullName.ToString();
            lblDate.Text = _LDLAppFullDetails.Value.ApplicationDate.ToString();
            lblStatusDate.Text = _LDLAppFullDetails.Value.LastStatusDate.ToString();
            lblCreatedBy.Text = _LDLAppFullDetails.Value.UserName.ToString();
        }

        public void FindAppDetails(int LDLAppID)
        {
            _LDLAppID = LDLAppID;
            _RefreshDetails();
        }

        private void lblViewPersonInfoLink_LinkClicked(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(_LDLAppFullDetails.Value.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
