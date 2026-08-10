using Business_Logic;
using DVLD.ApplicationForms;
using DVLD.Detain_Release;
using DVLD.Licenses;
using DVLD.Licenses.internationalLicenses;
using DVLD.Test_Types;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople frm = new frmPeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(clsSessionInfo.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsSessionInfo.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenceApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicatons frm = new frmManageApplicatons();
            frm.ShowDialog();
        }

        private void localLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingLicenceApplication frm = new frmAddNewLocalDrivingLicenceApplication();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frm = new frmDrivers();
            frm.ShowDialog();
        }

        private void internationalLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalLicenceApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenseApplications frm = new frmManageInternationalLicenseApplications();
            frm.ShowDialog();
        }

        private void reNewDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frm = new frmRenewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void replcaementForDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceForDamageOrLost frm = new frmReplaceForDamageOrLost();
            frm.ShowDialog();
        }

        private void detainLicenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releaseLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.ShowDialog();
        }

        private void manageDetainedLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicatons frm = new frmManageApplicatons();
            frm.ShowDialog();
        }
    }
}
