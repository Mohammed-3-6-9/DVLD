using Business_Logic;
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
    public partial class Form1 : Form
    {
        public Form1()
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












        // Not Tested Yet
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsSessionInfo.CurrentUser.UserID);
            frm.ShowDialog();
        }
        // Not Tested Yet
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(clsSessionInfo.CurrentUser.UserID);
            frm.ShowDialog();
        }
    }
}
