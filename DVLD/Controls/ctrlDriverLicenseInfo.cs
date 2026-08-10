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
        private string _NationalNo = "";
        private int _LicenseID = -1;
        public DataRow _DriverLicenseData;
        public bool IsDetained { set
            {
                if (_DriverLicenseData != null)
                {
                    _DriverLicenseData.Table.Columns["IsDetained"].ReadOnly = false;
                    _DriverLicenseData["IsDetained"] = (value) ? 1 : 0;
                    lblIsDetained.Text = Convert.ToBoolean(_DriverLicenseData["IsDetained"]) ? "Yes" : "No";
                    _DriverLicenseData.Table.Columns["IsDetained"].ReadOnly = true;
                }
            }
        }
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

        private string PrepareLabelIssueReason(int IssueReason)
        {
            switch ((clsGeneral.enApplicationType)IssueReason)
            {
                case clsGeneral.enApplicationType.NewLocalDrivingLicenseService:
                    return "New";
                case clsGeneral.enApplicationType.RenewDrivingLicenseService:
                    return "ReNew";
                case clsGeneral.enApplicationType.ReplacementforaDamagedDrivingLicense:
                    return "Replacement For Damage License";
                case clsGeneral.enApplicationType.ReplacementforaLostDrivingLicense:
                    return "Replacement For Lost License";
            }
            return "";
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
            lblIssueReason.Text = PrepareLabelIssueReason(Convert.ToInt32(_DriverLicenseData["IssueReason"]));
            lblIssueDate.Text = Convert.ToDateTime(_DriverLicenseData["IssueDate"]).ToShortDateString();
            lblExpirationDate.Text = Convert.ToDateTime(_DriverLicenseData["ExpirationDate"]).ToShortDateString();
            lblDateOfBirth.Text = Convert.ToDateTime(_DriverLicenseData["DateOfBirth"]).ToShortDateString();
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

        public bool FindDriverLicenseDetailsByNationalNo(string NationalNo)
        {
            _NationalNo = NationalNo;
            _DriverLicenseData = clsLicenses.GetDriverLicenseDataByNationalNo(_NationalNo);
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
