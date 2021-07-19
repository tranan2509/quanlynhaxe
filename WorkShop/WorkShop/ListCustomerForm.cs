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
using WorkShop.DTO;

namespace WorkShop
{
    public partial class ListCustomerForm : Form
    {
        public ListCustomerForm()
        {
            InitializeComponent();
            dtgvListCustomer.ReadOnly = true;
            dtgvListCustomer.RowTemplate.Height = 80;
            dtgvListCustomer.AllowUserToAddRows = false;
            LoadListCustomer();
        }

        #region Methods
        void LoadListCustomer()
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgvListCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            picCol = (DataGridViewImageColumn)dtgvListCustomer.Columns["Image"];
            if (picCol != null)
              picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        #endregion

        #region Events

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        #endregion

        private void dtgvListCustomer_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvListCustomer.CurrentRow.Cells["ID Customer"].Value.ToString());
            Customer customer = CustomerDAO.Instance.GetCustomerByID(id);
            InfoCusomerParkingForm infoCusF = new InfoCusomerParkingForm();
            infoCusF.CustomerParking = customer;
            infoCusF.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            picSreach_Click(sender, new EventArgs());
        }

        private void picSreach_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;
            if (keyWord != "")
            {
                dtgvListCustomer.DataSource = CustomerDAO.Instance.SearchInfoCustomer(keyWord);
            }
            else LoadListCustomer();
        }
    }
}
