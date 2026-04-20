using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsLicenceClass
    {
        public int LicenceClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenceClass()
        {
            LicenceClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
        }

        private clsLicenceClass(int LicenceClassID, string ClassName, string ClassDescription,
            short MinimumAllowedAge, short DefaultValidityLength, decimal ClassFees)
        {
            this.LicenceClassID = LicenceClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenceClass Find(int LicenceClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            short MinimumAllowedAge = 0;
            short DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (clsLicenceClassesData.GetLicenceClassInfoByID(LicenceClassID, ref ClassName,
                ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenceClass(LicenceClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }

        public static DataTable GetAllLicenceClasses()
        {
            return clsLicenceClassesData.GetAllLicenceClasses();
        }

        public static bool IsLicenceClassExist(int LicenceClassID)
        {
            return clsLicenceClassesData.IsLicenceClassExist(LicenceClassID);
        }

        public static DataTable GetAllLicenceClassesIDAndName()
        {
            return clsLicenceClassesData.GetAllLicenceClassesIDAndName();
        }

        public static decimal GetLicenceClassFees(int LicenceCalssID)
        {
            return clsLicenceClassesData.GetLicenceClassFees(LicenceCalssID);
        }
    }
}