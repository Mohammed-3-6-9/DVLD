using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class ctrlAddEditPerson : UserControl
    {
        public int PersonID { get; set; }

        public ctrlAddEditPerson()
        {
            InitializeComponent();
        }

        void _RefreshPersonCard()
        {
            clsPerson Person = clsPerson.Find(1);

            if (Person == null)
                return;

            tbFirstName.Text = Person.FirstName;
            tbSecondName.Text = Person.SecondName;
            tbThirdName.Text = Person.ThirdName;
            tbLastName.Text = Person.LastName;
            tbNationalNo.Text = Person.NationalNumber;
            tbEmail.Text = Person.Email;
            tbAddress.Text = Person.Address;
            dtpDateOfBirth.Value = Person.DateOfBirth;
            tbPhone.Text = Person.Phone;
            rbMale.Checked = (Person.Gendor == 0);
            rbFemale.Checked = !rbMale.Checked;
            cbCountry.SelectedValue = Person.NationalCountryID;

            if (!string.IsNullOrEmpty(Person.ImagePath))
                pbPersonImage.Load(Person.ImagePath);
        }

        void _PrepareCountiesList()
        {
            cbCountry.DataSource = clsCountry.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
        }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {
            _PrepareCountiesList();
            _RefreshPersonCard();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
