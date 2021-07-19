using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class ContractRent
    {
        public ContractRent()
        {

        }

        public ContractRent(int id, int idStaff, int idCustomer, int idCar, DateTime timeIn, DateTime timeOut, int cost)
        {
            this.ID = id;
            this.IDStaff = idStaff;
            this.IDCustomer = idCustomer;
            this.IDCar = idCar;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
            this.Cost = cost;
        }

        public ContractRent(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDStaff = (int)row["idStaff"];
            this.IDCustomer = (int)row["idCustomer"];
            this.IDCar = (int)row["idCar"];
            this.TimeIn = (DateTime)row["timeIn"];
            this.TimeOut = (DateTime)row["timeOut"];
            this.Cost = (int)row["cost"];
        }

        private int iD;
        private int iDStaff;
        private int iDCustomer;
        private int iDCar;
        private DateTime timeIn;
        private DateTime timeOut;
        private int cost;

        public int ID { get { return iD; } set { iD = value; } }
        public int IDStaff { get { return iDStaff; } set { iDStaff = value; } }
        public int IDCustomer { get { return iDCustomer; } set { iDCustomer = value; } }
        public int IDCar { get { return iDCar; } set { iDCar = value; } }
        public DateTime TimeIn { get { return timeIn; } set { timeIn = value; } }
        public DateTime TimeOut { get { return timeOut; } set { timeOut = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
    }
}
