using Business_Logic;
using DVLD.ApplicationForms;
using DVLD.Licenses;
using DVLD.Licenses.internationalLicenses;
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

namespace DVLD.Detain_Release
{
    public partial class frmManageDetainedLicenses : Form
    {
        DataView _DataView = new DataView();

        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        void _RefreshDetainedLicenses()
        {
            DataTable dt = clsDetainReleaseLicense.GetAllDetainedLicensesTableView();
            _DataView = dt.DefaultView;
            dgvManageDetainedLicenses.DataSource = _DataView;
            lblRecordsNumber.Text = dgvManageDetainedLicenses.RowCount.ToString();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            cbFiltersType.SelectedIndex = 0;
            tbFilterValue.Visible = false;
            cbIsReleasedFilterValue.Visible = false;
            _RefreshDetainedLicenses();
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
                lblRecordsNumber.Text = dgvManageDetainedLicenses.RowCount.ToString();
                return;
            }

            if (cbFiltersType.Text == "DetainID" || cbFiltersType.Text == "ReleaseApplicationID")
            {
                int result = -1;
                if (int.TryParse(tbFilterValue.Text, out result))
                    _DataView.RowFilter = $"[{cbFiltersType.Text}] = {result.ToString()}";
                else
                    _DataView.RowFilter = null;
            }
            else
            {
                string Filter = tbFilterValue.Text.Trim().Replace("'", "''");
                _DataView.RowFilter = $"{cbFiltersType.Text} LIKE '%{Filter}%'";
            }

            lblRecordsNumber.Text = dgvManageDetainedLicenses.RowCount.ToString();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedFilter = cbFiltersType.Text.Trim();
            if (selectedFilter == "DetainID" || selectedFilter == "ReleaseApplicationID" || selectedFilter == "LicenseID" || selectedFilter == "Release ApplicationID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbFiltersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "None")
            {
                _DataView.RowFilter = "";
                tbFilterValue.Visible = false;
                cbIsReleasedFilterValue.Visible = false;
            }
            else if (cbFiltersType.Text == "IsReleased")
            {
                tbFilterValue.Visible = false;
                cbIsReleasedFilterValue.Visible = true;
            }
            else
            {
                cbIsReleasedFilterValue.Visible = false;
                tbFilterValue.Visible = true;
            }

            tbFilterValue.Text = "";
        }

        private void cbIsReleasedFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsReleasedFilterValue.Text == "All")
                _DataView.RowFilter = null;
            else
                _DataView.RowFilter = $"{cbFiltersType.Text} = {((cbIsReleasedFilterValue.Text == "Yes") ? 1 : 0)}";

            lblRecordsNumber.Text = dgvManageDetainedLicenses.RowCount.ToString();
        }

        void DataUpdated()
        {
            _RefreshDetainedLicenses();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense();
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(dgvManageDetainedLicenses.CurrentRow.Cells["NationalNo"].Value.ToString());
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = frmLicenseInfo.CreateByLicenseID((int)dgvManageDetainedLicenses.CurrentRow.Cells["LicenseID"].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(dgvManageDetainedLicenses.CurrentRow.Cells["NationalNo"].Value.ToString());
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense frm = new frmReleaseLicense((int)dgvManageDetainedLicenses.CurrentRow.Cells["LicenseID"].Value);
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void dgvManageDetainedLicenses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvManageDetainedLicenses.CurrentCell = dgvManageDetainedLicenses.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
                dgvManageDetainedLicenses.ClearSelection();
                dgvManageDetainedLicenses.Rows[e.RowIndex].Selected = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvManageDetainedLicenses.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            bool isReleased = Convert.ToBoolean(dgvManageDetainedLicenses.CurrentRow.Cells["IsReleased"].Value);
            releaseDetainedLicenseToolStripMenuItem.Enabled = !isReleased;
        }
    }
}