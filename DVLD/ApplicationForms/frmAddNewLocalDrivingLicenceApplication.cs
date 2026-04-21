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
    public partial class frmAddNewLocalDrivingLicenceApplication : Form
    {
        private clsNewLocalDrivingLicenceApplication _NewLocalLicenceApplication;
        private int _PersonID = -1;
        public frmAddNewLocalDrivingLicenceApplication()
        {
            InitializeComponent();
            _NewLocalLicenceApplication = new clsNewLocalDrivingLicenceApplication();
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
            cbLicenceClass.DisplayMember = "ClassName";
            cbLicenceClass.ValueMember = "LicenseClassID";
            cbLicenceClass.DataSource = clsLicenceClass.GetAllLicenceClassesIDAndName();
        }

        void InitializeApplication()
        {
            _NewLocalLicenceApplication.ApplicationDate = DateTime.Now;
            _NewLocalLicenceApplication.ApplicationStatus = 1;
            _NewLocalLicenceApplication.LastStatusDate = DateTime.Now;
            _NewLocalLicenceApplication.CreatedByUserID = clsSessionInfo.CurrentUser.UserID;
        }

        void _PrepareProperties()
        {
            _PrepareLicenceClassList();
            InitializeApplication();
            cbLicenceClass.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            //lblApplicationFees.Text = _NewLocalLicenceApplication.PaidFees.ToString("C");
            lblCreatedUser.Text = _NewLocalLicenceApplication.CreatedByUserID.ToString();
            lblApplicationDate.Text = _NewLocalLicenceApplication.ApplicationDate.ToString();
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
            _NewLocalLicenceApplication.ApplicantPersonID = _PersonID;
            _NewLocalLicenceApplication.LicenseClassID = (int)cbLicenceClass.SelectedValue;
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

            if(clsNewLocalDrivingLicenceApplication.IsPersonHasRunningNewApplication(_PersonID, (int)cbLicenceClass.SelectedValue))
            {
                MessageBox.Show("Sorry The Selected Person Has a Running Application With The Same Class", "Ops",
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

            if (_NewLocalLicenceApplication.Save())
            {
                MessageBox.Show("Application Saved Successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApplicationID.Text = _NewLocalLicenceApplication.ApplicationID.ToString();
            }
            else
                MessageBox.Show("Application Didn't Saved", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbLicenceClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _NewLocalLicenceApplication.PaidFees = clsLicenceClass.GetLicenceClassFees((int)cbLicenceClass.SelectedValue);
            lblApplicationFees.Text = _NewLocalLicenceApplication.PaidFees.ToString("C");
        }
    }
}