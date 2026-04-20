using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Logic
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public short ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public int LicenseClassID {  get; set; }

        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 1;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
        }

        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, short ApplicationStatus, DateTime LastStatusDate,
            decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddNew()
        {
            this.ApplicationID = clsApplicationsData.AddNewApplication(this.ApplicantPersonID,
                this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _Validation()
        {
            return !IsPersonHasRunningNewApplication(this.ApplicantPersonID,this.ApplicationTypeID);
        }

        private bool AddNewLocalLicenceApplication()
        {
            clsNewLocalDrivingLicenceApplication application = new clsNewLocalDrivingLicenceApplication();

            application.ApplicationID = this.ApplicationID;
            application.LicenseClassID = this.LicenseClassID;

            return application.Save();
        }

        public bool Save()
        {
            if (!_Validation())
                return false;

            if (_AddNew())
            {
                if (!AddNewLocalLicenceApplication())
                {
                    DeleteApplication(this.ApplicationID);
                    return false;
                }
                else
                    return true;
            }

            return false;
        }

        public static bool IsPersonHasRunningNewApplication(int ApplicantPersonID,int ApplicationTypeID)
        {
            return clsApplicationsData.IsPersonHasRunningNewApplication(ApplicantPersonID, ApplicationTypeID);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsData.DeleteApplication(ApplicationID);
        }
    }
}