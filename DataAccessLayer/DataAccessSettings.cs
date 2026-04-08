using System;
using System.Configuration;

namespace DataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLD_Connection"].ConnectionString;
    }
}
