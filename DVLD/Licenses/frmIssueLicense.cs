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
    public partial class frmIssueLicense : Form
    {
        private int _LDLAppID;
        public frmIssueLicense(int LDLAppID)
        {
            InitializeComponent();

            _LDLAppID= LDLAppID;
            ctrlApplicationDetails1.FindAppDetails(_LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
