using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop.DAO
{
    public class ContractRentDAO
    {
        private static ContractRentDAO instance;

        public static ContractRentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ContractRentDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ContractRentDAO() { }

        public bool CustomerRentCarByIDCar(int idCustomer, int idCar)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_CustomerRentCarByIDCar @idRenter , @idCar", new object[] { idCustomer, idCar });
            return result > 0;
        }

        public bool InsertContractCarRent(int idStaff, int idCustomer, int idCar, DateTime timeIn, DateTime timeOut, int cost)
        {
            string query = "INSERT INTO ContractRent (idStaff, idCustomer, idCar, timeIn, timeOut, cost) VALUES ( @idStaff , @idCustomer , @idCar , @timeIn , @timeOut , @cost )";
            object[] obj = new object[] { idStaff, idCustomer, idCar, timeIn, timeOut, cost };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public DataTable GetStatusCarByIDCustomerAndIDCar(int idCustomer, int idCar)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetStatusCarByIDCustomerAndIDCar @idCustomer , @idCar", new object[] { idCustomer, idCar });
            if (data.Rows.Count > 0)
            {
                return data;
            }
            return null;
        }

        public bool CustomerGetCar(int idCustomer, int idCar)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_CustomerGetCar @idCustomer , @idCar", new object[] { idCustomer, idCar });
            return result > 0;
        }

        public bool CustomerReturnCar(int idCustomer, int idCar)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_CustomerReturnCar @idCustomer , @idCar", new object[] { idCustomer, idCar });
            return result > 0;
        }
    }
}
