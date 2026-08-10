using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsDetainReleaseLicense
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int DetainID { get; set; } = -1;
        public int LicenseID { get; set; } = -1;
        public DateTime DetainDate { get; set; } = DateTime.Now;
        public decimal FineFees { get; set; } = -1;
        public int CreatedByUserID { get; set; } = -1;
        public bool IsReleased { get; set; } = false;
        public DateTime ReleaseDate { get; set; } = DateTime.MinValue;
        public int ReleasedByUserID { get; set; } = -1;
        public int ReleaseApplicationID { get; set; } = -1;
        public clsDetainReleaseLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            _Mode = enMode.AddNew;
        }

        private clsDetainReleaseLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees,
            int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.DetainID = clsDetainReleaseLicenseData.AddNewDetainedLicense(
                this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _Update()
        {
            return clsDetainReleaseLicenseData.ReleaseDetainedLicense(
                this.DetainID, this.ReleasedByUserID, this.ReleaseApplicationID,this.ReleaseDate);
        }

        public static clsDetainReleaseLicense Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            decimal FineFees = 0;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.MinValue;
            bool IsReleased = false;

            if (clsDetainReleaseLicenseData.GetDetainedLicenseInfoByID(DetainID,
                ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainReleaseLicense(DetainID, LicenseID, DetainDate, FineFees,
                    CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }

        public static clsDetainReleaseLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            decimal FineFees = 0;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.MinValue;
            bool IsReleased = false;

            if (clsDetainReleaseLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID,
                ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainReleaseLicense(DetainID, LicenseID, DetainDate, FineFees,
                    CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainReleaseLicenseData.GetAllDetainedLicenses();
        }

        public static DataTable GetAllDetainedLicensesTableView()
        {
            return clsDetainReleaseLicenseData.GetAllDetainedLicensesTableView();
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainReleaseLicenseData.IsLicenseDetained(LicenseID);
        }

        private clsApplication FillApplicationWithData(int PersonID,int UserID)
        {
            clsApplication app = new clsApplication();
            app.ApplicantPersonID = PersonID;
            app.ApplicationTypeID = (int)clsGeneral.enApplicationType.ReleaseDetainedDrivingLicsense;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationStatus = (int)clsGeneral.enApplicationStatus.Completed;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = clsApplicationType.GetApplicationFees((int)app.ApplicationTypeID);
            app.CreatedByUserID = UserID;
            return app;
        }

        public bool ReleaseDetainedLicense(string NationalNo, int UserID)
        {
            int PersonID = clsPerson.GetPersonIDByNationalNo(NationalNo);
            if (PersonID == -1)
                return false;

            clsApplication app = FillApplicationWithData(PersonID,UserID);

            if (!app.Save())
                return false;

            this.ReleaseApplicationID = app.ApplicationID;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = clsSessionInfo.CurrentUser.UserID;

            return this.Save();
        }
    }
}