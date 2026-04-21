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
        private int _ApplicationID { get; set; }
        public int ApplicationID
        {
            get => _ApplicationID;
            set
            {
                _ApplicationID = value;
                if (value != -1)
                    _LoadApplicationData(value);
            }
        }

        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; protected set; }
        public short ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

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
            this._ApplicationID = ApplicationID;
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
            this._ApplicationID = clsApplicationsData.AddNewApplication(this.ApplicantPersonID,
                this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private void _LoadApplicationData(int ID)
        {
            int applicantPersonID = -1;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = -1;
            short applicationStatus = 1;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = -1;
            int createdByUserID = -1;

            if (clsApplicationsData.GetApplicationInfoByID(ID, ref applicantPersonID, ref applicationDate, ref applicationTypeID,
                ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
            {
                this._ApplicationID = ID;
                this.ApplicantPersonID = applicantPersonID;
                this.ApplicationDate = applicationDate;
                this.ApplicationTypeID = applicationTypeID;
                this.ApplicationStatus = applicationStatus;
                this.LastStatusDate =lastStatusDate;
                this.PaidFees = paidFees;
                this.CreatedByUserID = createdByUserID;
            }
        }

        public static clsApplication Find(int ID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            short ApplicationStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = -1;
            int  CreatedByUserID = -1;

            if (clsApplicationsData.GetApplicationInfoByID(ID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                    ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
                return null;
        }

        protected bool _Save()
        {
            return _AddNew();
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsData.DeleteApplication(ApplicationID);
        }
    }
}