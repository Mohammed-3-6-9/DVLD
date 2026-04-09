using System;
using System.Configuration;

namespace DataAccessLayer
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString
        {
            get
            {
                var connectionSetting = ConfigurationManager.ConnectionStrings["DVLD_Connection"];
                return connectionSetting != null ? connectionSetting.ConnectionString : "";
            }
        }
    }
}
