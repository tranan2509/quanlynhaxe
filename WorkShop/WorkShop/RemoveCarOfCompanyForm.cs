using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DAO;

namespace WorkShop
{
    public partial class RemoveCarOfCompanyForm : Form
    {
        public RemoveCarOfCompanyForm()
        {
            InitializeComponent();
        }

        public RemoveCarOfCompanyForm(int idCar)
        {
            InitializeComponent();
            txtIDCar.Text = idCar.ToString();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtIDCar.Text, out id))
            {
                errorProviderDel.SetError(txtIDCar, "Invalid ID");
                ClearData();
                return;
            }

            DataTable data = CarRentDAO.Instance.SearchDeleteCarOfCompanyByIDCar(id);
            if (data != null)
            {
                txtLicensePlates.Text = data.Rows[0]["licensePlates"].ToString();
                txtType.Text = data.Rows[0]["type"].ToString();
                txtColor.Text = data.Rows[0]["color"].ToString();
                picFrontCar.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["frontCheckIn"]));
                picBackCar.Image = Image.FromStream(new MemoryStream((byte[])data.Rows[0]["backCheckIn"]));
            }
            else
            {
                ClearData();
            }
        }

        private void txtIDCar_TextChanged(object sender, EventArgs e)
        {
            errorProviderDel.Clear();
            picSearch_Click(sender, new EventArgs());
        }

        void ClearData()
        {
            txtLicensePlates.Text = "";
            txtType.Text = "";
            txtColor.Text = "";
            picFrontCar.Image = null;
            picBackCar.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtIDCar.Text, out id))
            {
                errorProviderDel.SetError(txtIDCar, "Invalid ID");
                ClearData();
                return;
            }       
            if (picFrontCar.Image != null)
            {   
                if (CarRentDAO.Instance.DeleteCarOfCompanyByIDCar(id))
                {
                    MessageBox.Show("Car deleted!", "Delete Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Error!", "Delete Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
