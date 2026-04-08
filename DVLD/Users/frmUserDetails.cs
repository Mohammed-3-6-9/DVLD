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

namespace DVLD.Users
{
    public partial class frmUserDetails : Form
    {
        private int _UserID = -1;
        public frmUserDetails(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(_UserID);

            if (User == null)
            {
                MessageBox.Show($"Couldn't Find User [ {_UserID} ]");
                this.Close();
                return;
            }

            ctrlPersonCard1.PersonID = User.PersonID;
            ctrlLoginInformation1.UserID = User.UserID;
        }
    }
}
