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

namespace DVLD.Test_Types
{
    public partial class frmUpdateTestType : Form
    {
        private int _TestTypeID { get; set; }

        private clsTestType _TestType;

        public delegate void DataUpdated();
        public event DataUpdated DataUpdatedEvent;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void FillFieldsWithData()
        {
            _TestType = clsTestType.Find(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show($"Test [{_TestTypeID}] Not Found", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
                return;
            }

            lblID.Text = _TestType.TestTypeID.ToString();
            tbTitle.Text = _TestType.TestTypeTitle;
            tbDescription.Text = _TestType.TestTypeDescription;
            tbFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            FillFieldsWithData();
        }

        void _FillTestTypeWithData()
        {
            _TestType.TestTypeTitle = tbTitle.Text;
            _TestType.TestTypeDescription = tbDescription.Text;
            _TestType.TestTypeFees = Convert.ToDecimal(tbFees.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            _FillTestTypeWithData();

            if (_TestType.Save())
            {
                MessageBox.Show($"Test type [{_TestTypeID}] Saved Successfully", "Done",
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
            else if (!double.TryParse(tbFees.Text, out _))
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

        private void tbTitleAndDescription_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb, "Please Insert a Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb, "");
            }
        }
    }

}