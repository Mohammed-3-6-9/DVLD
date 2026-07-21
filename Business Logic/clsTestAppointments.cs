using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsTestAppointments
    {
        enum enMode { AddNew = 1, Update = 2 }
        private enMode _Mode;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LDLAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        public clsTestAppointments()
        {
            _Mode = enMode.AddNew;
            TestAppointmentID = -1;
            TestTypeID = -1;
            LDLAppID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = false;
        }

        private clsTestAppointments(int TestAppointmentID, int TestTypeID,
            int LDLAppID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            _Mode = enMode.Update;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
        }

        private bool _AddNew()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(
                TestTypeID, LDLAppID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked);

            return (this.TestAppointmentID != -1);
        }

        private bool _Update()
        {
            return clsTestAppointmentsData.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID,
                this.LDLAppID, this.AppointmentDate,
                this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }

        public static clsTestAppointments Find(int ID)
        {
            int TestTypeID = -1;
            int LDLAppID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;

            if (clsTestAppointmentsData.GetTestAppointmentInfoByID(ID, ref TestTypeID, ref LDLAppID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointments(ID, TestTypeID, LDLAppID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNew())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
            }

            return false;
        }

        public static bool GetDataForScheduleTest(int LocalDrivingLicenseApplicationID, int TestTypeID,
            ref string ClassName, ref string FullName, ref decimal Fees,ref int Trials)
        {

            return clsTestAppointmentsData.GetDataForScheduleTest(LocalDrivingLicenseApplicationID,
                  TestTypeID, ref ClassName, ref FullName, ref Fees, ref Trials);
        }

        public static DataTable GetAllTestAppointmentsForTableView(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllTestAppointmentsForTableView(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static int GetLastTestResult(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetLastTestResult(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public static bool IsThereAnActiveAppointment(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsData.IsThereAnActiveAppointment(LDLAppID, TestTypeID);
        }
    }
}
