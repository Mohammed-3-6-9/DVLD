using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Business_Logic.clsNewLocalDrivingLicenceApplication;

namespace DVLD.Controls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LDLAppID = -1;
        private int _LicenseID = -1;
        public DataRow _DriverLicenseData;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblClassName.Text = "[???]";
            lblName.Text = "[???]";
            lblLicenseID.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblGendor.Text = "[???]";
            lblIssueDate.Text = "[???]";
            lblIssueReason.Text = "[???]";
            lblNotes.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblDriverID.Text = "[???]";
            lblExpirationDate.Text = "[???]";
            lblIsDetained.Text = "[???]";
            pbPersonImage.InitialImage = null;
        }

        private bool _RefreshDetails()
        {
            if (_DriverLicenseData == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("Not Found");
                return false;
            }

            byte Gendor = Convert.ToByte(_DriverLicenseData["Gendor"]);
            string ImagePath = _DriverLicenseData["ImagePath"].ToString();

            lblClassName.Text = _DriverLicenseData["ClassName"].ToString();
            lblName.Text = _DriverLicenseData["FullName"].ToString();
            lblLicenseID.Text = _DriverLicenseData["LicenseID"].ToString();
            lblNationalNo.Text = _DriverLicenseData["NationalNo"].ToString();
            lblGendor.Text = (Gendor == 0) ? "Male" : "Female";
            lblIssueDate.Text = Convert.ToDateTime(_DriverLicenseData["IssueDate"]).ToShortDateString();
            lblExpirationDate.Text = Convert.ToDateTime(_DriverLicenseData["ExpirationDate"]).ToShortDateString();
            lblDateOfBirth.Text = Convert.ToDateTime(_DriverLicenseData["DateOfBirth"]).ToShortDateString();
            lblIssueReason.Text = _DriverLicenseData["IssueReason"].ToString();
            lblIsActive.Text = Convert.ToBoolean(_DriverLicenseData["IsActive"]) ? "Yes" : "No";
            lblIsDetained.Text = Convert.ToBoolean(_DriverLicenseData["IsDetained"]) ? "Yes" : "No";
            lblDriverID.Text = _DriverLicenseData["DriverID"].ToString();

            if (string.IsNullOrEmpty(ImagePath))
                pbPersonImage.Image = (Gendor == 0) ? Properties.Resources.Male_512 : Properties.Resources.Female_512;
            else
                pbPersonImage.Load(ImagePath);

            lblNotes.Text = (_DriverLicenseData["Notes"] == DBNull.Value ||
                string.IsNullOrWhiteSpace(_DriverLicenseData["Notes"].ToString()))? "No Notes"
                            : _DriverLicenseData["Notes"].ToString();

            return true;
        }

        public bool FindDriverLicenseDetailsByLDLAppID(int LDLAppID)
        {
            _LDLAppID = LDLAppID;
            _DriverLicenseData = clsLicenses.GetDriverLicenseDataByLDLAppID(_LDLAppID);
            return _RefreshDetails();
        }

        public bool FindDriverLicenseDetailsByLicenseID(int LicenseID)
        {
            _LicenseID = LicenseID;
            _DriverLicenseData = clsLicenses.GetDriverLicenseDataByLicenseID(_LicenseID);
            return _RefreshDetails();
        }
    }
}
