using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int LicenseID = -1;
        public int ApplicationID = -1;
        public int DriverID = -1;
        public int LicenseClass = -1;
        public DateTime IssueDate;
        public DateTime ExpirationDate;
        public string Notes = "";
        public decimal PaidFees = -1;
        public bool IsActive = false;
        public short IssueReason = -1;
        public int CreatedByUserID = -1;

        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = -1;
            IsActive = false;
            IssueReason = -1;
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsLicenses(int LicenseID, int ApplicationID, int DriverID,
                 int LicenseClass, DateTime IssueDate,
                 DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive
                , short IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.LicenseID = clsLicensesData.AddNewLicense(ApplicationID, DriverID,
                  LicenseClass, IssueDate,
                  ExpirationDate, Notes, PaidFees, IsActive
                , IssueReason, CreatedByUserID);

            return (this.LicenseID != -1);
        }

        private bool _Update()
        {
            return clsLicensesData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID,
                  this.LicenseClass, this.IssueDate,
                  this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive
                , this.IssueReason, this.CreatedByUserID);
        }

        public static clsLicenses Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            short IssueReason = -1;
            int CreatedByUserID = -1;

            if (clsLicensesData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID,
                 ref LicenseClass, ref IssueDate,
                  ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive
                , ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID,
                  LicenseClass, IssueDate,
                  ExpirationDate, Notes, PaidFees, IsActive
                , IssueReason, CreatedByUserID);
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

        public static DataTable GetAllLicenses()
        {
            return clsLicensesData.GetAllLicenses();
        }

        public static bool DeleteLicense(int PersonID)
        {
            return clsLicensesData.DeleteLicense(PersonID);
        }

        public static bool IsLicenseExist(int PersonID)
        {
            return clsLicensesData.IsLicenseExist(PersonID);
        }

        public static bool IsPersonHasThisLicense(string NationalNo, string ClassName)
        {
            return clsLicensesData.IsPersonHasThisLicense(NationalNo, ClassName);
        }
    }
}