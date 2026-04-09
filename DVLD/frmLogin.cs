using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar == true)
            {
                tbPassword.UseSystemPasswordChar = false;
                btnShowHide.Text = "🔒";
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                btnShowHide.Text = "👁";
            }
        }
    }
}
