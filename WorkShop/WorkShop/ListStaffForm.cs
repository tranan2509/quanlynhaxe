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
    public partial class ListStaffForm : Form
    {
        public ListStaffForm()
        {
            InitializeComponent();
            dtgvListStaff.ReadOnly = true;
            dtgvListStaff.RowTemplate.Height = 80;
            dtgvListStaff.AllowUserToAddRows = false;
            LoadListStaff();
        }

        #region Methods
        void LoadListStaff()
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dtgvListStaff.DataSource = StaffDAO.Instance.GetListStaff();
            picCol = (DataGridViewImageColumn)dtgvListStaff.Columns["Image"];
            if (picCol != null)
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        #endregion

        #region Events
        private void dtgvListStaff_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvListStaff.CurrentRow.Cells["ID Staff"].Value.ToString());
            Staff staff = StaffDAO.Instance.GetStaffByID(id);
            StaffForm staffF = new StaffForm();
            staffF.StaffWorkShop = staff;
            staffF.ShowDialog();
        }

        private void picSreach_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;
            if (keyWord != "")
            {
                dtgvListStaff.DataSource = StaffDAO.Instance.SearchInfoStaff(keyWord);
            }
            else LoadListStaff();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            picSreach_Click(sender, new EventArgs());
        }
        #endregion


    }
}
