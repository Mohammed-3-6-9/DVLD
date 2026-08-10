using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static frmLicenseInfo CreateByLicenseID(int LicenseID)
        {
            frmLicenseInfo frm = new frmLicenseInfo();
            frm.ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByLicenseID(LicenseID);
            return frm;
        }

        public static frmLicenseInfo CreateByNationalNo(string NationalNo)
        {
            frmLicenseInfo frm = new frmLicenseInfo();
            frm.ctrlDriverLicenseInfo1.FindDriverLicenseDetailsByNationalNo(NationalNo);
            return frm;
        }
    }
}
