using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationTypesData
    {
        public static bool GetApplicationTypeInfo(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    ApplicationFees = Convert.ToDecimal(reader["ApplicationFees"]);
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


        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE ApplicationTypes SET
                            ApplicationTypeTitle = @ApplicationTypeTitle,
                            ApplicationFees = @ApplicationFees
                            WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationTypeID, ApplicationTypeTitle,
                            ApplicationFees FROM ApplicationTypes";
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

        public static decimal GetApplicationFees(int ApplicationTypeID)
        {
            decimal Fees = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationFees FROM ApplicationTypes
                             WHERE ApplicationTypes.ApplicationTypeID = @ApplicationTypeID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    Fees = -1;
                else
                    Fees = decimal.Parse(result.ToString());
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