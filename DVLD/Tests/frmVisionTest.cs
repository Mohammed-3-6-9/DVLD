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
            ctrlApplicationDetails1.FindAppDetails(_LDLAppID);
            _RefreshTableTests();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (dgvManageTestAppointments.Rows.Count > 0)
            {
                if (clsTestAppointments.IsThereAnActiveAppointment(_LDLAppID, (int)clsGeneral.enTestTypes.Vision))
                {
                    MessageBox.Show("Person Already Has an Active Appointment For This Test, You Can't Add New Appointment",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (clsTestAppointments.GetLastTestResult(_LDLAppID,(int)clsGeneral.enTestTypes.Vision) == 1)
                    {
                        MessageBox.Show("Person Already Passed This Test, You Can't Add New Appointment", "Not Allowed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmScheduleTest frm = new frmScheduleTest(_LDLAppID,-1,true);
                        frm.OnTestScheduledSuccessfully += DataUpdated;
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                frmScheduleTest frm = new frmScheduleTest(_LDLAppID);
                frm.OnTestScheduledSuccessfully += DataUpdated;
                frm.ShowDialog();
            }
        }

        void DataUpdated()
        {
            _RefreshTableTests();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (dgvManageTestAppointments.Rows.Count > 0)
            {
                var CurrentRow = dgvManageTestAppointments.CurrentRow;

                if (Convert.ToBoolean(CurrentRow.Cells["IsLocked"].Value) == true)
                {
                    MessageBox.Show("This Test Is Locked, Can't Be Edited",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmScheduleTest frm = new frmScheduleTest(_LDLAppID, (int)CurrentRow.Cells["TestAppointmentID"].Value);
                    frm.OnTestScheduledSuccessfully += DataUpdated;
                    frm.ShowDialog();
                }
            }
        }
    }
}
