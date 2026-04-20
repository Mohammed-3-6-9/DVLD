using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLicenceClassesData
    {
        public static bool GetLicenceClassInfoByID(int LicenceClassID, ref string ClassName,
            ref string ClassDescription, ref short MinimumAllowedAge, ref short DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenceClassID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (short)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (short)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];
                }

                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static int AddNewLicenceClass(string ClassName, string ClassDescription,
            short MinimumAllowedAge, short DefaultValidityLength, decimal ClassFees)
        {
            int LicenceClassID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO LicenseClasses
                            (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees) 
                            VALUES
                            (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ClassName", ClassName);
            Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", ClassFees);

            try
            {
                Connection.Open();
                object objID = Command.ExecuteScalar();

                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                    LicenceClassID = ID;
            }
            catch
            {
                LicenceClassID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return LicenceClassID;
        }

        public static bool UpdateLicenceClass(int LicenceClassID, string ClassName,
            string ClassDescription, short MinimumAllowedAge, short DefaultValidityLength, decimal ClassFees)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE LicenseClasses SET
               ClassName = @ClassName, 
               ClassDescription = @ClassDescription,
               MinimumAllowedAge = @MinimumAllowedAge,
               DefaultValidityLength = @DefaultValidityLength,
               ClassFees = @ClassFees
               WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenceClassID);
            Command.Parameters.AddWithValue("@ClassName", ClassName);
            Command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            Command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            Command.Parameters.AddWithValue("@ClassFees", ClassFees);

            try
            {
                Connection.Open();
                RowsEffected = Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return (RowsEffected > 0);
        }

        public static DataTable GetAllLicenceClasses()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM LicenseClasses;";
            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static bool DeleteLicenceClass(int LicenceClassID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenceClassID", LicenceClassID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool IsLicenceClassExist(int LicenceClassID)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenceClassID", LicenceClassID);

            try
            {
                Connection.Open();
                object obj = Command.ExecuteScalar();

                if (obj != null)
                    Exists = true;
            }
            catch
            {
                Exists = false;
            }
            finally
            {
                Connection.Close();
            }

            return Exists;
        }

        public static DataTable GetAllLicenceClassesIDAndName()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseClassID, ClassName FROM LicenseClasses";
            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static decimal GetLicenceClassFees(int LicenceClassID)
        {
            decimal Fees = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ClassFees FROM LicenseClasses
                     WHERE LicenseClassID = @LicenseClassID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenceClassID);

            try
            {
                Connection.Open();
                object fee = Command.ExecuteScalar();

                if (!(fee != null && decimal.TryParse(fee.ToString(), out Fees)))
                    Fees = -1;
            }
            catch
            {
                Fees = -1;
            }
            finally
            {
                Connection.Close();
            }

            return Fees;
        }
    }
}