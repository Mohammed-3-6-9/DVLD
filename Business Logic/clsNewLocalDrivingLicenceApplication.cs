using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsNewLocalDrivingLicenceApplication
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsNewLocalDrivingLicenceApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            _Mode = enMode.AddNew;
        }

        private clsNewLocalDrivingLicenceApplication(int LocalDrivingLicenseApplicationID,
            int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            _Mode = enMode.Update;
        }


        private bool _AddNew()
        {
            this.LocalDrivingLicenseApplicationID = clsNewLocalDrivingLicenceApplicationData.AddNewLocalDrivingLicenceApplication(
                ApplicationID, LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _Update()
        {
            return clsNewLocalDrivingLicenceApplicationData.UpdateLocalDrivingLicenceApplication(
                this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public static clsNewLocalDrivingLicenceApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsNewLocalDrivingLicenceApplicationData.GetLocalDrivingLicenceApplicationInfoByID(LocalDrivingLicenseApplicationID,
                ref ApplicationID, ref LicenseClassID))
            {
                return new clsNewLocalDrivingLicenceApplication(LocalDrivingLicenseApplicationID,
                    ApplicationID, LicenseClassID);
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

        public static DataTable GetAllLocalDrivingLicenceApplications()
        {
            return clsNewLocalDrivingLicenceApplicationData.GetAllLocalDrivingLicenceApplications();
        }

        public static bool DeleteLocalDrivingLicenceApplication(int LocalDrivingLicenseApplicationID)
        {
            return clsNewLocalDrivingLicenceApplicationData.DeleteLocalDrivingLicenceApplication(LocalDrivingLicenseApplicationID);
        }

        public static bool IsLocalDrivingLicenseApplicationExist(int LocalDrivingLicenseApplicationID)
        {
            return clsNewLocalDrivingLicenceApplicationData.IsLocalDrivingLicenseApplicationExist(LocalDrivingLicenseApplicationID);
        }
    }
}