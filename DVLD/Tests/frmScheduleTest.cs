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
    public partial class frmScheduleTest : Form
    {
        clsGeneral.enTestTypes _TestType;
        private int _LDLAppID = -1;
        private bool _reTake = false;
        private int _TestAppointmentID = -1;
        public event Action OnTestScheduledSuccessfully;

        public frmScheduleTest(clsGeneral.enTestTypes TestType,int localDrivingLicenseApplicationID, int TestAppointmentID = -1, bool reTake = false)
        {
            InitializeComponent();

            ctrlVisionTest1.DataUpdatedEvent += DataUpdated;
            _LDLAppID = localDrivingLicenseApplicationID;
            _reTake = reTake;
            _TestAppointmentID = TestAppointmentID;
            _TestType = TestType;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlVisionTest1.ScheduleTest(_LDLAppID, _TestAppointmentID, _reTake, _TestType);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DataUpdated()
        {
            OnTestScheduledSuccessfully?.Invoke();
        }
    }
}
