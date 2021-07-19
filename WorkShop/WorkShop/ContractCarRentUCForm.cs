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

namespace WorkShop
{
    public partial class ContractCarRentUCForm : UserControl
    {
        private static ContractCarRentUCForm _instance;
        public static ContractCarRentUCForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContractCarRentUCForm();
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
        public Staff StaffRent { get { return staffRent; } set { staffRent = value; } }


        private CarRent infoCarRent;
        public CarRent InfoCarRent { get { return infoCarRent; } set { infoCarRent = value; LoadInfoCarRentOnFomr(InfoCarRent); } }

        public int TypeRent { get { return typeRent; } set { typeRent = value; LoadTypeRent(typeRent); } }

        private int typeRent;
        public ContractCarRentUCForm()
        {
            InitializeComponent();
            lbTotalCost.Text = 0.ToString();
            timerToDate.Start();
        }

        void LoadContract()
        {
            dtpkFromDate.Value = DateTime.Now;
            dtpkToDate.Value = DateTime.Now;
        }

        void LoadTypeRent(int typeRent)
        {
            if (typeRent == 0)
            {
                lbCarHireSubjects.Text = "Customer";
                lbCarForRent.Text = "Company";
            }
            else if (typeRent == 1)
            {
                lbCarHireSubjects.Text = "Company";
                lbCarForRent.Text = "Customer";
            }
        }
        void LoadInfoCustomerOnForm(Customer customer)
        {
            lbCustomerName.Text = customer.Fname + " " + customer.Lname;
            lbIdentityNumber.Text = customer.IdentityNumber;
            lbPhone.Text = customer.Phone;
            lbAddress.Text = customer.Address;
        }

        void LoadInfoCarRentOnFomr(CarRent carRent)
        {
            lbLicensePlates.Text = carRent.LicensePlates;
            lbType.Text = carRent.Type;
            lbColor.Text = carRent.Color;
            picFrontCar.Image = carRent.FrontCheckIn;
            picBackCar.Image = carRent.BackCheckIn;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (TypeRent == 0)
            {
                if (!PnlRentCar.Controls.Contains(ListCarRentUCForm.Instance))
                {
                    PnlRentCar.Controls.Add(ListCarRentUCForm.Instance);
                    ListCarRentUCForm.Instance.Dock = DockStyle.Fill;
                    ListCarRentUCForm.Instance.TypeRent = TypeRent;
                    ListCarRentUCForm.Instance.BringToFront();
                }
                else
                    ListCarRentUCForm.Instance.BringToFront();
            }
            else if (TypeRent == 1)
            {
                if (!PnlRentCar.Controls.Contains(AddCarRentUCForm.Instance))
                {
                    PnlRentCar.Controls.Add(AddCarRentUCForm.Instance);
                    AddCarRentUCForm.Instance.PnlRentCar = PnlRentCar;
                    AddCarRentUCForm.Instance.Dock = DockStyle.Fill;
                    AddCarRentUCForm.Instance.BringToFront();
                }
                else
                    AddCarRentUCForm.Instance.BringToFront();
            }
        }

        int DistanceBetween2Date(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            TimeSpan distance = dateTimeTo - dateTimeFrom;
            return (int)distance.TotalDays;
        }

        double TotalCost(int costByDay, int countDay)
        {
            return costByDay * countDay;
        }

        private void nmCost_ValueChanged(object sender, EventArgs e)
        {
            lbTotalCost.Text = TotalCost((int)nmCost.Value, DistanceBetween2Date(dtpkFromDate.Value, dtpkToDate.Value)).ToString();
        }

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {
            nmCost_ValueChanged(sender, new EventArgs());
        }

        private void dtpkToDate_ValueChanged(object sender, EventArgs e)
        {
            nmCost_ValueChanged(sender, new EventArgs());
        }

        private void timerToDate_Tick(object sender, EventArgs e)
        {
            lbTodate.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (TypeRent == 0)
            {
                if (ContractRentDAO.Instance.CustomerRentCarByIDCar(CustomerRent.ID, InfoCarRent.ID))
                {
                    if (ContractRentDAO.Instance.InsertContractCarRent(StaffRent.ID, CustomerRent.ID, InfoCarRent.ID, dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(lbTotalCost.Text)))
                    {
                        StaffDAO.Instance.UpdateBonusByIDStaff(StaffRent.ID);
                        MessageBox.Show("Successful", "Contract Rent Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error", "Contract Rent Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (TypeRent == 1)
            {
                if (ContractRentDAO.Instance.InsertContractCarRent(StaffRent.ID, CustomerRent.ID, InfoCarRent.ID, dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(lbTotalCost.Text)))
                {
                    StaffDAO.Instance.UpdateBonusByIDStaff(StaffRent.ID);
                    MessageBox.Show("Successful", "Contract Rent Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Contract Rent Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
