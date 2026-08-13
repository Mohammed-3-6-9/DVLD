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
    public partial class frmMainScheduleTest : Form
    {
        private clsGeneral.enTestTypes _TestType;
        private int _LDLAppID = -1;
        private DataView _DataView;

        public delegate void deDataUpdated();
        public event deDataUpdated ApplicationsDataUpdatedEvent;

        /*
        public frmVisionTest(int localDrivingLicenseApplicationID)
        {
            _LDLAppID = localDrivingLicenseApplicationID;

            InitializeComponent();
        }
        */
        public frmMainScheduleTest(int localDrivingLicenseApplicationID,clsGeneral.enTestTypes TestType)
        {
            _LDLAppID = localDrivingLicenseApplicationID;

            InitializeComponent();
            _TestType = TestType;
        }

        private void _RefreshTableTestAppointments()
        {
            DataTable dt = clsTestAppointments.GetAllTestAppointmentsForTableView((int)_LDLAppID, (int)_TestType);

            _DataView = dt.DefaultView;
            dgvManageTestAppointments.DataSource = _DataView;

            lblRecordsNumber.Text = dgvManageTestAppointments.RowCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrepareForm()
        {
            switch(_TestType)
            {
                case clsGeneral.enTestTypes.Vision:
                    {
                        this.Text = "Vision Test";
                        pictureBox2.Image = Properties.Resources.Vision_512;
                        lblHeader.Text = "Vision Test Appointments";
                        break;
                    }
                case clsGeneral.enTestTypes.Written:
                    {
                        this.Text = "Written Test";
                        pictureBox2.Image = Properties.Resources.Written_Test_512;
                        lblHeader.Text = "Written Test Appointments";
                        break;
                    }
                case clsGeneral.enTestTypes.Practical:
                    {
                        this.Text = "Driving Test";
                        pictureBox2.Image = Properties.Resources.driving_test_512;
                        lblHeader.Text = "Driving Test Appointments";
                        break;
                    }
            }
        }

        private void frmMainScheduleTest_Load(object sender, EventArgs e)
        {
            PrepareForm();
            ctrlApplicationDetails1.FindAppDetails(_LDLAppID);
            _RefreshTableTestAppointments();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (dgvManageTestAppointments.Rows.Count > 0)
            {
                if (clsTestAppointments.IsThereAnActiveAppointment(_LDLAppID, (int)_TestType))
                {
                    MessageBox.Show("Person Already Has an Active Appointment For This Test, You Can't Add New Appointment",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (clsTestAppointments.GetLastTestResult(_LDLAppID,(int)_TestType) == 1)
                    {
                        MessageBox.Show("Person Already Passed This Test, You Can't Add New Appointment", "Not Allowed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmScheduleTest frm = new frmScheduleTest(TestType: _TestType, _LDLAppID, -1, true);
                        frm.OnTestScheduledSuccessfully += DataUpdated;
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                frmScheduleTest frm = new frmScheduleTest(TestType: _TestType, _LDLAppID);
                frm.OnTestScheduledSuccessfully += DataUpdated;
                frm.ShowDialog();
            }
        }

        void DataUpdated()
        {
            _RefreshTableTestAppointments();
            ApplicationsDataUpdatedEvent?.Invoke();
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
                    frmScheduleTest frm = new frmScheduleTest(TestType: _TestType, _LDLAppID, (int)CurrentRow.Cells["TestAppointmentID"].Value);
                    frm.OnTestScheduledSuccessfully += DataUpdated;
                    frm.ShowDialog();
                }
            }
        }

        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            if (dgvManageTestAppointments.Rows.Count > 0)
            {
                var CurrentRow = dgvManageTestAppointments.CurrentRow;

                if (Convert.ToBoolean(CurrentRow.Cells["IsLocked"].Value) == true)
                {
                    MessageBox.Show("This Test Is Already Finished",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmTakeTest frm = new frmTakeTest((int)CurrentRow.Cells["TestAppointmentID"].Value, _LDLAppID, _TestType);
                    frm.DataUpdatedEvent += DataUpdated;
                    frm.ShowDialog();
                }
            }
        }
    }
}
