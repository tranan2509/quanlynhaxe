using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class Contract
    {
        public Contract(int id, float price, int idCustomer, int idStaff, int idCar, string typeParking, int valueParking, DateTime timeIn, DateTime? timeOut = null )
        {
            this.ID = id;
            this.Price = price;
            this.IDCustomer = idCustomer;
            this.IDStaff = idStaff;
            this.IDCar = idCar;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
            this.TypeParking = typeParking;
            this.ValueParking = valueParking;
        }
        public Contract(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.IDCustomer = (int)row["idCustomer"];
            this.IDStaff = (int)row["idStaff"];
            this.IDCar = (int)row["idCar"];
            this.TimeIn = (DateTime)row["timeIn"];
            this.TimeOut = (DateTime?)row["timeOut"];
            this.TypeParking = row["typeParking"].ToString();
            this.ValueParking = (int)row["valueParking"];
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private DateTime timeIn;

        public DateTime TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }
        private DateTime? timeOut;

        public DateTime? TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int iDCustomer;

        public int IDCustomer
        {
            get { return iDCustomer; }
            set { iDCustomer = value; }
        }
        private int iDStaff;

        public int IDStaff
        {
            get { return iDStaff; }
            set { iDStaff = value; }
        }
        private int iDCar;

        public int IDCar
        {
            get { return iDCar; }
            set { iDCar = value; }
        }

        public string TypeParking { get { return typeParking; } set { typeParking = value; } }

        public int ValueParking { get { return valueParking; } set { valueParking = value; } }

        private string typeParking;

        private int valueParking;
    }
}
