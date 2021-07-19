using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DTO;
using WorkShop.DAO;
using System.IO;
using System.Diagnostics;

namespace WorkShop
{
    public partial class ReturnCarRentUCForm : UserControl
    {
        private static ReturnCarRentUCForm _instance;
        public static ReturnCarRentUCForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReturnCarRentUCForm();
                return _instance;
            }
        }

        public Panel PnlRentCar { get { return pnlRentCar; } set { pnlRentCar = value; LoadContract(); } }

        private Panel pnlRentCar;

        private Customer customerRent;
        public Customer CustomerRent
        {
            get { return this.customerRent; }
            set { this.customerRent = value; LoadInfoCustomerOnForm(customerRent); }
        }

        private Staff staffRent;
        public Staff StaffRent { get { return staffRent; } set { staffRent = value; LoadStaff(staffRent); } }


        private CarRent infoCarRent;
        public CarRent InfoCarRent { get { return infoCarRent; } set { infoCarRent = value; LoadInfoCarRentOnFomr(InfoCarRent); } }

        public int TypeRent { get { return typeRent; } set { typeRent = value; LoadTypeRent(typeRent); } }

        private int typeRent;
        public ReturnCarRentUCForm()
        {
            InitializeComponent();
            timerToDate.Start();
            dtgvCarRent.ReadOnly = true;
            dtgvCarRent.RowTemplate.Height = 80;
            dtgvCarRent.AllowUserToAddRows = false;
            LoadListCustomer();
        } 

        void LoadListCustomer()
        {
            DataGridViewImageColumn picColFront = new DataGridViewImageColumn();
            DataGridViewImageColumn picColBack = new DataGridViewImageColumn();
            dtgvCarRent.DataSource = CarRentDAO.Instance.GetListCarRentByIDCustomer(0);
            picColFront = (DataGridViewImageColumn)dtgvCarRent.Columns["frontCheckIn"];
            picColBack = (DataGridViewImageColumn)dtgvCarRent.Columns["backCheckIn"];
            if (picColFront != null)
                picColFront.ImageLayout = DataGridViewImageCellLayout.Stretch;
            if (picColBack != null)
                picColBack.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        void LoadListCarRent()
        {
            dtgvCarRent.DataSource = CarRentDAO.Instance.GetListCarRentByIDCustomer(CustomerRent.ID);
        }

        void LoadContract()
        {
            
        }

        void LoadStaff(Staff staff)
        {
            lbStaffSigned.Text = staff.Lname + " " + staff.Fname;
        }
        void LoadTypeRent(int typeRent)
        {
            
        }
        void LoadInfoCustomerOnForm(Customer customer)
        {
            lbCustomerName.Text = customer.Fname + " " + customer.Lname;
            lbIdentityNumber.Text = customer.IdentityNumber;
            lbPhone.Text = customer.Phone;
            lbAddress.Text = customer.Address;
            lbQRCode.Text = customer.QrCode;
            LoadListCarRent();
        }

        void LoadInfoCarRentOnFomr(CarRent carRent)
        {
            
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

        private void timerToDate_Tick(object sender, EventArgs e)
        {
            lbTodate.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void dtgvCarRent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dtgvCarRent.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(dtgvCarRent.CurrentRow.Cells["ID"].Value.ToString());
                    string licensePlates = dtgvCarRent.CurrentRow.Cells["LicensePlates"].Value.ToString();
                    string type = dtgvCarRent.CurrentRow.Cells["Type"].Value.ToString();
                    string color = dtgvCarRent.CurrentRow.Cells["Color"].Value.ToString();
                    Image frontCar = (Image)dtgvCarRent.CurrentRow.Cells["FrontCheckIn"].Value;
                    Image backCar = (Image)dtgvCarRent.CurrentRow.Cells["BackCheckIn"].Value;
                    string status = dtgvCarRent.CurrentRow.Cells["Status"].Value.ToString();
                    CarRent carRent = new CarRent(id, licensePlates, type, color, frontCar, backCar, status);
                    this.InfoCarRent = carRent;
                    RentAndReturnCarForm rarF = new RentAndReturnCarForm(InfoCarRent, CustomerRent);
                    rarF.ShowDialog(this);
                }
            }
            catch { }
        }
    }
}
