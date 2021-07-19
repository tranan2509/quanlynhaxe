using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DAO;
using WorkShop.DTO;

namespace WorkShop
{
    public partial class ContractParkingForm : Form
    {
        private Contract contractParking;

        public Contract ContractParking
        {
            get { return this.contractParking; }
            set { this.contractParking = value; LoadInfoOnForm(contractParking); }
        }
        private SoundPlayer bip;

        private double priceHourCar;
        private double priceHourMotobile;
        private double priceHourBicycle;
        public ContractParkingForm()
        {
            InitializeComponent();
            LoadPriceTypeCar();
            bip = new SoundPlayer("beep-06.wav");

        }

        #region Methods

        void LoadPriceTypeCar()
        {
            List<PriceTypeCarParking> listPrice = PriceTypeCarParkingDAO.Instance.GetListPriceTypeCarParking();
            priceHourCar = listPrice[0].Price;
            priceHourMotobile = listPrice[1].Price;
            priceHourBicycle = listPrice[2].Price;
        }
        void LoadInfoOnForm(Contract contract)
        {            
            if (contract != null)
            {
                Customer customer = CustomerDAO.Instance.GetCustomerByID(contract.IDCustomer);
                Car car = CarDAO.Instance.GetCarByID(contract.IDCar);
                txtCarID.Text = contract.IDCar.ToString();
                txtCustomerID.Text = contract.IDCustomer.ToString();
                txtStaffID.Text = contract.IDStaff.ToString();
                txtFirstName.Text = customer.Fname;
                txtLastName.Text = customer.Lname;
                txtTypeCar.Text = car.Type;
                txtRegistrationType.Text = contract.TypeParking.ToString();
                dtpkTimeIn.Value = contract.TimeIn;
                dtpkTimeOut.Value = contract.TimeOut.Value;
                picCheckTime.Image = LoadPicCheckTime();
                txtTotalTime.Text = GetTimeParking().ToString("0.00");
                txtTotalMoney.Text = TotalMoney().ToString("0.00");
                lbTypeParking.Text = txtRegistrationType.Text;
            }
            else ClearData();
        }

        double GetTimeParking()
        {
            string registrationType = txtRegistrationType.Text;
            TimeSpan timeSpan = dtpkTimeOut.Value.Subtract(dtpkTimeIn.Value);
            switch (registrationType)
            {
                case "Hour": return timeSpan.TotalHours;
                case "Day": return timeSpan.TotalDays;
                case "Week": return timeSpan.TotalDays / 7;
                case "Month": return timeSpan.TotalDays / 30;
            }
            return 0;
        }

        void ClearData()
        {
            txtCarID.Text = "";
            txtCustomerID.Text = "";
            txtStaffID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTypeCar.Text = "";
            txtRegistrationType.Text = "";
            dtpkTimeIn.Value = DateTime.Now;
            dtpkTimeOut.Value = DateTime.Now;
            txtTotalTime.Text = "";
            txtTotalMoney.Text = "";
            picCheckTime.Image = Image.FromFile(@"Resources\timeRight.png");
            lbTypeParking.Text = "Type Parking";
        }

        Image LoadPicCheckTime()
        {
            return Image.FromFile(@"Resources\timeRight.png");
        }

        void SetPicCheckTime()
        {
            picCheckTime.Image = Image.FromFile(@"Resources\timePasses.png");
        }
        double TotalMoney()
        {
            double priceHour = priceHourParking();
            double price = 0;
            string registrationType = txtRegistrationType.Text;
            double totalTime = Convert.ToDouble(txtTotalTime.Text);
            int iTotalTime = (int)totalTime;
            if (iTotalTime < totalTime)
                totalTime = iTotalTime + 1;
            switch (registrationType)
            {
                case "Hour":
                    {
                        if (totalTime > 24)
                        {
                            SetPicCheckTime();
                            price = 2 * 8 * priceHour;
                        }
                        else price = priceHour * totalTime;
                    }
                    break;
                case "Day": { if (totalTime > 1) { SetPicCheckTime(); price = 8 * priceHour * 3; } else price = priceHour * totalTime; } break;
                case "Week": { if (totalTime * 7 > 10 && totalTime * 7 < 30) { SetPicCheckTime(); price = 8 * priceHour * 3 * 2; } else price = priceHour * totalTime; } break;
                case "Month":
                    {
                        price =  8 * priceHour * 3 * 2 * totalTime;
                    }break;
            }

           
            ContractDAO.Instance.UpdatePriceByID(ContractParking.ID, price);
            ContractDAO.Instance.UpdateValeParkingByID(ContractParking.ID, (int)Convert.ToDouble(txtTotalTime.Text));
            return price;
        }

        double priceHourParking()
        {
            string typeCar = txtTypeCar.Text;
            switch (typeCar)
            {
                case "C": case "Car": return priceHourCar;
                case "M": case "Motobike": return priceHourMotobile;
                default: return priceHourBicycle;
            }
        }

        #endregion

        #region Events

        private void btnCheckInfoCustomer_Click(object sender, EventArgs e)
        {
            InfoCusomerParkingForm f = new InfoCusomerParkingForm();
            if (ContractParking != null)
                f.CustomerParking = CustomerDAO.Instance.GetCustomerByID(ContractParking.IDCustomer);
            else f.CustomerParking = null;
            f.ShowDialog();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            string filename = txtStaffID.Text + "_" + dtpkTimeOut.Value.ToString("yyyy_MM_dd_hh_mm_ss_fff");
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Workshop\" + filename + ".txt";
                using (var writer = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    writer.WriteLine("\t\tParking Lot");
                    writer.WriteLine("----------------------------------------------------");
                    writer.WriteLine("Staff ID:     " + txtStaffID.Text);
                    writer.WriteLine("Customer ID:  " + txtCustomerID.Text);
                    writer.WriteLine("Customer:     ", CustomerDAO.Instance.GetCustomerByID(ContractParking.IDCustomer).Fname + CustomerDAO.Instance.GetCustomerByID(ContractParking.IDCustomer).Lname);
                    writer.WriteLine("Car ID:       " + txtCarID.Text);
                    writer.WriteLine("Type Car:     " + txtTypeCar.Text);
                    writer.WriteLine("Check In:     " + dtpkTimeIn.Value.ToString());
                    writer.WriteLine("Check Out:    " + dtpkTimeOut.Value.ToString());
                    writer.WriteLine("Time:         " + txtTotalTime.Text);
                    writer.WriteLine("----------------------------------------------------");
                    writer.WriteLine("Price:        " + txtTotalMoney.Text);
                }
                bip.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


    }
}
