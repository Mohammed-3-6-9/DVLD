using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLicensesData
    {
        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID,
                ref int LicenseClassID, ref DateTime IssueDate,
                ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive
                , ref byte IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    Notes = reader["Notes"].ToString();
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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

        public static int AddNewLicense(int ApplicationID, int DriverID,
                 int LicenseClassID, DateTime IssueDate,
                 DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive
                , byte IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Licenses (ApplicationID,
               DriverID, LicenseClass, IssueDate,
               ExpirationDate, Notes, PaidFees, IsActive
                ,IssueReason, CreatedByUserID) VALUES
               (@ApplicationID, @DriverID, @LicenseClass, @IssueDate,
               @ExpirationDate, @Notes, @PaidFees, @IsActive
                ,@IssueReason, @CreatedByUserID)
                  SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                object objID = Command.ExecuteScalar();

                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                    LicenseID = ID;
            }
            catch
            {
                LicenseID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID,
                 int LicenseClassID, DateTime IssueDate,
                 DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive
                , byte IssueReason, int CreatedByUserID)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Licenses SET
               ApplicationID = @ApplicationID, DriverID = @DriverID, LicenseClass = @LicenseClass,
               IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Notes = @Notes,
               PaidFees = @PaidFees, IsActive = @IsActive,IssueReason = @IssueReason, CreatedByUserID = @CreatedByUserID
               WHERE LicenseID = @LicenseID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseID, ApplicationID,
               DriverID, LicenseClass, IssueDate,
               ExpirationDate, Notes, PaidFees, IsActive
                ,IssueReason, CreatedByUserID FROM Licenses";
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

        public static bool DeleteLicense(int LicenseID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Delete FROM Licenses Where LicenseID = @LicenseID;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool IsLicenseExist(int LicenseID)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM Licenses Where LicenseID = @LicenseID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool IsPersonHasThisLicense(string NationalNo,string ClassName)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1
                    FROM   Licenses INNER JOIN
                    Applications ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
                    People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                    LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID INNER JOIN
                    LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID AND LicenseClasses.LicenseClassID = LocalDrivingLicenseApplications.LicenseClassID
                    WHERE (People.NationalNo = @NationalNo) AND (LicenseClasses.ClassName = @ClassName)";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@ClassName", ClassName);

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

        public static bool GetIssueLicenseRequiredData(int LDLAppID,ref int PersonID, ref int ApplicationID,
            ref int LicenseClassID, ref decimal PaidFees,ref int DefaultValidityLength)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT PersonID, ApplicationID, LicenseClassID, PaidFees, DefaultValidityLength FROM IssueLicenseRequiredData_View
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    PaidFees = (decimal)reader["PaidFees"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
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

        public static DataTable GetDriverLicenseData(string ColumnName,int ColumnValue)
        {
            DataTable DriverLicenseData = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = $@"SELECT ClassName, FullName, LicenseID, NationalNo, Gendor, IssueDate,
                             IssueReason, Notes, IsActive, DateOfBirth,
                             DriverID, ExpirationDate, IsDetained, ImagePath
                             FROM DriverLicenseData_View
                             WHERE {ColumnName} = @ColumnValue";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ColumnValue", ColumnValue);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                    DriverLicenseData.Load(reader);

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return DriverLicenseData;
        }

        public static DataSet GetPersonLicensesHistory(int PersonID)
        {
            DataSet DriverLicensesData = new DataSet();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseID, ApplicationID, ClassName, IssueDate, ExpirationDate, IsActive
                             FROM PersonLicensesHistory_View
                             WHERE PersonID = @PersonID;
                             SELECT InterNationalLicenseID, ApplicationID, LocalLicenseID, IssueDate, ExpirationDate, IsActive
                             FROM PersonInterNationalLicensesHistory_View 
                             WHERE PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Command);
                adapter.Fill(DriverLicensesData);
            }
            catch
            {
            }
            finally
            {
                Connection.Close();
            }

            return DriverLicensesData;
        }

        public static bool IsLicenseClass3(int LicenseID)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1
                    FROM Licenses WHERE (Licenses.LicenseID = @LicenseID) AND (Licenses.LicenseClass = 3)";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
    }
}