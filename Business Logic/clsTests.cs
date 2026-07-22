using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Note { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Note = "";
            CreatedByUserID = -1;
        }

        private clsTests(int TestID, int TestAppointmentID, bool TestResult,
            string Note, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Note = Note;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddNew()
        {
            this.TestID = clsTestsDate.AddNewTest(TestAppointmentID, TestResult, Note, CreatedByUserID);

            return (this.TestID != -1);
        }

        private bool _Update()
        {
            return clsTestsDate.UpdateTest(this.TestID, this.TestAppointmentID,
                this.TestResult, this.Note, this.CreatedByUserID);
        }

        public static clsTests Find(int ID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Note = "";
            int CreatedByUserID = -1;

            if (clsTestsDate.GetTestInfoByID(ID, ref TestAppointmentID, ref TestResult,
                ref Note, ref CreatedByUserID))
            {
                return new clsTests(ID, TestAppointmentID, TestResult, Note, CreatedByUserID);
            }
            else
                return null;
        }

        public bool Save()
        {
            if (_AddNew())
                return true;
            else
                return false;
        }

        public static bool GetDataForTakeTest(int TestAppointmentID, int LocalDrivingLicenseApplicationID, int TestTypeID,
            ref string ClassName, ref DateTime AppointmentDate, ref decimal PaidFees, ref string FullName, ref int Trials)
        {

            return clsTests.GetDataForTakeTest(TestAppointmentID, LocalDrivingLicenseApplicationID,
                  TestTypeID, ref ClassName, ref AppointmentDate, ref PaidFees, ref FullName, ref Trials);
        }

    }
}