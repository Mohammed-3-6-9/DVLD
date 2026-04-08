using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUsersData
    {
        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName,
            ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = reader["UserName"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];
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
        public static int AddNewUser(int PersonID, string UserName,
             string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Users (PersonID,
               UserName, Password, IsActive) VALUES
               (@PersonID, @UserName, @Password, @IsActive)
                 SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", (IsActive) ? 1 : 0);

            try
            {
                Connection.Open();
                object objID = Command.ExecuteScalar();

                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                    UserID = ID;
            }
            catch
            {
                UserID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName,
             string Password, bool IsActive)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Users SET
               PersonID = @PersonID, UserName = @UserName, Password = @Password,
               IsActive = @IsActive WHERE UserID = @UserID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", (IsActive) ? 1 : 0);

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

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM Users_View;";
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

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Delete FROM Users Where UserID = @UserID;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM Users Where UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserNameExist(string UserName)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM Users Where UserName = @UserName";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

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
