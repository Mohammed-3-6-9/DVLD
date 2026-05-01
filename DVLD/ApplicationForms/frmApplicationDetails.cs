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
        
        public frmApplicationDetails(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _LDLAppID = localDrivingLicenseApplicationID;
            ctrlApplicationDetails1.FindAppDetails(_LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
