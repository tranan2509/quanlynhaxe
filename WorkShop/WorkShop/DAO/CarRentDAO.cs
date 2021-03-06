using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;
using System.IO;
using System.Drawing;

namespace WorkShop.DAO
{
    public class CarRentDAO
    {
        private static CarRentDAO instance;

        public static CarRentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CarRentDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CarRentDAO() { }


        public List<CarRent> GetListCarRentByIDCustomer(int idCustomer)
        {
            List<CarRent> lCarRent = new List<CarRent>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCarRentByIDCustomer @idCustomer", new object[] { idCustomer });
            foreach (DataRow item in data.Rows)
            {
                string status = CheckRentalCompanyOrCustomer(item, idCustomer);
                CarRent carRent = new CarRent(item, status);
                lCarRent.Add(carRent);
            }
            return lCarRent;
        }

        string CheckRentalCompanyOrCustomer(DataRow row, int idCustomer)
        {
            int idOwner = (int)row["idOwner"];
            int idRenter = (int)row["idRenter"];
            int isOwner = (int)row["isOwner"];
            if (idOwner == idCustomer && isOwner == 0)
            {
                return "Get Car";
            }
            if (idRenter == idCustomer && isOwner == 0)
                return "Return Car";
            return "";
        }

       
        #region CarRent

        public bool InsertCarRentOfCustomer(int idCustomer, string licensePlates, string type, string color, Image frontCar, Image backCar)
        {
            MemoryStream picFront = new MemoryStream();
            frontCar.Save(picFront, frontCar.RawFormat);
            MemoryStream picBack = new MemoryStream();
            backCar.Save(picBack, backCar.RawFormat);
            string query = "USP_InsertCarRentOfCustomer @idOwner , @licensePlates , @type , @color , @frontCar , @backCar";
            object[] obj = new object[] { idCustomer, licensePlates, type, color, picFront.ToArray(), picBack.ToArray() };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool InsertCarRentOfCompany(string licensePlates, string type, string color, Image frontCar, Image backCar)
        {
            MemoryStream picFront = new MemoryStream();
            frontCar.Save(picFront, frontCar.RawFormat);
            MemoryStream picBack = new MemoryStream();
            backCar.Save(picBack, backCar.RawFormat);
            string query = "USP_InsertCarRentOfCompany @licensePlates , @type , @color , @frontCar , @backCar";
            object[] obj = new object[] { licensePlates, type, color, picFront.ToArray(), picBack.ToArray() };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public DataTable GetAllDataCarRentAtCompany()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAllDataCarRentAtCompany");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetAllDataCarRentCustomerCanRent(int idCustomer)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAllDataCarRentCustomerCanRent @idCustomer", new object[] { idCustomer });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable SearchCarRentAtCompanyByTypeCar(string typeCar)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchCarRentAtCompanyByTypeCar @typeCar", new object[] { typeCar });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable SearchCarRentAtCompanyByColor(string color)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchCarRentAtCompanyByColor @color", new object[] { color });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable SearchCarRentAtCompanyByTypeCarAndColor(string typeCar, string color)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchCarRentAtCompanyByTypeCarAndColor @typeCar , @color", new object[] { typeCar, color });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public bool IsExistCarRentByLicensePlates(string licensePlates)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_IsExistCarRentByLicensePlates @licensePlates", new object[] { licensePlates });
            return data.Rows.Count > 0;
        }

        public DataTable GetListOfVehiclesUnderManagement()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_ListOfVehiclesUnderManagement");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetListOfCarCompanies()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_ListOfCarCompanies");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable GetVehicleListingsCanRented()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_VehicleListingsCanRented");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetListOfVehiclesBeingRented()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_ListOfVehiclesBeingRented");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetListOfRentedCars()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_ListOfRentedCars");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable SearchDeleteCarOfCompanyByIDCar(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchDeleteCarOfCompanyByIDCar @idCar", new object[] { id });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public bool DeleteCarOfCompanyByIDCar(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteCarOfCompanyByIDCar @idCar", new object[] { id });
            return result > 0;
        }
        #endregion
    }
}
