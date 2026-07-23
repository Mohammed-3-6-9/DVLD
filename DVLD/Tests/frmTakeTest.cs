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
    public partial class frmTakeTest : Form
    {
        private clsTests _Test;
        clsGeneral.enTestTypes _TestType;
        private int _LDLAppID = -1;
        private int _TestAppointmentID = -1;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmTakeTest(int TestAppointmentID,int LDLAppID, clsGeneral.enTestTypes TestType)
        {
            InitializeComponent();

            _TestAppointmentID = TestAppointmentID;
            _LDLAppID = LDLAppID;
            _TestType=TestType;

            ctrlTakeTest1.SetTakeTestVariables(_TestAppointmentID, _LDLAppID, _TestType);
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            // ctrlTakeTest1.SetTakeTestVariables(_TestAppointmentID, _LDLAppID, _TestType);
            _Test = new clsTests();
        }

        private void _FillTest()
        {
            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = (rbFail.Checked) ? false : true;
            _Test.Note = tbNotes.Text;
            _Test.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
        }

        private void FreezeScreen()
        {
            btnSave.Enabled = false;
            ctrlTakeTest1.Enabled = false;
            panel1.Enabled = false;
            tbNotes.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlTakeTest1.Crash)
                return;

            _FillTest();

            if (_Test.Save())
            {
                MessageBox.Show("Test Result Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlTakeTest1.TestID = _Test.TestID;
                DataUpdatedEvent?.Invoke();
                FreezeScreen();
            }
            else
                MessageBox.Show("Test Result Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
