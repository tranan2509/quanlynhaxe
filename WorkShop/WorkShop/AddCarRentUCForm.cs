using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DAO;
using WorkShop.DTO;
using System.Security.AccessControl;
using System.Security.RightsManagement;

namespace WorkShop
{
    public partial class AddCarRentUCForm : UserControl
    {
        private static AddCarRentUCForm _instance;
        public static AddCarRentUCForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddCarRentUCForm();
                return _instance;
            }
        }
        private Customer customerRent;
        public Customer CustomerRent
        {
            get { return this.customerRent; }
            set { this.customerRent = value;}
        }

        private int typeRent;
        public int TypeRent
        {
            get { return this.typeRent; }
            set { this.typeRent = value; }
        }

        private Staff staffRent;
        public Staff StaffRent { get { return staffRent; } set { staffRent = value; } }

        public Panel PnlRentCar { get { return pnlRentCar; } set { pnlRentCar = value; } }


        private Panel pnlRentCar;

        private CarRent infoCarRent;
        public CarRent InfoCarRent { get { return infoCarRent; } set { infoCarRent = value; } }

        public bool IsExtraCompany { get { return isExtraCompany; } set { isExtraCompany = value; HidePnlNextPage(isExtraCompany); } }

        private bool isExtraCompany;

        public AddCarRentUCForm()
        {
            InitializeComponent();
            IsExtraCompany = false;
        }

        #region Methods

        void HidePnlNextPage(bool isExtraCompany)
        {
            if (isExtraCompany == false)
            {
                pnlNextPage.Visible = true;
                CustomerRent = new Customer(0, "00000", 0, 0, "Company", "", null, null, null, "HCM", "0392889894");
            }
            else
                pnlNextPage.Visible = false;
        }
        bool verif()
        {
            if (string.IsNullOrEmpty(txtLicensePlates.Text)
                || string.IsNullOrEmpty(txtType.Text)
                || string.IsNullOrEmpty(txtColor.Text)
                || picFrontCar.Image == null
                || picBackCar.Image == null)
                return true;
            return false;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picFrontCar.Image = Image.FromFile(open.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBackCar.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Data may not be blank", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string licensePlates = txtLicensePlates.Text;
            string type = txtType.Text;
            string color = txtColor.Text;
            Image frontCar = picFrontCar.Image;
            Image backCar = picBackCar.Image;
            if (CarRentDAO.Instance.IsExistCarRentByLicensePlates(licensePlates))
            {
                errorProviderAddCar.SetError(txtLicensePlates, "License Plates already exist!");
                return;
            }
            if (isExtraCompany == true)
            {
                if (CarRentDAO.Instance.InsertCarRentOfCompany(licensePlates, type, color, frontCar, backCar))
                {
                    int id = (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Car");
                    InfoCarRent = new CarRent(id, licensePlates, type, color, frontCar, backCar);
                    MessageBox.Show("Car inserted", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (CarRentDAO.Instance.InsertCarRentOfCustomer(CustomerRent.ID, licensePlates, type, color, frontCar, backCar))
                {
                    int id = (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Car");
                    InfoCarRent = new CarRent(id, licensePlates, type, color, frontCar, backCar);
                    MessageBox.Show("Car inserted", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (!pnlRentCar.Controls.Contains(CustomerUCForm.Instance))
            {
                pnlRentCar.Controls.Add(CustomerUCForm.Instance);
                CustomerUCForm.Instance.PnlRentCar = PnlRentCar;
                CustomerUCForm.Instance.Dock = DockStyle.Fill;
                CustomerUCForm.Instance.BringToFront();
            }
            else
                CustomerUCForm.Instance.BringToFront();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (InfoCarRent == null)
            {
                MessageBox.Show("More cars before continuing!", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(verif())
            {
                return;
            }
            if (!pnlRentCar.Controls.Contains(ContractCarRentUCForm.Instance))
            {
                pnlRentCar.Controls.Add(ContractCarRentUCForm.Instance);
                ContractCarRentUCForm.Instance.PnlRentCar = PnlRentCar;
                ContractCarRentUCForm.Instance.Dock = DockStyle.Fill;
                ContractCarRentUCForm.Instance.BringToFront();
            }
            else
                ContractCarRentUCForm.Instance.BringToFront();
            ContractCarRentUCForm.Instance.CustomerRent = CustomerRent;
            ContractCarRentUCForm.Instance.InfoCarRent = InfoCarRent;
            ContractCarRentUCForm.Instance.TypeRent = TypeRent;
            ContractCarRentUCForm.Instance.StaffRent = StaffRent;
        }

        private void txtLicensePlates_TextChanged(object sender, EventArgs e)
        {
            errorProviderAddCar.Clear();
        }
    }
}
