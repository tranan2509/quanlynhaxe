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
    public partial class ListCarRentForm : Form
    {
        public ListCarRentForm()
        {
            InitializeComponent();
            dtgvCarRent.ReadOnly = true;
            dtgvCarRent.RowTemplate.Height = 80;
            dtgvCarRent.AllowUserToAddRows = false;
            LoadListCustomer(0);
            LoadCmb();
        }

        void LoadCmb()
        {
            cmbSelectListType.SelectedIndex = 0;
        }
        void LoadListCustomer(int index)
        {
            dtgvCarRent.DataSource = null;
            DataGridViewImageColumn picColFront = new DataGridViewImageColumn();
            DataGridViewImageColumn picColBack = new DataGridViewImageColumn();
            switch (index)
            {
                case 0: dtgvCarRent.DataSource = CarRentDAO.Instance.GetListOfVehiclesUnderManagement(); break;
                case 1: dtgvCarRent.DataSource = CarRentDAO.Instance.GetListOfCarCompanies(); break;
                case 2: dtgvCarRent.DataSource = CarRentDAO.Instance.GetVehicleListingsCanRented(); break;
                case 3: dtgvCarRent.DataSource = CarRentDAO.Instance.GetListOfVehiclesBeingRented(); break;
                case 4: dtgvCarRent.DataSource = CarRentDAO.Instance.GetListOfRentedCars(); break;
                default: dtgvCarRent.DataSource = CarRentDAO.Instance.GetListOfVehiclesUnderManagement(); break;
            }
            picColFront = (DataGridViewImageColumn)dtgvCarRent.Columns["Front Image"];
            picColBack = (DataGridViewImageColumn)dtgvCarRent.Columns["Back Image"];
            if (picColFront != null)
                picColFront.ImageLayout = DataGridViewImageCellLayout.Stretch;
            if (picColBack != null)
                picColBack.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void cmbSelectListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListCustomer(cmbSelectListType.SelectedIndex);
        }

        private void dtgvCarRent_DoubleClick(object sender, EventArgs e)
        {
            if (cmbSelectListType.SelectedIndex == 1)
            {
                if (Convert.ToInt32(dtgvCarRent.CurrentRow.Cells["ID Renter"].Value.ToString()) == 0)
                {
                    int idCar = Convert.ToInt32(dtgvCarRent.CurrentRow.Cells["ID Car"].Value.ToString());
                    RemoveCarOfCompanyForm removeF = new RemoveCarOfCompanyForm(idCar);
                    removeF.ShowDialog(this);
                }
            }
        }
    }
}
