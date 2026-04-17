using Business_Logic;
using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.ApplicationForms
{
    public partial class frmAddApplication : Form
    {
        private clsApplication _Application;
        private int _PersonID = -1;
        public frmAddApplication()
        {
            InitializeComponent();
            _Application = new clsApplication();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _PrepareLicenceClassList()
        {
            cbLicenceClass.DisplayMember = "ApplicationTypeTitle";
            cbLicenceClass.ValueMember = "ApplicationTypeID";
            cbLicenceClass.DataSource = clsApplicationType.GetApplicationIDAndTitle();
        }

        void InitializeApplication()
        {
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = DateTime.Now;
            _Application.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
        }

        void _PrepareProperties()
        {
            _PrepareLicenceClassList();
            InitializeApplication();
            cbLicenceClass.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            lblApplicationFees.Text = _Application.PaidFees.ToString("C");
            lblCreatedUser.Text = _Application.CreatedByUserID.ToString();
            lblApplicationDate.Text = _Application.ApplicationDate.ToString();
        }

        private void frmAddApplication_Load(object sender, EventArgs e)
        {
            _PrepareProperties();
        }

        void IDSentBack(object sender, int PersonID)
        {
            _PersonID = PersonID;
            ctrlPersonCard1.FillCardWithData(_PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.SendIDBackEvent += IDSentBack;
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFilterValue.Text))
            {
                return;
            }

            if (cbFilter.SelectedItem.ToString() == "PersonID")
            {
                _PersonID = int.Parse(tbFilterValue.Text.Trim());

                _PersonID = ctrlPersonCard1.FillCardWithData(_PersonID);

                if (_PersonID == -1)
                {
                    MessageBox.Show("Person is Not Found", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                _PersonID = ctrlPersonCard1.FillCardWithData(tbFilterValue.Text.Trim());

                if (_PersonID == -1)
                {
                    MessageBox.Show("Person is Not Found", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Text = "";
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    errorProvider1.SetError(((TextBox)sender), "Please Insert a Number");
                    e.Handled = true;
                }
            }
        }

        void _FillApplicationWithData()
        {
            _Application.ApplicantPersonID = _PersonID;
            _Application.ApplicationTypeID = (int)cbLicenceClass.SelectedValue;
        }

        private bool _Validation()
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Please Set a Person", "Missed Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl1.SelectedIndex = 0;
                return false;
            }

            if(clsApplication.IsPersonHasRunningNewApplication(_PersonID,_Application.ApplicationTypeID))
            {
                MessageBox.Show("Sorry The Selected Person Has a Running New Licence Application", "Ops",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_Validation())
                return;

            _FillApplicationWithData();

            if (_Application.Save())
            {
                MessageBox.Show("Application Saved Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationID.Text = _Application.ApplicationID.ToString();
            }
            else
                MessageBox.Show("Application Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbLicenceClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Application.PaidFees = clsApplicationType.GetApplicationFees((int)cbLicenceClass.SelectedValue);
            lblApplicationFees.Text = _Application.PaidFees.ToString("C");
        }
    }
}