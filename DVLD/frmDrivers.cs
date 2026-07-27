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

namespace DVLD
{
    public partial class frmDrivers : Form
    {
        DataView _DataView = new DataView();

        public frmDrivers()
        {
            InitializeComponent();
        }

        void _RefreshDrivers()
        {
            DataTable dt = clsDrivers.GetAllDrivers();
            _DataView = dt.DefaultView;
            dgvManageDrivers.DataSource = _DataView;
            lblRecordsNumber.Text = dgvManageDrivers.RowCount.ToString();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            cbFiltersType.SelectedIndex = 0;
            tbFilterValue.Visible = false;
            numUpDownNumOfActiveLicenses.Visible = false;
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;
            _RefreshDrivers();
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFilterValue.Text))
            {
                _DataView.RowFilter = null;
                lblRecordsNumber.Text = dgvManageDrivers.RowCount.ToString();
                return;
            }

            if (cbFiltersType.Text == "DriverID" || cbFiltersType.Text == "PersonID")
            {
                int result = -1;
                if (int.TryParse(tbFilterValue.Text, out result))
                    _DataView.RowFilter = $"{cbFiltersType.Text} = {result.ToString()}";
                else
                    _DataView.RowFilter = null;
            }
            else if (cbFiltersType.Text == "FullName" || cbFiltersType.Text == "NationalNo")
            {
                string Filter = tbFilterValue.Text.Trim().Replace("'", "''");
                _DataView.RowFilter = $"{cbFiltersType.Text} LIKE '%{Filter}%'";
            }

            lblRecordsNumber.Text = dgvManageDrivers.RowCount.ToString();
        }

        private void cbFiltersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "None")
            {
                _DataView.RowFilter = "";
                tbFilterValue.Visible = false;
                numUpDownNumOfActiveLicenses.Visible = false;
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            else if (cbFiltersType.Text == "DriverID" || cbFiltersType.Text == "PersonID")
            {
                tbFilterValue.Visible = true;
                numUpDownNumOfActiveLicenses.Visible = false;
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            else if(cbFiltersType.Text == "FullName" || cbFiltersType.Text == "NationalNo")
            {
                tbFilterValue.Visible = true;
                numUpDownNumOfActiveLicenses.Visible = false;
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            else if(cbFiltersType.Text == "CreatedDate")
            {
                tbFilterValue.Visible = false;
                numUpDownNumOfActiveLicenses.Visible = false;
                dtpStartDate.Visible = true;
                dtpEndDate.Visible = true;
            }
            else if(cbFiltersType.Text == "NumberOfActiveLicenses")
            {
                tbFilterValue.Visible = false;
                numUpDownNumOfActiveLicenses.Visible = true;
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }

            tbFilterValue.Text = "";
            numUpDownNumOfActiveLicenses.Value = 0;
            dtpStartDate.Value = dtpEndDate.Value = DateTime.Now;
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltersType.Text == "DriverID" || cbFiltersType.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void numUpDownNumOfActiveLicenses_ValueChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "NumberOfActiveLicenses")
            {
                _DataView.RowFilter = $"{cbFiltersType.Text} = {numUpDownNumOfActiveLicenses.Value.ToString()}";
                lblRecordsNumber.Text = dgvManageDrivers.RowCount.ToString();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "CreatedDate")
            {
                _DataView.RowFilter = $"{cbFiltersType.Text} >= '{dtpStartDate.Value.ToString()}' AND {cbFiltersType.Text} <= '{dtpEndDate.Value.ToString()}'";
                lblRecordsNumber.Text = dgvManageDrivers.RowCount.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
