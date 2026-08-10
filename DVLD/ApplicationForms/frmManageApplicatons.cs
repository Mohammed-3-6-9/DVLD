using Business_Logic;
using DVLD.Licenses;
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
    public partial class frmManageApplicatons : Form
    {
        DataView _DataView=new DataView();
        public frmManageApplicatons()
        {
            InitializeComponent();
        }

        void _RefreshApplications()
        {
            DataTable dt = clsApplication.GetAllApplicationsFullData();
            dt.Columns["LocalDrivingLicenseApplicationID"].ColumnName = "L.D.L.AppID";
            _DataView = dt.DefaultView;
            dgvManageApplications.DataSource = _DataView;
            lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
        }

        private void frmManageApplicatons_Load(object sender, EventArgs e)
        {
            cbFiltersType.SelectedIndex = 0;
            tbFilterValue.Visible = false;
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

            if (cbFiltersType.Text == "L.D.L.AppID")
            {
                int result = -1;
                if (int.TryParse(tbFilterValue.Text, out result))
                    _DataView.RowFilter = $"{cbFiltersType.Text} = {result.ToString()}";
                else
                    _DataView.RowFilter = null;
            }
            else
            {
                string Filter = tbFilterValue.Text.Trim().Replace("'", "''");
                _DataView.RowFilter = $"{cbFiltersType.Text} LIKE '%{Filter}%'";
            }

            lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
        }

        private void cbFiltersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "None")
            {
                _DataView.RowFilter = "";
                tbFilterValue.Visible = false;
                cbStatusFilterValue.Visible = false;
            }
            else if(cbFiltersType.Text == "Status")
            {
                tbFilterValue.Visible = false;
                cbStatusFilterValue.Visible = true;
            }
            else
            {
                cbStatusFilterValue.Visible = false;
                tbFilterValue.Visible = true;
            }

            tbFilterValue.Text = "";
        }

        private void cbStatusFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DataView.RowFilter = $"{cbFiltersType.Text} LIKE '%{cbStatusFilterValue.Text}%'";
            lblRecordsNumber.Text = dgvManageApplications.RowCount.ToString();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltersType.Text == "L.D.L.AppID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        void DataUpdated()
        {
            _RefreshApplications();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {  
            frmAddNewLocalDrivingLicenceApplication frm = new frmAddNewLocalDrivingLicenceApplication();
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationDetails frm = new frmApplicationDetails((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value);
            frm.ShowDialog();
        }

        void _ScheduleTestUI()
        {
            switch ((int)dgvManageApplications.CurrentRow.Cells["PassedTestCount"].Value)
            {
                case 0:
                    {
                        visionTestToolStripMenuItem.Enabled = true;
                        writtenTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        visionTestToolStripMenuItem.Enabled = false;
                        writtenTestToolStripMenuItem.Enabled = true;
                        streetTestToolStripMenuItem.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        visionTestToolStripMenuItem.Enabled = false;
                        writtenTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        visionTestToolStripMenuItem.Enabled = false;
                        writtenTestToolStripMenuItem.Enabled = false;
                        streetTestToolStripMenuItem.Enabled = false;
                        break;
                    }
            }
        }

        private void scheduleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestUI();
        }

        private void scheduleTestsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            _ScheduleTestUI();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainScheduleTest frm = new frmMainScheduleTest((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value,
                    TestType: clsGeneral.enTestTypes.Vision);
            frm.ApplicationsDataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainScheduleTest frm = new frmMainScheduleTest((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value,
                    TestType: clsGeneral.enTestTypes.Written);
            frm.ApplicationsDataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainScheduleTest frm = new frmMainScheduleTest((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value,
                    TestType: clsGeneral.enTestTypes.Practical);
            frm.ApplicationsDataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void ctxMain_Opened(object sender, EventArgs e)
        {
            if ((int)dgvManageApplications.CurrentRow.Cells["PassedTestCount"].Value < 3)
            {
                showLicenseToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (clsLicenses.IsPersonHasThisLicense(dgvManageApplications.CurrentRow.Cells["NationalNo"].Value.ToString(),
                    dgvManageApplications.CurrentRow.Cells["ClassName"].Value.ToString()))
                {
                    showLicenseToolStripMenuItem.Enabled = true;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                }
                else
                {
                    showLicenseToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsApplication.UpdateApplicationStatus((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value,clsGeneral.enApplicationStatus.Canceled))
            {
                MessageBox.Show("Application Deleted Successfully", "Delet Application", MessageBoxButtons.OK);
                _RefreshApplications();
            }
            else
            {
                MessageBox.Show("Application Didn't Deleted Successfully", "Delet Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsNewLocalDrivingLicenceApplication.DeleteLocalDrivingLicenceApplication((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value))
            {
                MessageBox.Show("Application Deleted Successfully", "Delet Application", MessageBoxButtons.OK);
                _RefreshApplications();
            }
            else
            {
                MessageBox.Show("Application Didn't Deleted Successfully", "Delet Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueLicense frm = new frmIssueLicense((int)dgvManageApplications.CurrentRow.Cells["L.D.L.AppID"].Value);
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = frmLicenseInfo.CreateByNationalNo(dgvManageApplications.CurrentRow.Cells["NationalNo"].Value.ToString());
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(dgvManageApplications.CurrentRow.Cells["NationalNo"].Value.ToString());
            frm.ShowDialog();
        }

        private void dgvManageApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvManageApplications.CurrentCell = dgvManageApplications.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];
                dgvManageApplications.ClearSelection();
                dgvManageApplications.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
