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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Controls
{
    public partial class ctrlInternationalDriverInfo : UserControl
    {
        private int _InterNationalLicenseID = -1;
        public DataRow _InterNationalDriverData;

        public ctrlInternationalDriverInfo()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblName.Text = "[???]";
            lblIntLicenseID.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblGendor.Text = "[???]";
            lblIssueDate.Text = "[???]";
            lblApplicationID.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblDriverID.Text = "[???]";
            lblExpirationDate.Text = "[???]";
            pbPersonImage.InitialImage = null;
        }

        private bool _RefreshDetails()
        {
            if (_InterNationalDriverData == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("Not Found");
                return false;
            }

            byte Gendor = Convert.ToByte(_InterNationalDriverData["Gendor"]);
            string ImagePath = _InterNationalDriverData["ImagePath"].ToString();

            lblName.Text = _InterNationalDriverData["FullName"].ToString();
            lblIntLicenseID.Text = _InterNationalDriverData["InternationalLicenseID"].ToString();
            lblLicenseID.Text = _InterNationalDriverData["LocalLicenseID"].ToString();
            lblNationalNo.Text = _InterNationalDriverData["NationalNo"].ToString();
            lblGendor.Text = (Gendor == 0) ? "Male" : "Female";
            lblIssueDate.Text = Convert.ToDateTime(_InterNationalDriverData["IssueDate"]).ToShortDateString();
            lblExpirationDate.Text = Convert.ToDateTime(_InterNationalDriverData["ExpirationDate"]).ToShortDateString();
            lblDateOfBirth.Text = Convert.ToDateTime(_InterNationalDriverData["DateOfBirth"]).ToShortDateString();
            lblApplicationID.Text = _InterNationalDriverData["ApplicationID"].ToString();
            lblIsActive.Text = Convert.ToBoolean(_InterNationalDriverData["IsActive"]) ? "Yes" : "No";
            lblDriverID.Text = _InterNationalDriverData["DriverID"].ToString();

            if (string.IsNullOrEmpty(ImagePath))
                pbPersonImage.Image = (Gendor == 0) ? Properties.Resources.Male_512 : Properties.Resources.Female_512;
            else
                pbPersonImage.Load(ImagePath);

            return true;
        }

        public bool FindDriverLicenseDetailsByLicenseID(int InterNationalLicenseID)
        {
            _InterNationalLicenseID = InterNationalLicenseID;
            _InterNationalDriverData = clsInternationalLicenses.GetInterNationalDriverInfo(_InterNationalLicenseID);
            return _RefreshDetails();
        }
    }
}
