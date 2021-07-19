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
    public partial class RentAndReturnCarForm : Form
    {
        private CarRent carRentCustomer;
        public CarRent CarRentCustomer { get { return carRentCustomer; } set { carRentCustomer = value; } }


        private Customer customerRent;
        public Customer CustomerRent { get { return customerRent; } set { customerRent = value;  } }

        public RentAndReturnCarForm(CarRent carRent, Customer customer)
        {
            InitializeComponent();
            this.CarRentCustomer = carRent;
            this.CustomerRent = customer;
            LoadData();
        }

        void LoadData()
        {
            DataTable data = ContractRentDAO.Instance.GetStatusCarByIDCustomerAndIDCar(CustomerRent.ID, CarRentCustomer.ID);
            dtpkFromDate.Value = (DateTime)data.Rows[0]["timeIn"];
            dtpkToDate.Value = (DateTime)data.Rows[0]["timeOut"];
            lbLicensePlates.Text = data.Rows[0]["licensePlates"].ToString();
            btnPerform.Text = CarRentCustomer.Status;
            if ((int)data.Rows[0]["idRenter"] == 0)
            {
                lbStatus.Text = "Car at the company";
            }
            else
            {
                lbStatus.Text = "Car is not at the company";
                if (btnPerform.Text == "Get Car")
                {
                    lbStatus.ForeColor = Color.Red;
                    btnPerform.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (btnPerform.Text == "Get Car")
            {
                if (ContractRentDAO.Instance.CustomerGetCar(CustomerRent.ID, CarRentCustomer.ID))
                {
                    MessageBox.Show("Successfull", "Get Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Get Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (ContractRentDAO.Instance.CustomerReturnCar(CustomerRent.ID, CarRentCustomer.ID))
                {
                    MessageBox.Show("Successfull", "Get Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Get Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
