using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls.Tests
{
    public partial class ctrlTakeTest : UserControl
    {
        private int _LDLAppID = -1;
        private int _TestAppointmentID = -1;
        private clsGeneral.enTestTypes _TestType;
        private int _Trial = 0;
        private string _ClassName = "";
        private string _FullName = "";
        private decimal _PaidFees = -1;
        private DateTime _AppointmentDate;
        private int _TestID;
        public int TestID { set
            {
                _TestID = value;
                lblTestID.Text = _TestID.ToString();
            }
        }

        public bool Crash = false;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public ctrlTakeTest()
        {
            InitializeComponent();
        }
        
        private void _ResetDefaultValues()
        {
            lblD_L_AppID.Text = "[???]";
            lblD_Class.Text = "[???]";
            lblName.Text = "[???]";
            lblTrial.Text = "[???]";
            lblFees.Text = "[???]";
            lblDate.Text = "[???]";
            lblTestID.Text = "[???]";
        }

        private void PrepareScheduleTestScreen()
        {
            if (clsTests.GetDataForTakeTest(_TestAppointmentID, _LDLAppID, (int)_TestType, ref _ClassName, ref _AppointmentDate, ref _PaidFees, ref _FullName, ref _Trial))
            {
                Crash = false;
                lblD_L_AppID.Text = _LDLAppID.ToString();
                lblD_Class.Text = _ClassName;
                lblName.Text = _FullName;
                lblTrial.Text = _Trial.ToString();
                lblFees.Text = _PaidFees.ToString();
                lblDate.Text = _AppointmentDate.ToString();
            }
            else
            {
                Crash = true;
                _ResetDefaultValues();
            }

            lblTestID.Text = "Not Taken Yet";
        }

        private void PrepareScreen()
        {
            switch (_TestType)
            {
                case clsGeneral.enTestTypes.Vision:
                    {
                        groupBox1.Text = "Vision Test";
                        pictureBox2.Image = Properties.Resources.Vision_512;
                        lblHeader.Text = "Take Vision Test";
                        break;
                    }
                case clsGeneral.enTestTypes.Written:
                    {
                        groupBox1.Text = "Written Test";
                        pictureBox2.Image = Properties.Resources.Written_Test_512;
                        lblHeader.Text = "Take Written Test";
                        break;
                    }
                case clsGeneral.enTestTypes.Practical:
                    {
                        groupBox1.Text = "Driving Test";
                        pictureBox2.Image = Properties.Resources.driving_test_512;
                        lblHeader.Text = "Take Driving Test";
                        break;
                    }
            }
        }

        public void SetTakeTestVariables(int TestAppointmentID, int localDrivingLicenseApplicationID, clsGeneral.enTestTypes TestType)
        {
            _LDLAppID = localDrivingLicenseApplicationID;
            _TestAppointmentID = TestAppointmentID;
            _TestType = TestType;
        }

        private void ctrlTakeTest_Load(object sender, EventArgs e)
        {
            PrepareScreen();
            PrepareScheduleTestScreen();
        }
        
    }
}
