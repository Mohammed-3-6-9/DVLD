using Business_Logic;
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
    public class clsNewLocalDrivingLicenceApplication : clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsNewLocalDrivingLicenceApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            base.ApplicationID = -1;
            base.ApplicationTypeID = (int)clsGeneral.enApplicationType.NewLocalDrivingLicenseService;
            LicenseClassID = -1;
            _Mode = enMode.AddNew;
        }

        private clsNewLocalDrivingLicenceApplication(int LocalDrivingLicenseApplicationID,
            int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            base.ApplicationID = ApplicationID;
            base.ApplicationTypeID = (int)clsGeneral.enApplicationType.NewLocalDrivingLicenseService;
            this.LicenseClassID = LicenseClassID;
            _Mode = enMode.Update;
        }


        private bool _AddNew()
        {
            this.LocalDrivingLicenseApplicationID = clsNewLocalDrivingLicenceApplicationData.AddNewLocalDrivingLicenceApplication(
                base.ApplicationID, LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _Update()
        {
            return clsNewLocalDrivingLicenceApplicationData.UpdateLocalDrivingLicenceApplication(
                this.LocalDrivingLicenseApplicationID, base.ApplicationID, this.LicenseClassID);
        }

        public new static clsNewLocalDrivingLicenceApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int applicationID = -1;
            int LicenseClassID = -1;

            if (clsNewLocalDrivingLicenceApplicationData.GetLocalDrivingLicenceApplicationInfoByID(LocalDrivingLicenseApplicationID,
                ref applicationID, ref LicenseClassID))
            {
                return new clsNewLocalDrivingLicenceApplication(LocalDrivingLicenseApplicationID,
                    applicationID, LicenseClassID);
            }
            else
                return null;
        }

        private bool _Validation()
        {
            return !IsPersonHasRunningNewApplication(this.ApplicantPersonID, this.LicenseClassID);
        }

        public bool Save()
        {
            if (!_Validation())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if(!base._Save())
                            return false;

                        if (_AddNew())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            clsApplication.DeleteApplication(base.ApplicationID);
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

        public static bool IsPersonHasRunningNewApplication(int ApplicantPersonID, int LicenceClassID)
        {
            return clsApplicationsData.IsPersonHasRunningNewApplication(ApplicantPersonID, LicenceClassID);
        }
    }
}