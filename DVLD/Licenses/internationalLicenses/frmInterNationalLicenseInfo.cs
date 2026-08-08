using DVLD.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.internationalLicenses
{
    public partial class frmInterNationalLicenseInfo : Form
    {
        private int _InternationalLicenseID = -1;

        public frmInterNationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void frmInterNationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalDriverInfo1.FindDriverLicenseDetailsByLicenseID(_InternationalLicenseID);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
