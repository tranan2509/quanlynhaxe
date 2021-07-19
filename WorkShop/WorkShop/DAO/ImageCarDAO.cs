using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class ImageCarDAO
    {
        private static ImageCarDAO instance;

        public static ImageCarDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImageCarDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ImageCarDAO() { }
        
        public ImageCar GetImageCarCheckInByIdCar(int idCar)
        {
            ImageCar imageCar = null;
            string query = "SELECT * FROM ImageCar WHERE idCar = @idCar AND status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idCar });
            if (data.Rows.Count > 0)
               imageCar = new ImageCar(data.Rows[0]);
            return imageCar; 
        }

        public bool InsertCheckInImageCar(string idCar, Image frontCheckIn, Image backCheckIn)
        {
            string query = "INSERT INTO ImageCar (idCar, frontChecIn, backCheckIn) VALUES ( @idCar , @frontCheckIn , @backCheckIn )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCar, frontCheckIn, backCheckIn });
            return result > 0;
        }

        public bool InsertCheckOutImageCarByIdCar(string idCar, Image frontCheckOut, Image backCheckOut)
        {
            string query = "UPDATE ImageCar SET frontCheckOut = @frontCheckOut , backCheckOut = @backCheckOut WHERE , status = 1 idCar = @idCar AND status = 0";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCar, frontCheckOut, backCheckOut });
            return result > 0;
        }


    }
}
