using Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationTypes
{
    public partial class frmUpdateApplicationTypes : Form
    {
        private int _ApplicationTypeID { get; set; }

        private clsApplicationsTypes _ApplicationType;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmUpdateApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeID;
        }

        private void FillFieldsWithData()
        {
            _ApplicationType = clsApplicationsTypes.Find(_ApplicationTypeID);

            if (_ApplicationType == null)
            {
                MessageBox.Show($"Application [{_ApplicationTypeID}] Not Found", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                this.Close();
                return;
            }

            lblID.Text = _ApplicationType.ApplicationTypeID.ToString();
            tbTitle.Text = _ApplicationType.ApplicationTypeTitle;
            tbFees.Text = _ApplicationType.ApplicationFees.ToString();
        }

        private void frmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            FillFieldsWithData();
        }

        void _FillApplicationWithData()
        {
            _ApplicationType.ApplicationTypeTitle = tbTitle.Text;
            _ApplicationType.ApplicationFees = Convert.ToDecimal(tbFees.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            _FillApplicationWithData();

            if (_ApplicationType.Save())
            {
                MessageBox.Show($"Application [{_ApplicationTypeID}] Saved Successfully", "Done",
                                MessageBoxButtons.OK);
                
                DataUpdatedEvent?.Invoke();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFees, "Please Insert a Value");
            }
            else if(!double.TryParse(tbFees.Text,out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFees, "Please Insert a Valid Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFees, "");
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTitle, "Please Insert a Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTitle, "");
            }
        }
    }
}
