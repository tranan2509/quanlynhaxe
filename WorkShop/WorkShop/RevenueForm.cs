using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DAO;

namespace WorkShop
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            dtgvRevenue.ReadOnly = true;
            dtgvRevenue.AllowUserToAddRows = false;
            ThreadLoadRevenue();
        }

        #region Methods

        void ThreadLoadRevenue()
        {
            Thread thread = new Thread(LoadRevenue);
            thread.IsBackground = true;
            thread.Start();
        }
        void LoadRevenue()
        {
            dtgvRevenue.DataSource = ContractDAO.Instance.GetTotalRevenueByDay(dtpkDateIn.Value.Date, dtpkDateOut.Value.Date);
        }

        #endregion

        #region Events
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        #endregion
    }
}
