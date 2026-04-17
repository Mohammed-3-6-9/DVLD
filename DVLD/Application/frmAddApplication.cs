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

namespace DVLD.Application
{
    public partial class frmAddApplication : Form
    {
        private clsApplication _Application;
        private int _PersonID;
        public frmAddApplication()
        {
            InitializeComponent();
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddApplication_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _Application = new clsApplication();
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

        // mmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        void _FillApplicationWithData()
        {

        }

        // there is missed validations
        private bool _Validation()
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Please Set a Person", "Missed Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl1.SelectedIndex = 0;
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

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
        
    }
}
