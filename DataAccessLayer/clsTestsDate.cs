using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestsDate
    {
        public static bool GetTestInfoByID(int TestID,ref int TestAppointmentID, ref bool TestResult,
            ref string Notes,ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = reader["Notes"].ToString();
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewTest(int TestAppointmentID, bool TestResult,
            string Notes, int CreatedByUserID)
        {
            int ApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Tests (TestAppointmentID,
               TestResult, Notes, CreatedByUserID) VALUES
               (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)
                 SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                object objID = Command.ExecuteScalar();

                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                    ApplicationID = ID;
            }
            catch
            {
                ApplicationID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return ApplicationID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult,
            string Notes, int CreatedByUserID)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Tests SET
               TestAppointmentID = @TestAppointmentID, TestResult = @TestResult,
               Notes = @Notes, CreatedByUserID = @CreatedByUserID
               WHERE TestID = @TestID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool GetDataForTakeTestScreen(int TestAppointmentID, int LocalDrivingLicenseApplicationID, int TestTypeID, ref string ClassName,
           ref DateTime AppointmentDate, ref decimal PaidFees, ref string FullName, ref int Trials)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ClassName, AppointmentDate, PaidFees, FullName 
                             FROM TestAppointments_View WHERE TestAppointmentID = @TestAppointmentID;
                             SELECT  COUNT(TestAppointments.LocalDrivingLicenseApplicationID) AS Trials
                             FROM TestAppointments WHERE TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID
                             AND TestAppointments.TestTypeID=@TestTypeID;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ClassName = reader["ClassName"].ToString();
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    FullName = reader["FullName"].ToString();
                    PaidFees = (decimal)reader["PaidFees"];

                    if (reader.NextResult() && reader.Read())
                        Trials = Convert.ToInt32(reader["Trials"]);
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
    }
}
