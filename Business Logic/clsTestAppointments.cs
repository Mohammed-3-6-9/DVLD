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
        public int RetakeTestApplicationID { get; set; }

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
            RetakeTestApplicationID = -1;
        }

        private clsTestAppointments(int TestAppointmentID, int TestTypeID,
            int LDLAppID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            _Mode = enMode.Update;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
        }

        private bool _AddNew()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(
                TestTypeID, LDLAppID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _Update()
        {
            return clsTestAppointmentsData.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID,
                this.LDLAppID, this.AppointmentDate,
                this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);
        }

        public static clsTestAppointments Find(int ID)
        {
            int TestTypeID = -1;
            int LDLAppID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            if (clsTestAppointmentsData.GetTestAppointmentInfoByID(ID, ref TestTypeID, ref LDLAppID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointments(ID, TestTypeID, LDLAppID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }

        public bool Save(int PersonID = -1)
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (this.RetakeTestApplicationID == -1 && PersonID != -1)
                        {
                            clsApplication app = FillApplicationWithData(PersonID);

                            if (!app.Save())
                                return false;

                            this.RetakeTestApplicationID = app.ApplicationID;
                        }

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
            ref string ClassName, ref string FullName, ref int PersonID, ref decimal Fees, ref int Trials)
        {

            return clsTestAppointmentsData.GetDataForScheduleTest(LocalDrivingLicenseApplicationID,
                  TestTypeID, ref ClassName, ref FullName, ref PersonID, ref Fees, ref Trials);
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

        public static bool LockTestAppointment(int TestAppointment)
        {
            return clsTestAppointmentsData.LockTestAppointment(TestAppointment);
        }

        private clsApplication FillApplicationWithData(int PersonID)
        {
            clsApplication app = new clsApplication();
            app.ApplicantPersonID = PersonID;
            app.ApplicationTypeID = (int)clsGeneral.enApplicationType.RetakeTest;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationStatus = (int)clsGeneral.enApplicationStatus.Completed;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = clsApplicationType.GetApplicationFees((int)clsGeneral.enApplicationType.RetakeTest);
            app.CreatedByUserID = this.CreatedByUserID;
            return app;
        }

    }
}
