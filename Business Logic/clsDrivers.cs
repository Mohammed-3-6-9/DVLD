using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsDrivers
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int DriverID = -1;
        public int PersonID = -1;
        public DateTime CreatedDate;
        public int CreatedByUserID = -1;

        public clsDrivers()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedDate = DateTime.Now;
            CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }

        private clsDrivers(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedDate = CreatedDate;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.DriverID = clsDriversData.AddNewDriver(PersonID, CreatedByUserID, CreatedDate);

            return (this.DriverID != -1);
        }

        private bool _Update()
        {
            return clsDriversData.UpdateDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
        }

        public static clsDrivers Find(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriversData.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID,
                 ref CreatedDate))
            {
                return new clsDrivers(DriverID, PersonID, CreatedByUserID, CreatedDate);
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

        public static DataTable GetAllDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }

        public static bool DeleteDriver(int DriverID)
        {
            return clsDriversData.DeleteDriver(DriverID);
        }

        public static bool IsDriverExist(int DriverID)
        {
            return clsDriversData.IsDriverExist(DriverID);
        }
    }

}