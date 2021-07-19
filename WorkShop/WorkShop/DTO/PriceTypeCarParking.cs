using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class PriceTypeCarParking
    {
        public PriceTypeCarParking(int id, string typeCar, float price)
        {
            this.ID = id;
            this.TypeCar = typeCar;
            this.Price = price;
        }

        public PriceTypeCarParking(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TypeCar = row["typeCar"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private int iD;
        private string typeCar;
        private float price;

        public int ID { get { return iD; } set { iD = value; } }
        public string TypeCar { get { return typeCar; } set { typeCar = value; } }
        public float Price { get { return price; } set { price = value; } }
    }
}
