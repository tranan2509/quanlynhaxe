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
    public class Photo
    {

        public Photo(int id, Image imagePerson)
        {
            this.ID = id;
            this.ImagePerson = ImagePerson;
        }

        public Photo(DataRow row)
        {
            this.ID = (int)row["id"];
            byte[] pic;
            MemoryStream picture;
            if (row["image"].ToString() != "")
            {
                pic = (byte[])row["image"];
                picture = new MemoryStream(pic);
                this.ImagePerson = Image.FromStream(picture);
            }
            else this.ImagePerson = null;
        }

        private int iD;
        private Image imagePerson;
        
        public int ID { get { return iD; } set { iD = value; } }
        public Image ImagePerson { get { return imagePerson; } set { imagePerson = value; } }
    }
}
