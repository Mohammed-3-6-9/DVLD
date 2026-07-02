using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls.Tests
{
    public partial class ctrlVisionTest : UserControl
    {
        enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        clsTestAppointments _TestAppointment;

        private int _LDLAppID = -1;
        private int _ReTakeTestAppID { get; set; }
        private int _Trial = 0;
        private int _TestTypeID = (int)clsGeneral.enTestTypes.Vision;
        private string _ClassName = "";
        private string _FullName = "";
        private decimal _Fees = -1;
        private decimal _RetakeTestFees = -1;
        private decimal _TotalFees = -1;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public ctrlVisionTest()
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
            if (clsTestAppointments.GetDataForScheduleTest(_LDLAppID, _TestTypeID, ref _ClassName, ref _FullName, ref _Fees))
            {
                lblD_L_AppID.Text = _LDLAppID.ToString();
                lblD_Class.Text = _ClassName;
                lblName.Text = _FullName;
                lblFees.Text = _Fees.ToString();
            }

            _ReTakeTestAppID = clsTestAppointments.GetLastFailedTest(_LDLAppID);

            if (_ReTakeTestAppID == -1)
            {
                gbReTakeTest.Enabled = false;
                _ReTakeTestAppID = -1;
                _Trial = 0;
                _RetakeTestFees = 0;
                _TotalFees = _Fees;
                lblTrial.Text = _Trial.ToString();
                lblReTake_Test_Fees.Text = _RetakeTestFees.ToString();
                lblTotalFees.Text = _TotalFees.ToString();
            }
            else
            {
                lblHeader.Text = "Schedule ReTake Test";
                gbReTakeTest.Enabled = true;
                _Trial = 0;
                _RetakeTestFees = clsApplicationType.GetApplicationFees((int)clsGeneral.enApplicationType.RenewDrivingLicenseService);
                _TotalFees = _Fees + _RetakeTestFees;
                lblTrial.Text = _Trial.ToString();
                lblReTake_Test_Fees.Text = _RetakeTestFees.ToString();
                lblTotalFees.Text = _TotalFees.ToString();
            }
        }

        public void ScheduleTest(int localDrivingLicenseApplicationID,int TestAppointment,bool reTake)
        {
            _LDLAppID = localDrivingLicenseApplicationID;
            PrepareScheduleTestScreen();
        }

        private void ctrlVisionTest_Load(object sender, EventArgs e)
        {
            dtpTestDate.MinDate = DateTime.Now;

            _TestAppointment = new clsTestAppointments();
        }

        private void _FillTestAppointment()
        {
            _TestAppointment.TestTypeID = (int)clsGeneral.enTestTypes.Vision;
            _TestAppointment.LDLAppID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = _TotalFees;
            _TestAppointment.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_LDLAppID == -1)
                return;

            _FillTestAppointment();

            if(_TestAppointment.Save())
            {
                MessageBox.Show("Test Apointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataUpdatedEvent?.Invoke();
            }
            else
                MessageBox.Show("Person Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}