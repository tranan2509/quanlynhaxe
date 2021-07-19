using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Threading;
using WorkShop.DAO;
using WorkShop.DTO;
using System.Media;

namespace WorkShop
{
    public partial class ParkingLotForm : Form
    {
        private SoundPlayer bip;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        MJPEGStream stream;
        MJPEGStream stream2;
        string strCamFront = @"http://192.168.43.138:4747/video/mjpegfeed?1920x1080";
        string strCamBack = @"http://192.168.1.5:4747/video/mjpegfeed?1920x1080";
        ContractParkingForm contractF;
        DemoParkingLot demo;

        private Staff staffParking;

        public Staff StaffParking
        {
            get { return staffParking; }
            set { staffParking = value; LoadStaff(StaffParking); }
        }


        public ParkingLotForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            bip = new SoundPlayer("beep-06.wav");
            LoadContractParkingForm();
            demo = new DemoParkingLot();
            List<Car> lCar = CarDAO.Instance.getListCarUnChecked();
            demo.Show();
            demo.LoadUnChecked(lCar);
        }

        #region Methods

        void LoadStaff(Staff staff)
        {
            lbIDStaff.Text = staff.ID.ToString();
        }
        void LoadContractParkingForm()
        {
            contractF = new ContractParkingForm();
            contractF.Show();
        }
        string GetTypeCar()
        {
            if (rdCar.Checked == true)
            {
                return "Car";
            }    
            else if (rdMotobike.Checked == true)
            {
                return "Motobike";
            }
            return "Bicycle";
        }

        string GetTypeParking()
        {
            if (rdHour.Checked == true)
                return "Hour";
            else if (rdDay.Checked == true)
                return "Day";
            else if (rdWeek.Checked == true)
                return "Week";
            return "Month";
        }

        void LoadCam()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbDeviceCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();


            stream = new MJPEGStream(strCamFront);
            stream.NewFrame += Stream_NewFrame;
            stream.Start();

            stream2 = new MJPEGStream(strCamBack);
            stream2.NewFrame += Stream2_NewFrame;
            stream2.Start();

        }

        bool DisableRadioTypeCar(int enable)
        {
            if (enable > 0)
                return true;
            return false;
        }
        
        void LoadRadioTypeCar()
        {
            rdCar.Enabled = DisableRadioTypeCar(DemoParkingLot.carEnable);
            rdMotobike.Enabled = DisableRadioTypeCar(DemoParkingLot.motoEnable);
            rdBicycle.Enabled = DisableRadioTypeCar(DemoParkingLot.bicycleEnable);
        }

        #endregion


        #region Events
        private void btStart_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(LoadCam);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Start();
            timerCamQRCode.Start();
        }


        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            picFrontIn.Image = bmp;
        }

        private void Stream2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            picBackIn.Image = bmp;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                picQRCode.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch { }
        }

     
        private void ParkingLot_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cmbDeviceCamera.Items.Add(Device.Name);
            cmbDeviceCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

            dtpkTimeNow.Format = DateTimePickerFormat.Custom;  
            dtpkTimeNow.CustomFormat = " hh:mm:ss dd/MM/yyyy";

            timerCountTime.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            dtpkTimeNow.Value = DateTime.Now;
        }

        private void ParkingLot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void timerCamQRCode_Tick(object sender, EventArgs e)
        {
            timerCamQRCode.Interval = 100;
            try
            {
                Bitmap img = (Bitmap)picQRCode.Image;
                if (img != null)
                {
                    BarcodeReader Reader = new BarcodeReader();
                   // try { Reader.Decode(img); } catch { }
                    Result result = Reader.Decode(img);
                    if (result != null)
                    {
                        timerCamQRCode.Interval = 3000;
                        txtCode.Text = result.ToString();
                    }
                }
            }
            catch { }
        }
        
        int CheckParkingLotByType(string type)
        {
            if (type == "C" || type == "Car")
                return DemoParkingLot.carEnable;
            if (type == "M" || type == "Motobike")
                return DemoParkingLot.motoEnable;
            if (type == "B" || type == "Bicycle")
                return DemoParkingLot.bicycleEnable;
            return 0;
        }
        #endregion


        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string qrCode = txtCode.Text;
            string typeCar = GetTypeCar();
            int idStaff = Convert.ToInt32(lbIDStaff.Text);
            float price = 0;
            string typeParking = GetTypeParking();
            int valueParking = 0;
            if (string.IsNullOrEmpty(qrCode))
            {
                return;
            }
            if (CustomerDAO.Instance.CheckInByQRCode(qrCode))
            {
                if (CheckParkingLotByType(typeCar) > 0)
                {
                    contractF.ContractParking = null;
                    picFrontOut.Image = null;
                    picBackOut.Image = null;
                    if (CustomerDAO.Instance.CheckInParking(qrCode, idStaff, typeCar, price, typeParking, valueParking, picFrontIn.Image, picBackIn.Image))
                    {
                        bip.Play();
                        Car carparking = CarDAO.Instance.GetCarParking(qrCode);
                        demo.AddCarToParkingLot(carparking);
                        LoadRadioTypeCar();
                    }
                }
                else
                {
                    MessageBox.Show("Parking Full " + typeCar, "Parking Lot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                int idCar = CarDAO.Instance.GetIDCarParkingByQRCode(qrCode);
                ImageCar imageCar = ImageCarDAO.Instance.GetImageCarCheckInByIdCar(idCar);
                if (imageCar != null)
                {
                    picFrontOut.Image = imageCar.FrontCheckIn;
                    picBackOut.Image = imageCar.BackCheckIn;
                }
                if (CustomerDAO.Instance.CheckOutParking(qrCode, idStaff, price, picFrontIn.Image, picBackIn.Image))
                {
                    bip.Play();
                    StaffDAO.Instance.UpdateBonusByIDStaff(StaffParking.ID);
                    contractF.ContractParking = ContractDAO.Instance.GetContractByIDCar(idCar);
                    Car carparking = CarDAO.Instance.GetCarParked(idCar);
                    demo.DeleteCarToParkingPot(carparking);
                    LoadRadioTypeCar();
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

        }

    }
}
