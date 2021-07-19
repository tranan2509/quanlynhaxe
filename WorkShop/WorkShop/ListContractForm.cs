using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DAO;

namespace WorkShop
{
    public partial class ListContractForm : Form
    {
        public ListContractForm()
        {
            InitializeComponent();
            dtgvListContract.ReadOnly = true;
            dtgvListContract.AllowUserToAddRows = false;
            LoadListContract();
        }

        #region Methods
        void LoadListContract()
        {
            dtgvListContract.DataSource = ContractDAO.Instance.GetListContract();
        }


        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListContract();
        }

        private void picSreach_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;
            if (keyWord != "")
            {
                dtgvListContract.DataSource = ContractDAO.Instance.SearchInfoContract(keyWord);
            }
            else LoadListContract();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            picSreach_Click(sender, new EventArgs());
        }

        private void picSearchTime_Click(object sender, EventArgs e)
        {
            if (rdAll.Checked == true)
            {
                LoadListContract();
            }
            else if (rdTimeIn.Checked == true)
            {
                dtgvListContract.DataSource = ContractDAO.Instance.SearchInfoContractByTimeIn(dtpkTimeStart.Value, dtpkTimeEnd.Value);
            }
            else dtgvListContract.DataSource = ContractDAO.Instance.SearchInfoContractByTimeOut(dtpkTimeStart.Value, dtpkTimeEnd.Value);
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            picSearchTime_Click(sender, new EventArgs());
        }

        private void rdTimeIn_CheckedChanged(object sender, EventArgs e)
        {
            picSearchTime_Click(sender, new EventArgs());
        }

        private void rdTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            picSearchTime_Click(sender, new EventArgs());
        }
    }
}
