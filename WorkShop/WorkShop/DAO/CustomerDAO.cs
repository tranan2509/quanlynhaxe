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
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CustomerDAO() { }

        public bool CheckInByQRCode(string qrCode)
        {
            int result = (int)DataProvider.Instance.ExecuteScalar("EXEC USP_CheckInByQRCode @qrCode", new object[] { qrCode });
            return result == 0;
        }

        public bool CheckInParking(string qrCode, int idStaff, string typeCar, float price, string typeParking, int valueParking, Image imageFrontIn, Image imageBackIn)
        {
            MemoryStream picFrontIn = new MemoryStream();
            imageFrontIn.Save(picFrontIn, imageFrontIn.RawFormat);
            MemoryStream picBackIn = new MemoryStream();
            imageBackIn.Save(picBackIn, imageBackIn.RawFormat);
            string query = "EXEC USP_CheckInParking @qrCode , @idStaff , @typeCar , @price , @typeParking , @valueParking , @imageFrontIn , @imageBackIn";
            object[] obj = new object[] { qrCode, idStaff, typeCar, price, typeParking, valueParking, picFrontIn.ToArray(), picBackIn.ToArray() };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool CheckOutParking(string qrCode, int idStaff, float price, Image imageFrontOut, Image imageBackOut)
        {
            MemoryStream picFrontOut = new MemoryStream();
            if (imageFrontOut != null)
            {
                imageFrontOut.Save(picFrontOut, imageFrontOut.RawFormat);
            }
            else picFrontOut = null;
            MemoryStream picBackOut = new MemoryStream();
            if (imageBackOut != null)
                imageBackOut.Save(picBackOut, imageBackOut.RawFormat);
            string query = "EXEC USP_CheckOutParking @qrCode , @idStaff , @price , @imageFrontOut , @imageBackOut";
            object[] obj = new object[] { qrCode, idStaff, price, picFrontOut.ToArray(), picBackOut.ToArray() };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public Customer GetCustomerByID(int idCustomer)
        {
            Customer customer = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Customer WHERE id = @idCustomer", new object[] { idCustomer });
            if (data.Rows.Count > 0)
                customer = new Customer(data.Rows[0]);
            return customer;
        }

        public bool InsertCustomer(string fname, string lname, string identityNumber, string gender, DateTime bdate, string address, string phone, Image photo, int typeCustomer, string qrCode)
        {
            MemoryStream pic = new MemoryStream();
            photo.Save(pic, photo.RawFormat);
            string query = "EXEC USP_InsertCustomer @fname , @lname , @identityNumber , @gender , @bdate , @address , @phone , @photo , @typeCustomer , @qrCode";
            object[] obj = new object[] { fname, lname, identityNumber, gender, bdate, address, phone, pic.ToArray(), typeCustomer, qrCode };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool UpdateCustomer(int id, string fname, string lname, string identityNumber, string gender, DateTime bdate, string address, string phone, Image photo, int typeCustomer, string qrCode)
        {
            MemoryStream pic = new MemoryStream();
            photo.Save(pic, photo.RawFormat);
            string query = "EXEC USP_UpdateCustomer @id , @fname , @lname , @identityNumber , @gender , @bdate , @address , @phone , @photo , @typeCustomer , @qrCode";
            object[] obj = new object[] { id, fname, lname, identityNumber, gender, bdate, address, phone, pic.ToArray(), typeCustomer, qrCode };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

        public bool DeleteCustomerByID(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteCustomer @id", new object[] { id });
            return result > 0;
        }

        public int GetIDMax()
        {
            int result = (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Customer");
            return result;
        }
        
        public DataTable GetListCustomer()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListCustomer");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataTable SearchInfoCustomer(string keyWord)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchListCustomer @keyWord", new object[] { keyWord });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public bool IsExistCustomerByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Customer WHERE id = @id", new object[] { id });
            return data.Rows.Count > 0;
        }

        public bool IsExistQrCodeOfCustomer(string qrCode)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_IsExistByQRCodeOfCustomer @qrCode", new object[] { qrCode });
            return data.Rows.Count > 0;
        }
    }
}
