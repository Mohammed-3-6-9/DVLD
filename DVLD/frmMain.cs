using Business_Logic;
using DVLD.ApplicationForms;
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
            // Will Cahange The Argument Value
            frmAddNewLocalDrivingLicenceApplication frm = new frmAddNewLocalDrivingLicenceApplication();
            frm.ShowDialog();
        }

        private void localLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingLicenceApplication frm = new frmAddNewLocalDrivingLicenceApplication();
            frm.ShowDialog();
        }
    }
}
