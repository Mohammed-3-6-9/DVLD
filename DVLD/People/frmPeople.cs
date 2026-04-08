using Business_Logic;
using DVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmPeople : Form
    {
        private DataView _DataView;
        public frmPeople()
        {
            InitializeComponent();
        }

        private void _RefreshPeople()
        {
            DataTable dt = clsPerson.GetAllPeople();
            dt.Columns.Add("GendorName", typeof(string), "IIF(Gendor = 0, 'Male', 'Female')");

            _DataView = dt.DefaultView;
            dgvPeople.DataSource = _DataView;
            dgvPeople.Columns["Gendor"].Visible = false;

            lblRecordsNumber.Text = dgvPeople.RowCount.ToString();
        }

        private void People_Load(object sender, EventArgs e)
        {
            cbFiltersType.SelectedIndex = 0;
            tbFilterValue.Visible = false;
            _RefreshPeople();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvPeople.CurrentRow.Cells["PersonID"].Value);
            frm.ShowDialog();
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFilterValue.Text))
            {
                _DataView.RowFilter = null;
                lblRecordsNumber.Text = dgvPeople.RowCount.ToString();
                return;
            }

            if (cbFiltersType.Text == "PersonID")
            {
                if (tbFilterValue.Text != "")
                    _DataView.RowFilter = $"{cbFiltersType.Text} = {int.Parse(tbFilterValue.Text)}";
                else
                    _DataView.RowFilter = null;
            }
            else
            {
                string Filter = tbFilterValue.Text.Trim().Replace("'", "''");
                _DataView.RowFilter = $"{cbFiltersType.Text} LIKE '%{Filter}%'";
            }

            lblRecordsNumber.Text = dgvPeople.RowCount.ToString();
        }

        private void cbFiltersType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltersType.Text == "None")
                tbFilterValue.Visible = false;
            else
                tbFilterValue.Visible = true;

            tbFilterValue.Text = "";
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltersType.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        void DataUpdated()
        {
            _RefreshPeople();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Person [ {dgvPeople.CurrentRow.Cells["PersonID"].Value} ]",
                "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson(int.Parse(dgvPeople.CurrentRow.Cells["PersonID"].Value.ToString())))
                {
                    MessageBox.Show("Person Deleted Successfully");
                    _RefreshPeople();
                }
                else
                    MessageBox.Show("Contact is not deleted.");
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells["PersonID"].Value);
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }

        void _MessageFeatureNotImplemented()
        {
            MessageBox.Show($"Sorry This Feature Not Implemented Yet");
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MessageFeatureNotImplemented();
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _MessageFeatureNotImplemented();
        }
    }
}
