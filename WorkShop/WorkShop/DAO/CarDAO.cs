using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class CarDAO
    {
        private static CarDAO instance;

        public static CarDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CarDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CarDAO() { }

        public List<Car> GetListCar()
        {
            List<Car> cars = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Car");
            foreach (DataRow item in data.Rows)
            {
                Car car = new Car(item);
                cars.Add(car);
            }
            return cars;
        }

        public int GetIDCarParkingByQRCode(string qrCode)
        {
            int result = -1;
            string temp = DataProvider.Instance.ExecuteScalar("EXEC USP_GetIDCarParking @qrCode", new object[] { qrCode }).ToString();
            if (temp != "")
                result = Convert.ToInt32(temp);
            return result;
        }
        public Car GetCarByID(int id)
        {
            Car car = null;
            string query = "SELECT * FROM Car WHERE id = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            car = new Car(data.Rows[0]);
            return car;
        }

        public bool InsertCar(int id, string licensePlates, string type = null, string color = null)
        {
            string query = "INSERT INTO Car (id, licensePlates, type, color) VALUES ( @id , @licensePlates , @type , @color)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, licensePlates, type, color });
            return result > 0;
        }

        public bool UpdateCar(int id, string licensePlates, string type = null, string color = null)
        {
            string query = "UPDATE Car SET licensePlates = @licensePlates , tpye = @type , color = @color WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, licensePlates, type, color });
            return result > 0;
        }

        public bool DeleteCarByID(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Car WHERE id = @id", new object[] { id });
            return result > 0;
        }

        public bool IsExistCarByID(int id)
        {
            string query = "SELECT * FROM Car WHERE id = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return data.Rows.Count > 0;
        }

        public Car GetCarParking(string qrCode)
        {
            Car car = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_UnCheckedGetCarByQrCode @qrCode", new object[] { qrCode });

            foreach (DataRow item in data.Rows)
            {
                car = new Car(item);
                return car;
            }

            return car;
        }

        public Car GetCarParked(int idCar)
        {
            Car car = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_CheckedGetCarByIdCar @idCar", new object[] { idCar });

            foreach (DataRow item in data.Rows)
            {
                car = new Car(item);
                return car;
            }

            return car;
        }

        public List<Car> getListCarUnChecked()
        {
            List<Car> lCar = new List<Car>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListCarUnChecked ");

            foreach (DataRow item in data.Rows)
            {
                Car carparking = new Car(item);

                lCar.Add(carparking);
            }

            return lCar;
        }
        
    }
}
