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

namespace DVLD.Licenses
{
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;
        private string _NationalNo = "";
        private DataView _DataView = new DataView();

        public frmLicenseHistory(string NationalNo)
        {
            InitializeComponent();
            _NationalNo = NationalNo;
        }

        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            _PrepareProperties();
        }

        void _PrepareProperties()
        {
            gbFilter.Enabled = false;

            if (_PersonID != -1)
                _PersonID = ctrlPersonCard1.FillCardWithData(_PersonID);
            else
                _PersonID = ctrlPersonCard1.FillCardWithData(_NationalNo);

            if (_PersonID == -1)
            {
                MessageBox.Show("Person is Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tbFilterValue.Text = _PersonID.ToString();
                FillLicensesHistory();
                lblRecordsNumber.Text = dgvNationalLicensesHistory.Rows.Count.ToString();
            }
        }

        private void FillLicensesHistory()
        {
            DataSet ds = clsLicenses.GetPersonLicensesHistory(_PersonID);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                dgvNationalLicensesHistory.DataSource = ds.Tables[0];
            else
                MessageBox.Show("Person Licenses' Are Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                dgvInterNationalLicenses.DataSource = ds.Tables[1];
            else
                dgvInterNationalLicenses.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                lblRecordsNumber.Text=dgvNationalLicensesHistory.Rows.Count.ToString();
            else
                lblRecordsNumber.Text=dgvInterNationalLicenses.Rows.Count.ToString();
        }
    }
}
