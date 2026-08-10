using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsGeneral
    {
        public enum enApplicationType
        {
            NewLocalDrivingLicenseService = 1, RenewDrivingLicenseService = 2,
            ReplacementforaLostDrivingLicense = 3, ReplacementforaDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6
        }

        public enum enApplicationStatus
        {
            New = 1,
            Canceled = 2,
            Completed =3
        }

        public enum enTestTypes
        {
            Vision = 1,
            Written = 2,
            Practical = 3
        }
    }
}
