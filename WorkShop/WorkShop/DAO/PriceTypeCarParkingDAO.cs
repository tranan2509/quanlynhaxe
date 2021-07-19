using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class PriceTypeCarParkingDAO
    {
        private static PriceTypeCarParkingDAO instance;
        public static PriceTypeCarParkingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PriceTypeCarParkingDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private PriceTypeCarParkingDAO() { }

        public List<PriceTypeCarParking> GetListPriceTypeCarParking()
        {
            List<PriceTypeCarParking> listPrice = new List<PriceTypeCarParking>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PriceTypeCarParking");
            foreach (DataRow item in data.Rows)
            {
                PriceTypeCarParking price = new PriceTypeCarParking(item);
                listPrice.Add(price);
            }
            return listPrice;
        }
        
        public bool UpdateTypeCarParkingByID(int id, string typeCar, float price)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE PriceTypeCarParking SET typeCar = @typeCar , price = @price WHERE id = @id", new object[] { typeCar, price, id });
            return result > 0;
        }

        public double GetPriceByID(int id)
        {
            double price = 0;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PriceTypeCarParking WHERE id = @id", new object[] { id });
            if (data.Rows.Count > 0)
                return new PriceTypeCarParking(data.Rows[0]).Price;
            return price;
        }
    }
}
