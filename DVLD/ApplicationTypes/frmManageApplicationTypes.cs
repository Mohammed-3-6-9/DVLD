using Business_Logic;
using DVLD.ApplicationTypes;
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

namespace DVLD
{
    public partial class frmManageApplicationTypes : Form
    {
        private DataView _DataView;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshApplicationTypes()
        {
            DataTable dt = clsApplicationsTypes.GetAllApplicationTypes();

            _DataView = dt.DefaultView;
            dgvApplicationType.DataSource = _DataView;
            lblRecordsNumber.Text = dgvApplicationType.RowCount.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DataUpdated()
        {
            _RefreshApplicationTypes();
        }

        private void editApplicationFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationTypes frm = new frmUpdateApplicationTypes((int)dgvApplicationType.CurrentRow.Cells["ApplicationTypeID"].Value);
            frm.DataUpdatedEvent += DataUpdated;
            frm.ShowDialog();
        }
    }
}
