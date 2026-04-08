using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CountryName = reader["CountryName"].ToString();

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

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT CountryID, CountryName FROM Countries;";
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
    }

}