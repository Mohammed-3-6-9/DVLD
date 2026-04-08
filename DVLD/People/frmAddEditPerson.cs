using Business_Logic;
using DVLD.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmAddEditPerson : Form
    {
        enum enMode { AddNew=0,Update=1}
        private enMode _Mode;
        private int _PersonID {  get; set; }
        private clsPerson _Person;

        public delegate void SendIDBack(object ThisForm, int PersonID);
        public event SendIDBack SendIDBackEvent;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.Update;
        }

        public frmAddEditPerson()
        {
            InitializeComponent();

            _PersonID = -1;
            _Mode = enMode.AddNew;
        }

        void _FillFieldsByPersonData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();
                return;
            }

            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNumber;
            tbEmail.Text = _Person.Email;
            tbAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            tbPhone.Text = _Person.Phone;
            rbMale.Checked = (_Person.Gendor == 0);
            rbFemale.Checked = !rbMale.Checked;
            cbCountry.SelectedValue = _Person.NationalCountryID;

            if (string.IsNullOrEmpty(_Person.ImagePath))
                pbPersonImage.Image = (_Person.Gendor == 0) ? Properties.Resources.Male_512 : Properties.Resources.Female_512;
            else
                pbPersonImage.Load(_Person.ImagePath);
        }

        void _PrepareCountiesList()
        {
            cbCountry.DataSource = clsCountry.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _PrepareCountiesList();

            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            
            if (_Mode == enMode.Update)
            {
                _FillFieldsByPersonData();
                lblHeader.Text = "Update Person";
                lblPersonID.Text = _PersonID.ToString();
            }
            else
            {
                _Person = new clsPerson();
                lblHeader.Text = "Add New Person";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _FillPersonWithData()
        {
            _Person.FirstName = tbFirstName.Text;
            _Person.SecondName = tbSecondName.Text;
            _Person.ThirdName = tbThirdName.Text;
            _Person.LastName = tbLastName.Text;
            _Person.NationalNumber = tbNationalNo.Text;
            _Person.Email = tbEmail.Text;
            _Person.Address = tbAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Phone = tbPhone.Text;
            _Person.Gendor = (byte)((rbMale.Checked) ? 0 : 1);
            _Person.NationalCountryID = (int)cbCountry.SelectedValue;

            if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
            {
                _Person.ImagePath = pbPersonImage.ImageLocation;
                llRemoveImage.Visible = true;
            }
            else
                _Person.ImagePath = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            _FillPersonWithData();

            if (_Person.Save())
            {
                MessageBox.Show("Person Saved Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblHeader.Text = "Update Person";
                _PersonID = _Person.PersonID;
                lblPersonID.Text = _PersonID.ToString();
                SendIDBackEvent?.Invoke(this, _PersonID);
                DataUpdatedEvent?.Invoke();
            }
            else
                MessageBox.Show("Person Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.Load(openFileDialog1.FileName);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            llRemoveImage.Visible = false;
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                // txtFirstName.Focus();
                errorProvider1.SetError(((TextBox)sender), "Please Insert a Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNationalNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "Please Insert a Value");
            }
            else if (_Mode == enMode.AddNew && clsPerson.IsPersonExist(tbNationalNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "The National Number Is Already Used");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNo, "");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Please Insert a Value");
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Please Insert A Valid Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNo, "");
            }

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.Image == null)
                pbPersonImage.Image = (rbMale.Checked) ? Properties.Resources.Male_512 :
                    Properties.Resources.Female_512;
        }
    }
}
