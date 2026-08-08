using Business_Logic;
using DVLD.Licenses;
using DVLD.Licenses.internationalLicenses;
using DVLD.People;
using DVLD.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ApplicationForms
{
    public partial class frmManageInternationalLicenseApplications : Form
    {
        DataView _DataView = new DataView();

        public frmManageInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        void _RefreshApplications()
        {
            DataTable dt = clsInternationalLicenses.GetAllLicenses();
            _DataView = dt.DefaultView;
            dgvManageApplications.DataSource = _DataView;
            dgvManageApplications.Columns["PersonID"].Visible = false;
            lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
        }

        private void frmManageInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFiltersType.SelectedIndex = 0;
            tbFilterValue.Visible = false;
            cbIsActiveFilterValue.Visible = false;
            _RefreshApplications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFilterValue.Text))
            {
                _DataView.RowFilter = null;
                lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
                return;
            }

            int result = -1;
            if (int.TryParse(tbFilterValue.Text, out result))
                _DataView.RowFilter = $"{cbFiltersType.Text} = {result.ToString()}";
            else
                _DataView.RowFilter = null;

            lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
        }

        private void cbFiltersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "None")
            {
                _DataView.RowFilter = "";
                tbFilterValue.Visible = false;
                cbIsActiveFilterValue.Visible = false;
            }
            else if (cbFiltersType.Text == "IsActive")
            {
                tbFilterValue.Visible = false;
                cbIsActiveFilterValue.Visible = true;
            }
            else
            {
                cbIsActiveFilterValue.Visible = false;
                tbFilterValue.Visible = true;
            }

            tbFilterValue.Text = "";
        }

        private void cbStatusFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DataView.RowFilter = $"{cbFiltersType.Text} = {((cbIsActiveFilterValue.Text == "True") ? 1:0)}";
            lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void DataUpdated()
        {
            _RefreshApplications();
        }

        private void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvManageApplications.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterNationalLicenseInfo frm = new frmInterNationalLicenseInfo((int)dgvManageApplications.CurrentRow.Cells["InternationalLicenseID"].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)dgvManageApplications.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
        }
    }
}
