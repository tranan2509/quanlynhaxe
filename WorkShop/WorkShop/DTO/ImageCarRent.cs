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
    public class ImageCarRent
    {
        public ImageCarRent()
        {

        }
        public ImageCarRent(int id, int idCar, Image frontCheckIn, Image backCheckIn)
        {
            this.ID = id;
            this.IDCar = idCar;
            this.FrontCheckIn = frontCheckIn;
            this.BackCheckIn = backCheckIn;
        }
        public ImageCarRent(DataRow row)
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
    }
}
