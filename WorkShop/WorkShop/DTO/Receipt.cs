using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class Receipt
    {
        public Receipt(int id, int idContract, DateTime dsign, string fname, string lname, float price, int idStaff)
        {
            this.ID = id;
            this.IDContract = idContract;
            this.Dsign = dsign;
            this.Fname = fname;
            this.Lname = lname;
            this.Price = price;
            this.IDStaff = idStaff;
        }

        public Receipt(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDContract = (int)row["idContract"];
            this.Dsign = (DateTime)row["dsign"];
            this.Fname = row["fname"].ToString();
            this.Lname = row["lname"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.IDStaff = (int)row["idStaff"];
        }

        private int iD;
        private int iDContract;
        private DateTime dsign;
        private string fname;
        private string lname;
        private float price;
        private int iDStaff;

        
        public int ID { get => iD; set => iD = value; }
        public int IDContract { get => iDContract; set => iDContract = value; }
        public DateTime Dsign { get => dsign; set => dsign = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public float Price { get => price; set => price = value; }
        public int IDStaff { get => iDStaff; set => iDStaff = value; }
    }
}
