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

namespace DVLD.ApplicationForms
{
    public partial class frmApplicationDetails : Form
    {
        private int _LDLAppID = -1;
        private clsNewLocalDrivingLicenceApplication.stLDLAppFullDetails? _LDLAppFullDetails = new stLDLAppFullDetails();
        
        public frmApplicationDetails(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LDLAppID = localDrivingLicenseApplicationID;
        }

        private void _RefreshDetails()
        {
            _LDLAppFullDetails = clsNewLocalDrivingLicenceApplication.GetLDLAppFullDetailsByID(_LDLAppID);

            if (!_LDLAppFullDetails.HasValue)
            {
                MessageBox.Show("Not Found");
                this.Close();
                return;
            }

            lblDrivingLicenseAppID.Text = _LDLAppFullDetails.Value.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = _LDLAppFullDetails.Value.CalssName;
            lblPassedTests.Text = _LDLAppFullDetails.Value.PassedTests.ToString() + "/3";
            lblApplicationID.Text = _LDLAppFullDetails.Value.ApplicationID.ToString();
            lblStatus.Text = _LDLAppFullDetails.Value.Status.ToString();
            lblFees.Text = _LDLAppFullDetails.Value.PaidFees.ToString();
            lblType.Text = _LDLAppFullDetails.Value.ApplicationTypeTitle.ToString();
            lblApplicant.Text = _LDLAppFullDetails.Value.FullName.ToString();
            lblDate.Text = _LDLAppFullDetails.Value.ApplicationDate.ToString();
            lblStatusDate.Text = _LDLAppFullDetails.Value.ToString();
            lblCreatedBy.Text = _LDLAppFullDetails.Value.UserName.ToString();
        }

        private void frmApplicationDetails_Load(object sender, EventArgs e)
        {
            _RefreshDetails();
        }

        private void lblViewPersonInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(_LDLAppFullDetails.Value.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
