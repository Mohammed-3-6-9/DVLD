using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDetainReleaseLicenseData
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID, ref int LicenseID,
            ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
            ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID,
            ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToDecimal(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (reader["ReleaseDate"] == DBNull.Value) ? DateTime.MinValue : (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? -1 : (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? -1 : (int)reader["ReleaseApplicationID"];
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

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID,
            ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
            ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID,
            ref int ReleaseApplicationID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT TOP 1 * FROM DetainedLicenses 
                            WHERE LicenseID = @LicenseID 
                            ORDER BY DetainID DESC";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToDecimal(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    ReleaseDate = (reader["ReleaseDate"] == DBNull.Value) ? DateTime.MinValue : (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (reader["ReleasedByUserID"] == DBNull.Value) ? -1 : (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (reader["ReleaseApplicationID"] == DBNull.Value) ? -1 : (int)reader["ReleaseApplicationID"];
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

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID)
        {
            int DetainID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                            VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                object objID = Command.ExecuteScalar();

                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                    DetainID = ID;
            }
            catch
            {
                DetainID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return DetainID;
        }

        public static bool ReleaseDetainedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID,DateTime ReleaseDate)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE DetainedLicenses
                            SET IsReleased = 1,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                            WHERE DetainID = @DetainID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM DetainedLicenses";
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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                object obj = Command.ExecuteScalar();

                if (obj != null)
                    IsDetained = true;
            }
            catch
            {
                IsDetained = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsDetained;
        }

        public static DataTable GetAllDetainedLicensesTableView()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM DetainedLicenses_View";
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