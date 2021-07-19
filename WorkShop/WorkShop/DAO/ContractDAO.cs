using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class ContractDAO
    {
        private static ContractDAO instance;

        public static ContractDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ContractDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ContractDAO() { }

        public Contract GetContractByQRCode(string qrCode)
        {
            Contract contract = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetContractByQRCode @qrCode", new object[] { qrCode });
            if (data.Rows.Count > 0)
                contract = new Contract(data.Rows[0]);
            return contract;
        }

        public Contract GetContractByIDCar(int idCar)
        {
            Contract contract = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Contract WHERE idCar = @idCar", new object[] { idCar });
            if (data.Rows.Count > 0)
                contract = new Contract(data.Rows[0]);
            return contract;
        }

        public bool UpdatePriceByID(int id, double price)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdatePriceContractAndMoneyCustomer @idContract , @price", new object[] { id, price });
            return result > 0;
        }

        public bool UpdateValeParkingByID(int id, int value)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Contract SET valueParking = @valueParking WHERE id = @id", new object[] { value, id });
            return result > 0;
        }

        public DataTable GetListContract()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListContract");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable SearchInfoContract(string keyWord)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchListContract @keyWord", new object[] { keyWord });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable SearchInfoContractByTimeIn(DateTime timeInStart, DateTime timeInEnd)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchListContractByTimeIn @timeInStart , @timeInEnd", new object[] { timeInStart, timeInEnd });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable SearchInfoContractByTimeOut(DateTime timeOutStart, DateTime timeOutEnd)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchListContractByTimeOut @timeOutStart , @timeOutEnd", new object[] { timeOutStart, timeOutEnd });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetTotalRevenueByDay(DateTime dateIn, DateTime dateOut)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_TotalRevenueByDay @dateIn , @dateOut", new object[] { dateIn, dateOut });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
      
    }
}
