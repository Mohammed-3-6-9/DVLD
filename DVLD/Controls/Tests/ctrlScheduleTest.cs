using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls.Tests
{
    public partial class ctrlScheduleTest : UserControl
    {
        enum enMode { AddNew = 0, Update = 1, ReTake = 2 }
        private enMode _Mode;

        clsTestAppointments _TestAppointment;

        private int _LDLAppID = -1;
        private int _TestAppointmentID = -1;
        private bool _reTake = false;
        private clsGeneral.enTestTypes _TestType;
        private int _ReTakeTestAppID { get; set; }
        private int _Trial = 0;
        private string _ClassName = "";
        private string _FullName = "";
        private decimal _Fees = -1;
        private decimal _RetakeTestFees = 0;
        private decimal _TotalFees =-1;

        bool Crash = false;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public ctrlScheduleTest()
        {
            InitializeComponent();

            _ResetDefaultValues();
        }

        private void _ResetDefaultValues()
        {
            lblD_L_AppID.Text = "[???]";
            lblD_Class.Text = "[???]";
            lblName.Text = "[???]";
            lblTrial.Text = "[???]";
            lblFees.Text = "[???]";
            lblReTake_Test_App_ID.Text = "[???]";
            lblReTake_Test_Fees.Text = "[???]";
            lblTotalFees.Text = "[???]";
        }

        private void PrepareScheduleTestScreen()
        {
            if (clsTestAppointments.GetDataForScheduleTest(_LDLAppID, (int)_TestType, ref _ClassName, ref _FullName, ref _Fees, ref _Trial))
            {
                Crash = false;
                lblD_L_AppID.Text = _LDLAppID.ToString();
                lblD_Class.Text = _ClassName;
                lblName.Text = _FullName;
                lblTrial.Text = _Trial.ToString();
                lblFees.Text = _Fees.ToString();
            }
            else
            {
                Crash = true;
                _ResetDefaultValues();
            }

            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        _RetakeTestFees = 0;
                        _ReTakeTestAppID = -1;
                        dtpTestDate.Value = DateTime.Now;
                        gbReTakeTest.Enabled = false;
                        break;
                    }
                case enMode.ReTake:
                    {
                        lblHeader.Text = "Schedule ReTake Test";
                        gbReTakeTest.Enabled = true;
                        _ReTakeTestAppID = _TestAppointmentID;
                        dtpTestDate.Value = DateTime.Now;
                        _RetakeTestFees = clsApplicationType.GetApplicationFees((int)clsGeneral.enApplicationType.RenewDrivingLicenseService);
                        break;
                    }
                case enMode.Update:
                    {
                        if (_Trial > 1)
                        {
                            gbReTakeTest.Enabled = true;
                            _ReTakeTestAppID = _TestAppointmentID;
                            _RetakeTestFees = clsApplicationType.GetApplicationFees((int)clsGeneral.enApplicationType.RenewDrivingLicenseService);
                        }
                        else
                        {
                            gbReTakeTest.Enabled = false;
                            _ReTakeTestAppID = -1;
                            _RetakeTestFees = 0;
                        }

                        dtpTestDate.Value = (_TestAppointment.AppointmentDate < DateTime.Now) ? DateTime.Now : _TestAppointment.AppointmentDate;
                        break;
                    }
            }

            _TotalFees = _Fees + _RetakeTestFees;

            lblTrial.Text = _Trial.ToString();
            lblReTake_Test_Fees.Text = _RetakeTestFees.ToString();
            lblTotalFees.Text = _TotalFees.ToString();
            lblReTake_Test_App_ID.Text = (_ReTakeTestAppID == -1) ? "[N/A]" : _ReTakeTestAppID.ToString();
        }

        private void PrepareMode()
        {
            if (_TestAppointmentID != -1)
                _Mode = enMode.Update;
            else if (_reTake)
                _Mode = enMode.ReTake;
            else
                _Mode = enMode.AddNew;
        }

        private void PrepareScreen()
        {
            switch (_TestType)
            {
                case clsGeneral.enTestTypes.Vision:
                    {
                        groupBox1.Text = "Vision Test";
                        pictureBox2.Image = Properties.Resources.Vision_512;
                        lblHeader.Text = "Schedule Vision Test";
                        break;
                    }
                case clsGeneral.enTestTypes.Written:
                    {
                        groupBox1.Text = "Written Test";
                        pictureBox2.Image = Properties.Resources.Written_Test_512;
                        lblHeader.Text = "Schedule Written Test";
                        break;
                    }
                case clsGeneral.enTestTypes.Practical:
                    {
                        groupBox1.Text = "Driving Test";
                        pictureBox2.Image = Properties.Resources.driving_test_512;
                        lblHeader.Text = "Schedule Driving Test";
                        break;
                    }
            }
        }

        public void SetScheduleTestVariables(int localDrivingLicenseApplicationID, int TestAppointmentID, bool reTake,clsGeneral.enTestTypes TestType)
        {
            _LDLAppID = localDrivingLicenseApplicationID;
            _TestAppointmentID = TestAppointmentID;
            _reTake = reTake;
            _TestType = TestType;
            PrepareMode();

            if (_Mode == enMode.Update)
                _TestAppointment = clsTestAppointments.Find(TestAppointmentID);
            else
                _TestAppointment = new clsTestAppointments();
        }

        private void ctrlVisionTest_Load(object sender, EventArgs e)
        {
            dtpTestDate.MinDate = DateTime.Now;
            PrepareScreen();
            PrepareScheduleTestScreen();
        }

        private void _FillTestAppointment()
        {
            _TestAppointment.TestTypeID = (int)_TestType;
            _TestAppointment.LDLAppID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = _TotalFees;
            _TestAppointment.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;
        }

        private void FreezeScreen()
        {
            btnSave.Enabled = false;
            dtpTestDate.Enabled=false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Crash)
                return;

            _FillTestAppointment();

            if(_TestAppointment.Save())
            {
                MessageBox.Show("Test Apointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FreezeScreen();
                DataUpdatedEvent?.Invoke();
            }
            else
                MessageBox.Show("Person Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}