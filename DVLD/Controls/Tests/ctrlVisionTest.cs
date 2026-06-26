using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls.Tests
{
    public partial class ctrlVisionTest : UserControl
    {
        private int _LDLAppID = -1;

        public ctrlVisionTest(int localDrivingLicenseApplicationID)
        {
            _LDLAppID = localDrivingLicenseApplicationID;

            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblD_L_AppID.Text = "[???]";
            lblD_Class.Text = "[???]";
            lblName.Text = "[???]";
            lblTrial.Text = "[???]";
            lblFees.Text = "[???]";
        }

        private void ctrlVisionTest_Load(object sender, EventArgs e)
        {

        }
    }
}
