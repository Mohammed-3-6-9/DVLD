using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DataAccessLayer;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Business_Logic
{
    public class clsPerson
    {
        public enum enMode { AddNew =0, Update = 1 }
        enMode _Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalCountryID { get; set; }
        public string ImagePath { get; set; }
        private string _OldImagePath { get; set; }

        private string _DestinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PeopleImages");

        public clsPerson()
        {
            PersonID = -1;
            NationalNumber = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalCountryID = 0;
            ImagePath = "";
            _Mode=enMode.AddNew;
        }

        private clsPerson(int ID, string NationalNumber, string FirstName,
            string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, byte Gendor, string Address,
            string Phone, string Email, int NationalCountryID, string ImagePath)
        {
            this.PersonID = ID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalCountryID = NationalCountryID;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;

            _OldImagePath = ImagePath;
        }

        private bool _AddNew()
        {
            this.PersonID = clsPersonData.AddNewPerson(NationalNumber, FirstName, SecondName, ThirdName,
                LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalCountryID, ImagePath);

            return (this.PersonID != -1);
        }

        private bool _Update()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.NationalNumber, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor,
                this.Address, this.Phone, this.Email, this.NationalCountryID, this.ImagePath);
        }

        public static clsPerson Find(int ID)
        {
            int NationalCountryID = -1;
            string NationalNumber = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "",
            Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if (clsPersonData.GetPersonInfoByID(ID, ref NationalNumber, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address,
                ref Phone, ref Email, ref NationalCountryID, ref ImagePath))
            {
                return new clsPerson(ID, NationalNumber, FirstName, SecondName,
                    ThirdName, LastName, DateOfBirth, Gendor,
                    Address, Phone, Email, NationalCountryID, ImagePath);
            }
            else
                return null;
        }

        public static clsPerson Find(string NationalNumber)
        {
            int PersonID = -1, NationalCountryID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
            Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if (clsPersonData.GetPersonInfoByNationalNumber(NationalNumber, ref PersonID,
                ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address,
                ref Phone, ref Email, ref NationalCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName,
                    ThirdName, LastName, DateOfBirth, Gendor,
                    Address, Phone, Email, NationalCountryID, ImagePath);
            }
            else
                return null;
        }

        private bool IsValidEmail()
        {
            if(string.IsNullOrWhiteSpace(this.Email))
                return false;

            return Regex.IsMatch(this.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool _IsValidNationalNo()
        {
            if (string.IsNullOrWhiteSpace(this.NationalNumber))
            {
                return false;
            }
            else if ((_Mode == enMode.AddNew) && IsPersonExist(this.NationalNumber))
            {
                return false;
            }

            return true;
        }

        bool _UpdatePersonImage()
        {
            if (string.IsNullOrWhiteSpace(this.ImagePath))
            {
                if (!string.IsNullOrWhiteSpace(this._OldImagePath))
                    System.IO.File.Delete(this._OldImagePath);

                this.ImagePath = "";
                return true;
            }

            if (this._OldImagePath != this.ImagePath)
            {
                string SourceFile = this.ImagePath;

                if(!System.IO.Directory.Exists(this._DestinationFolder))
                    System.IO.Directory.CreateDirectory(this._DestinationFolder);

                string NewFileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(SourceFile);
                string DestinationFile = System.IO.Path.Combine(_DestinationFolder, NewFileName);

                try
                {
                    System.IO.File.Copy(SourceFile, DestinationFile, true);

                    if (!string.IsNullOrWhiteSpace(this._OldImagePath))
                        System.IO.File.Delete(this._OldImagePath);

                    this.ImagePath = DestinationFile;
                    this._OldImagePath = ImagePath;
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        private bool _ValidateProberties()
        {
            if (string.IsNullOrWhiteSpace(this.FirstName) ||
               string.IsNullOrWhiteSpace(this.SecondName) ||
               string.IsNullOrWhiteSpace(this.LastName) ||
               string.IsNullOrWhiteSpace(this.Address) ||
               string.IsNullOrWhiteSpace(this.Phone))
            {
                return false;
            }

            if (!_IsValidNationalNo())
                return false;

            if(this.Gendor < 0 || this.Gendor > 1 ||
               this.NationalCountryID == 0)
            {
                return false;
            }

            DateTime CompareDate = DateTime.Now.AddYears(-18);
            if (this.DateOfBirth > CompareDate)
            {
                return false;
            }

            if (!IsValidEmail())
                return false;

            return true;
        }

        public bool Save()
        {
            if (!_ValidateProberties())
                return false;

            if (!_UpdatePersonImage())
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

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNumber)
        {
            return clsPersonData.IsPersonExist(NationalNumber);
        }

        public static bool IsPersonHasUser(int PersonID)
        {
            return clsPersonData.IsPersonHasUser(PersonID);
        }

        public static bool IsPersonHasUser(string NationalNumber)
        {
            return clsPersonData.IsPersonHasUser(NationalNumber);
        }
    }
}
