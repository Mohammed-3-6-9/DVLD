using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID,ref string NationalNumber,ref string FirstName,
            ref string SecondName,ref string ThirdName,
            ref string LastName,ref DateTime DateOfBirth,ref byte Gendor, ref string Address
            , ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID",PersonID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    NationalNumber = reader["NationalNo"].ToString();
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    NationalCountryID = (int)reader["NationalCountryID"];
                    ImagePath = reader["ImagePath"].ToString();
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

        public static bool GetPersonInfoByNationalNumber(string NationalNo, ref int PersonID,
            ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address
            , ref string Phone, ref string Email, ref int NationalCountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    NationalCountryID = (int)reader["NationalCountryID"];
                    ImagePath = reader["ImagePath"].ToString();
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

        public static int AddNewPerson(string NationalNumber,
              string FirstName, string SecondName, string ThirdName,
              string LastName, DateTime DateOfBirth, byte Gendor, string Address
            , string Phone, string Email, int NationalCountryID, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO People (NationalNo,
               FirstName, SecondName, ThirdName,
               LastName, DateOfBirth, Gendor, Address
                ,Phone, Email, NationalCountryID, ImagePath) VALUES
               (@NationalNo, @FirstName, @SecondName, @ThirdName,
               @LastName, @DateOfBirth, @Gendor, @Address
                ,@Phone, @Email, @NationalCountryID, @ImagePath)
                  SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNumber);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);

            if(string.IsNullOrWhiteSpace(ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);

            if (string.IsNullOrWhiteSpace(Email))
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Email", Email);

            if (string.IsNullOrWhiteSpace(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Connection.Open();
                object objID = Command.ExecuteScalar();

                if (objID != null && int.TryParse(objID.ToString(), out int ID))
                    PersonID = ID;
            }
            catch
            {
                PersonID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNumber,
        string FirstName, string SecondName, string ThirdName,
        string LastName, DateTime DateOfBirth, byte Gendor, string Address,
        string Phone, string Email, int NationalCountryID, string ImagePath)
        {
            int RowsEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE People SET
               NationalNo = @NationalNumber, FirstName = @FirstName, SecondName = @SecondName,
               ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = @DateOfBirth,
               Gendor = @Gendor, Address = @Address,Phone = @Phone, Email = @Email,
               NationalCountryID = @NationalCountryID, ImagePath = @ImagePath
                 WHERE PersonID = @PersonID;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@NationalCountryID", NationalCountryID);

            if (string.IsNullOrWhiteSpace(ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);

            if (string.IsNullOrWhiteSpace(Email))
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Email", Email);

            if (string.IsNullOrWhiteSpace(ImagePath))
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //string query = @"SELECT * FROM People;";
            string query = @"SELECT PersonID, NationalNo, FirstName, SecondName
                            , ThirdName, LastName, DateOfBirth, Gendor, Address
                            , Phone, Email, NationalCountryID FROM People";
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

        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Delete FROM People Where PersonID = @PersonID;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM People Where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(string NationalNumber)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM People Where NationalNumber = @NationalNumber";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

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

        public static bool IsPersonHasUser(int PersonID)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM Users Where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonHasUser(string NationalNumber)
        {
            bool Exists = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT 1 FROM Users Inner Join People ON People.NationalNo = @NationalNumber";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNumber);

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