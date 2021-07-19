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
    public class ImageCar
    {
        public ImageCar(int id, int idCar, int status ,Image frontCheckIn, Image backCheckIn, Image frontCheckOut = null, Image backCheckOut = null)
        {
            this.ID = id;
            this.IDCar = idCar;
            this.Status = status;
            this.FrontCheckIn = frontCheckIn;
            this.BackCheckIn = backCheckIn;
            this.FrontCheckOut = frontCheckOut;
            this.BackCheckOut = backCheckOut;
        }

        public ImageCar(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDCar = (int)row["idCar"];
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

            if (row["frontCheckOut"].ToString() != "")
            {
                pic = (byte[])row["frontCheckOut"];
                picture = new MemoryStream(pic);
                this.FrontCheckOut = Image.FromStream(picture);
            }
            else this.FrontCheckOut = null;

            if (row["backCheckOut"].ToString() != "")
            {
                pic = (byte[])row["backCheckOut"];
                picture = new MemoryStream(pic);
                this.BackCheckOut = Image.FromStream(picture);
            }
            else this.BackCheckOut = null;

            this.Status = (int)row["status"];
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private int iDCar;

        public int IDCar
        {
            get { return iDCar; }
            set { iDCar = value; }
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
        private Image frontCheckOut;

        public Image FrontCheckOut
        {
            get { return frontCheckOut; }
            set { frontCheckOut = value; }
        }
        private Image backCheckOut;

        public Image BackCheckOut
        {
            get { return backCheckOut; }
            set { backCheckOut = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
