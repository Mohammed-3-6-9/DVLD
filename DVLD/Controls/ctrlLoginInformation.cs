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

namespace DVLD.Controls
{
    public partial class ctrlLoginInformation : UserControl
    {
        private int _UserID = -1;

        public int UserID
        {
            get => _UserID;

            set
            {
                _UserID = value;
                _RefreshUserCard();
            }
        }

        public ctrlLoginInformation()
        {
            InitializeComponent();
        }

        public void ResetDefaultValues()
        {
            _UserID = -1;
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

        void _RefreshUserCard()
        {
            clsUser User = clsUser.Find(UserID);

            if (User == null)
            {
                ResetDefaultValues();
                return;
            }

            lblUserID.Text = User.UserID.ToString();
            lblUserName.Text = User.UserName;
            lblIsActive.Text = (User.IsActive) ? "Yes" : "No";
        }
    }
}
