using Business_Logic;
using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person = new clsPerson();

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private bool _RefreshPersonCard(clsPerson Person)
        {
            _PersonID = Person.PersonID;
            lblPersonID.Text = _PersonID.ToString();
            lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + Person.LastName;
            lblNationalNo.Text = Person.NationalNumber;
            lblGendor.Text = (Person.Gendor == 0) ? "Male" : "Female";
            lblEmail.Text = Person.Email;
            lblAddress.Text = Person.Address;
            lblDateOfBirth.Text = Person.DateOfBirth.ToString();
            lblPhone.Text = Person.Phone;
            lblCountry.Text = clsCountry.Find(Person.NationalCountryID).CountryName;

            if (string.IsNullOrEmpty(Person.ImagePath))
                pbPersonImage.Image = (Person.Gendor == 0) ? Properties.Resources.Male_512 : Properties.Resources.Female_512;
            else
                pbPersonImage.Load(Person.ImagePath);

            return true;
        }

        public void ResetDefaultValues()
        {
            _PersonID = -1;
            lblPersonID.Text = "[???]";
            lblName.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblGendor.Text = "[???]";
            lblEmail.Text = "[???]";
            lblAddress.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblPhone.Text = "[???]";
            lblCountry.Text = "[???]";
            pbPersonImage.Image = Properties.Resources.Male_512;
        }

        private int _FindPerson(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                ResetDefaultValues();
                return -1;
            }

            _RefreshPersonCard(_Person);
            return _Person.PersonID;
        }

        private int _FindPerson(string NationalNumber)
        {
            _Person = clsPerson.Find(NationalNumber);

            if (_Person == null)
            {
                ResetDefaultValues();
                return -1;
            }

            _RefreshPersonCard(_Person);

            return _Person.PersonID;
        }

        private void lblEditPersonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

            _FindPerson(_PersonID);
        }

        public int FillCardWithData(int PersonID)
        {
            return _FindPerson(PersonID);
        }

        public int FillCardWithData(string NationalNumber)
        {
            return _FindPerson(NationalNumber);
        }
    }
}
