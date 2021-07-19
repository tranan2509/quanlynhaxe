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
    public partial class PriceCarInParkingForm : Form
    {

        BindingSource listPriceTypeCar;
        public PriceCarInParkingForm()
        {
            InitializeComponent();
            listPriceTypeCar = new BindingSource();
            LoadListPriceTypeCar();
            LoadCombobox();
            BindingData();
        }

        #region Methods
        void LoadListPriceTypeCar()
        {
            cmbTypeCar.DataSource = listPriceTypeCar;
            listPriceTypeCar.DataSource = PriceTypeCarParkingDAO.Instance.GetListPriceTypeCarParking();
        }
        void LoadCombobox()
        {
            cmbTypeCar.DisplayMember = "typeCar";
            cmbTypeCar.ValueMember = "id";
        }
        void BindingData()
        {
            txtPrice.DataBindings.Add(new Binding("Text", cmbTypeCar.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cmbTypeCar.SelectedValue;
                string typeCar = cmbTypeCar.Text;
                double price;
                if (!Double.TryParse(txtPrice.Text, out price))
                {
                    errorProviderCar.SetError(txtPrice, "Invalid Price");
                    return;
                }
                if (MessageBox.Show("Do you really want to Update price " + typeCar + "?", "Price Car In Parking", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (PriceTypeCarParkingDAO.Instance.UpdateTypeCarParkingByID(id, typeCar, (float)price))
                    {
                        MessageBox.Show("Price Updated", "Price Car In Parking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Price Not Updated", "Price Car In Parking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Price Car In Parking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void cmbTypeCar_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            errorProviderCar.Clear();
        }
        #endregion

    }
}
