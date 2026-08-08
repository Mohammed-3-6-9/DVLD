using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsInternationalLicenses:clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; } = -1;
        public int DriverID { get; set; } = -1;
        public int IssuedUsingLocalLicenseID { get; set; } = -1;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } = false;

        public clsInternationalLicenses()
        {
            this.InternationalLicenseID = -1;
            base.ApplicationID = -1;
            base.ApplicationTypeID = (int)clsGeneral.enApplicationType.NewInternationalLicense;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            base.CreatedByUserID = -1;

            _Mode = enMode.AddNew;
        }

        private clsInternationalLicenses(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            base.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            base.ApplicationTypeID = (int)clsGeneral.enApplicationType.NewInternationalLicense;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            base.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(
                base.ApplicationID,
                this.DriverID,
                this.IssuedUsingLocalLicenseID,
                this.IssueDate,
                this.ExpirationDate,
                this.IsActive,
                base.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _Update()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(
                this.InternationalLicenseID,
                base.ApplicationID,
                this.DriverID,
                this.IssuedUsingLocalLicenseID,
                this.IssueDate,
                this.ExpirationDate,
                this.IsActive,
                base.CreatedByUserID);
        }

        public new static clsInternationalLicenses Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(
                InternationalLicenseID,
                ref ApplicationID,
                ref DriverID,
                ref IssuedUsingLocalLicenseID,
                ref IssueDate,
                ref ExpirationDate,
                ref IsActive,
                ref CreatedByUserID))
            {
                return new clsInternationalLicenses(
                    InternationalLicenseID,
                    ApplicationID,
                    DriverID,
                    IssuedUsingLocalLicenseID,
                    IssueDate,
                    ExpirationDate,
                    IsActive,
                    CreatedByUserID);
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
                        if (!base._Save())
                            return false;

                        if (_AddNew())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            clsApplication._DeleteApplication(base.ApplicationID);
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

        public static DataTable GetAllLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static bool DeleteLicense(int LicenseID)
        {
            return clsInternationalLicenseData.DeleteInternationalLicense(LicenseID);
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExist(LicenseID);
        }

        public static int IsPersonHasInternationalLicense(int PersonID)
        {
            return clsInternationalLicenseData.IsPersonHasInternationalLicense(PersonID);
        }

        public static DataRow GetInterNationalDriverInfo(int InternationalLicenseID)
        {
            DataTable dt = clsInternationalLicenseData.GetInterNationalDriverInfo(InternationalLicenseID);
            if (dt.Rows.Count == 0)
                return null;
            else
                return dt.Rows[0];
        }
    }
}