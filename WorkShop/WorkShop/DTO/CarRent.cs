using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class CarRent
    {
        public CarRent()
        {

        }

        public CarRent(int id, string licensePlates, string type, string color, Image frontCar, Image backCar)
        {
            this.ID = id;
            this.LicensePlates = licensePlates;
            this.Type = type;
            this.Color = color;
            this.FrontCheckIn = frontCar;
            this.BackCheckIn = backCar;
        }

        public CarRent(int id, string licensePlates, string type, string color, Image frontCar, Image backCar, string status)
        {
            this.ID = id;
            this.LicensePlates = licensePlates;
            this.Type = type;
            this.Color = color;
            this.FrontCheckIn = frontCar;
            this.BackCheckIn = backCar;
            this.Status = status;
        }

        public CarRent(DataRow row)
        {
            this.ID = (int)row["id"];
            this.LicensePlates = row["licensePlates"].ToString();
            this.Type = row["type"].ToString();
            this.Color = row["color"].ToString();
            byte[] pic;
            MemoryStream picture;
            if (row["frontCheckIn"].ToString() != "")
            {
                pic = (byte[])row["frontCheckIn"];
                picture = new MemoryStream(pic);
                this.FrontCheckIn = Image.FromStream(picture);
            }
            else this.FrontCheckIn = null;

            if (row["backCheckIn"].ToString() != "")
            {
                pic = (byte[])row["backCheckIn"];
                picture = new MemoryStream(pic);
                this.BackCheckIn = Image.FromStream(picture);
            }
            else this.BackCheckIn = null;
        }

        public CarRent(DataRow row, string status)
        {
            this.ID = (int)row["id"];
            this.LicensePlates = row["licensePlates"].ToString();
            this.Type = row["type"].ToString();
            this.Color = row["color"].ToString();
            byte[] pic;
            MemoryStream picture;
            if (row["frontCheckIn"].ToString() != "")
            {
                pic = (byte[])row["frontCheckIn"];
                picture = new MemoryStream(pic);
                this.FrontCheckIn = Image.FromStream(picture);
            }
            else this.FrontCheckIn = null;

            if (row["backCheckIn"].ToString() != "")
            {
                pic = (byte[])row["backCheckIn"];
                picture = new MemoryStream(pic);
                this.BackCheckIn = Image.FromStream(picture);
            }
            else this.BackCheckIn = null;
            this.status = status;
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string licensePlates;

        public string LicensePlates
        {
            get { return licensePlates; }
            set { licensePlates = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private Image frontCheckIn;

        public Image FrontCheckIn
        {
            get { return frontCheckIn; }
            set { frontCheckIn = value; }
        }
        private Image backCheckIn;

        public Image BackCheckIn
        {
            get { return backCheckIn; }
            set { backCheckIn = value; }
        }

        public string Status { get { return status; } set { status = value; } }

        private string status;
    }
}
