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

namespace DVLD.Tests
{
    public partial class frmVisionTest : Form
    {
        private int _LDLAppID = -1;
        private DataView _DataView;

        public frmVisionTest(int localDrivingLicenseApplicationID)
        {
            _LDLAppID = localDrivingLicenseApplicationID;

            InitializeComponent();
        }

        private void _RefreshTableTests()
        {
            DataTable dt = clsTestAppointments.GetAllTestAppointmentsForTableView((int)_LDLAppID, (int)clsGeneral.enTestTypes.Vision);

            _DataView = dt.DefaultView;
            dgvManageTestAppointments.DataSource = _DataView;

            lblRecordsNumber.Text = dgvManageTestAppointments.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            _RefreshTableTests();
            ctrlApplicationDetails1.FindAppDetails(_LDLAppID);
        }
    }
}
