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
    public partial class DemoParkingLot : Form
    {
        public List<Button> lCar = new List<Button>();
        List<Button> lMotobike = new List<Button>();
        List<Button> lBicycle = new List<Button>();

        public static int carEnable = 0;
        public static int motoEnable = 0;
        public static int bicycleEnable = 0;
        public DemoParkingLot()
        {
            InitializeComponent();
        }

        private void DemoParkingLot_Load(object sender, EventArgs e)
        {
            lCar.Add(A1btn);
            lCar.Add(A2btn);
            lCar.Add(A3btn);
            lCar.Add(A4btn);
            lCar.Add(A5btn);
            lCar.Add(A6btn);

            lMotobike.Add(B1btn);
            lMotobike.Add(B2btn);
            lMotobike.Add(B3btn);
            lMotobike.Add(B4btn);
            lMotobike.Add(B5btn);
            lMotobike.Add(B6btn);

            lBicycle.Add(C1btn);
            lBicycle.Add(C2btn);
            lBicycle.Add(C3btn);
            lBicycle.Add(C4btn);
            lBicycle.Add(C5btn);
            lBicycle.Add(C6btn);
          
        }

        int GetEnable(List<Button> lButton)
        {
            int count = 0;
            foreach(Button bt in lButton)
            {
                if (bt.Tag == null)
                    count++;
            }
            return count;
        }

        public void AddCar(Car carParking)
        {
            foreach (Button bt in lCar)
            {
                if (bt.Enabled == false)
                {
                    bt.Text = carParking.ID.ToString();
                    bt.BackColor = Color.Red;
                    bt.Enabled = true;
                    bt.Tag = carParking;
                    bt.Click+=bt_Click;
                    carEnable--;
                    break;
                }
            }
        }

        public void AddMoto(Car carParking)
        {
            foreach (Button bt in lMotobike)
            {
                if (bt.Enabled == false)
                {
                    bt.Text = carParking.ID.ToString();
                    bt.BackColor = Color.Red;
                    bt.Enabled = true;
                    bt.Tag = carParking;
                    bt.Click += bt_Click;
                    motoEnable--;
                    break;
                }
            }
        }

        public void AddBicycle(Car carParking)
        {
            foreach (Button bt in lBicycle)
            {
                if (bt.Enabled == false)
                {
                    bt.Text = carParking.ID.ToString();
                    bt.BackColor = Color.Red;
                    bt.Enabled = true;
                    bt.Tag = carParking;
                    bt.Click += bt_Click;
                    bicycleEnable--;
                    break;
                }
            }
        }

        void bt_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        void ShowCar(int idCar)
        {
            lsvCar.Items.Clear();

            Car car = CarDAO.Instance.GetCarByID(idCar);

            ListViewItem lsvItem = new ListViewItem(car.ID.ToString());
            lsvItem.SubItems.Add(car.LicensePlates);
            lsvItem.SubItems.Add(car.Color);
            lsvItem.SubItems.Add(car.Type);

            lsvCar.Items.Add(lsvItem);
        }
        public void AddCarToParkingLot(Car carParking)
        {
            if (carParking.Type == "C")
                AddCar(carParking);

            if (carParking.Type == "M")
                AddMoto(carParking);

            if (carParking.Type == "B")
                AddBicycle(carParking);
        }

        public void DeleteCar(Car carParking)
        {
            foreach (Button bt in lCar)
            {
                if (bt.Enabled == true && carParking.ID.ToString() == bt.Text)
                {
                    bt.Enabled = false;
                    bt.BackColor = Color.White;
                    bt.Text = bt.Name[0].ToString() + bt.Name[1].ToString();
                    bt.Tag = null;
                    carEnable++;
                    break;
                }
            }
        }

        public void DeleteMotobike(Car carParking)
        {
            foreach (Button bt in lMotobike)
            {
                if (bt.Enabled == true && carParking.ID.ToString() == bt.Text)
                {
                    bt.Enabled = false;
                    bt.BackColor = Color.White;
                    bt.Text = bt.Name[0].ToString() + bt.Name[1].ToString();
                    bt.Tag = null;
                    motoEnable++;
                    break;
                }
            }
        }

        public void DeleteBicycle(Car carParking)
        {
            foreach (Button bt in lBicycle)
            {
                if (bt.Enabled == true && carParking.ID.ToString() == bt.Text)
                {
                    bt.Enabled = false;
                    bt.BackColor = Color.White;
                    bt.Text = bt.Name[0].ToString() + bt.Name[1].ToString();
                    bt.Tag = null;
                    bicycleEnable++;
                    break;
                }
            }
        }

        public void DeleteCarToParkingPot(Car carparking)
        {
            if (carparking.Type == "C")
                DeleteCar(carparking);
            if (carparking.Type == "M")
                DeleteMotobike(carparking);
            if (carparking.Type == "B")
                DeleteBicycle(carparking);
        }

        public void LoadUnChecked(List<Car> carUnChecked)
        {
            foreach(Car car in carUnChecked)
            {
                if (car.Type == "C")
                {
                    foreach (Button bt in lCar)
                    {
                        if (bt.Enabled == false)
                        {
                            bt.Text = car.ID.ToString(); ;
                            bt.BackColor = Color.Red;
                            bt.Enabled = true;
                            bt.Tag = car;
                            break;
                        }
                    }
                }

                if (car.Type == "M")
                {
                    foreach (Button bt in lMotobike)
                    {
                        if (bt.Enabled == false)
                        {
                            bt.Text = car.ID.ToString(); ;
                            bt.BackColor = Color.Red;
                            bt.Enabled = true;
                            bt.Tag = car;
                            break;
                        }
                    }
                }

                if (car.Type == "B")
                {
                    foreach (Button bt in lBicycle)
                    {
                        if (bt.Enabled == false)
                        {
                            bt.Text = car.ID.ToString();
                            bt.BackColor = Color.Red;
                            bt.Enabled = true;
                            bt.Tag =car ;
                            break;
                        }
                    }
                }             
            }
            carEnable = GetEnable(lCar);
            motoEnable = GetEnable(lMotobike);
            bicycleEnable = GetEnable(lBicycle);
        }


        #region Button click
        private void A1btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void A2btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void A3btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void A4btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void A5btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void A6btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void B1btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void B2btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void B3btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void B4btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void B5btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void B6btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void C1btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void C2btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void C3btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void C4btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void C5btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }

        private void C6btn_Click(object sender, EventArgs e)
        {
            int carID = ((sender as Button).Tag as Car).ID;
            ShowCar(carID);
        }
#endregion
       
        //button ADD
        //private void btAdd_Click(object sender, EventArgs e)
        //{
        //    foreach (Button bt in lstBtnCalc)
        //    {
        //        if (bt.Enabled == true)
        //        {
        //            bt.Text = textBox1.Text;
        //            bt.BackColor = Color.Red;
        //            bt.Enabled = false;
        //            textBox1.Text = "";
        //            break;
        //        }
        //    }
        //}

        //button Remove
        //private void btRemove_Click(object sender, EventArgs e)
        //{
        //    foreach (Button bt in lstBtnCalc)
        //    {
        //        if (bt.Enabled == false && textBox1.Text == bt.Text)
        //        {
        //            bt.Enabled = true;
        //            textBox1.Text = "";
        //            bt.BackColor = Color.WhiteSmoke;
        //            bt.Text = "";
        //            break;
        //        }
        //    }
        //}
    }
}
