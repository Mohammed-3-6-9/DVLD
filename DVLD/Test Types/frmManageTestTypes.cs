using Business_Logic;
using DVLD.ApplicationTypes;
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
    public partial class frmManageTestTypes : Form
    {
        private DataView _DataView;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshTestTypes()
        {
            DataTable dt = clsTestType.GetAllTestTypes();

            _DataView = dt.DefaultView;
            dgvTestTypes.DataSource = _DataView;
            lblRecordsNumber.Text = dgvTestTypes.RowCount.ToString();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DataUpdated()
        {
            _RefreshTestTypes();
        }

        private void editTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType frm = new frmUpdateTestType((int)dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value);
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }
    }

}