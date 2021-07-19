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
using System.IO;

namespace WorkShop
{
    public partial class ListCarRentUCForm : UserControl
    {
        private static ListCarRentUCForm _instance;
        public static ListCarRentUCForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListCarRentUCForm();
                return _instance;
            }
        }
        private Customer customerRent;
        public Customer CustomerRent
        {
            get { return this.customerRent; }
            set { this.customerRent = value; { LoadCarCustomerCanRent(customerRent.ID); } }
        }

        private int typeRent;
        public int TypeRent
        {
            get { return this.typeRent; }
            set { this.typeRent = value; }
        }
        private Staff staffRent;
        public Staff StaffRent { get { return staffRent; } set { staffRent = value; } }

        private CarRent infoCarRent;
        public CarRent InfoCarRent { get { return infoCarRent; } set { infoCarRent = value; } }

        public Panel PnlRentCar { get { return pnlRentCar; } set { pnlRentCar = value; /*LoadListCustomer();*/ } }

        private Panel pnlRentCar;

        public ListCarRentUCForm()
        {
            InitializeComponent();
            dtgvCarRent.ReadOnly = true;
            dtgvCarRent.RowTemplate.Height = 80;
            dtgvCarRent.AllowUserToAddRows = false;
            LoadListCustomer();
        }
        void LoadListCustomer()
        {
            DataGridViewImageColumn picColFront = new DataGridViewImageColumn();
            DataGridViewImageColumn picColBack = new DataGridViewImageColumn();
            dtgvCarRent.DataSource = CarRentDAO.Instance.GetAllDataCarRentAtCompany();
            picColFront = (DataGridViewImageColumn)dtgvCarRent.Columns["Front Image"];
            picColBack = (DataGridViewImageColumn)dtgvCarRent.Columns["Back Image"];
            if (picColFront != null)
                picColFront.ImageLayout = DataGridViewImageCellLayout.Stretch;
            if (picColBack != null)
                picColBack.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        void LoadCarCustomerCanRent(int idCustomer)
        {
            dtgvCarRent.DataSource = CarRentDAO.Instance.GetAllDataCarRentCustomerCanRent(idCustomer);
        }
        private void ListCarRentUCForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (!pnlRentCar.Controls.Contains(CustomerUCForm.Instance))
            {
                pnlRentCar.Controls.Add(CustomerUCForm.Instance);
                CustomerUCForm.Instance.PnlRentCar = pnlRentCar;
                CustomerUCForm.Instance.Dock = DockStyle.Fill;
                CustomerUCForm.Instance.BringToFront();
            }
            else
                CustomerUCForm.Instance.BringToFront();
        }

        private void ckbType_CheckedChanged(object sender, EventArgs e)
        {
            SearchCarRent();
        }
        private void ckbColor_CheckedChanged(object sender, EventArgs e)
        {
            SearchCarRent();
        }
        void SearchCarRent()
        {
            string type = txtTypeCar.Text;
            string color = txtColorCar.Text;

            if (ckbType.Checked == true)
            {
                if (ckbColor.Checked == true)
                {
                    dtgvCarRent.DataSource = CarRentDAO.Instance.SearchCarRentAtCompanyByTypeCarAndColor(type, color);
                }
                else
                {
                    dtgvCarRent.DataSource = CarRentDAO.Instance.SearchCarRentAtCompanyByTypeCar(type);
                }
            }
            else
            {
                if (ckbColor.Checked == true)
                {
                    dtgvCarRent.DataSource = CarRentDAO.Instance.SearchCarRentAtCompanyByColor(color);
                }
                else
                {
                    dtgvCarRent.DataSource = CarRentDAO.Instance.GetAllDataCarRentAtCompany();
                }
            }
        }

        private void txtColorCar_TextChanged(object sender, EventArgs e)
        {
            SearchCarRent();
        }

        private void txtTypeCar_TextChanged(object sender, EventArgs e)
        {
            SearchCarRent();
        }

        private void dtgvCarRent_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgvCarRent.CurrentRow.Cells["ID"].Value.ToString());
            string licensePlates = dtgvCarRent.CurrentRow.Cells["License Plates"].Value.ToString();
            string type = dtgvCarRent.CurrentRow.Cells["Type"].Value.ToString();
            string color = dtgvCarRent.CurrentRow.Cells["Color"].Value.ToString();
            MemoryStream pictureFront = new MemoryStream((byte[])(dtgvCarRent.CurrentRow.Cells["Front Image"].Value));
            Image frontCar = Image.FromStream(pictureFront);
            MemoryStream pictureBack = new MemoryStream((byte[])(dtgvCarRent.CurrentRow.Cells["Back Image"].Value));
            Image backCar = Image.FromStream(pictureBack);

            CarRent carRent = new CarRent(id, licensePlates, type, color, frontCar, backCar);
            this.InfoCarRent = carRent;
            LoadContractRentUCForm();
        }

        void LoadContractRentUCForm()
        {
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
    }
}
