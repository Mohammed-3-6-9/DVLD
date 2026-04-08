using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string FullName { get; set; }

        private string _UserName;
        public string UserName
        {
            get => _UserName;
            set
            {
                _PrevUserName = _UserName;
                _UserName = value;
            }
        }
        private string _PrevUserName { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }

        public clsUser()
        {
            PersonID = -1;
            UserID = -1;
            FullName = "";
            IsActive = false;
            _UserName = "";
            Password = "";
            _Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string UserName,
            string Password, bool IsActive)
        {

            this.PersonID =PersonID;
            this.UserID = UserID;
            this.Password = Password;
            this.IsActive = IsActive;
            this.UserName = UserName;
            _Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.UserID = clsUsersData.AddNewUser(PersonID,UserName,Password,IsActive);

            return (this.UserID != -1);
        }

        private bool _Update()
        {
            return clsUsersData.UpdateUser(this.UserID, this.PersonID, this.UserName,
                this.Password, this.IsActive);
        }

        public static clsUser Find(int ID)
        {
            int PersonID = -1;
            string Password = "", UserName = "";
            bool IsActive = false;

            if (clsUsersData.GetUserInfoByID(ID, ref PersonID, ref UserName , ref Password,
                ref IsActive))
            {
                return new clsUser(ID, PersonID, UserName , Password, IsActive);
            }
            else
                return null;
        }

        private bool _ValidateProberties()
        {
            if (string.IsNullOrWhiteSpace(this.Password) ||
               string.IsNullOrWhiteSpace(this.UserName))
            {
                return false;
            }

            if (this._Mode == enMode.AddNew)
            {
                if (IsUserNameExist(this.UserName))
                {
                    return false;
                }
            }
            else
            {
                if (_UserName != _PrevUserName)
                {
                    if (clsUser.IsUserNameExist(_UserName))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Save()
        {
            if (!_ValidateProberties())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNew())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUsersData.IsUserExist(UserID);
        }

        public static bool ChangePassword(int UserID,string OldPassword,string NewPassword)
        {
            clsUser user = clsUser.Find(UserID);

            if (user == null)
                return false;

            if(user.Password == OldPassword)
            {
                user.Password = NewPassword;
                return user._Update();
            }

            return false;
        }

        public static bool IsUserNameExist(string UserName)
        {
            if (clsUsersData.IsUserNameExist(UserName))
            {
                return true;
            }

            return false;
        }
    }
}
