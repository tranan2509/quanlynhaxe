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
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private StaffDAO() { }

        public bool LoginAccountManager(int userName, string passWord)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LoginAccountManager @userName , @passWord", new object[] { userName, passWord });
            return data.Rows.Count > 0;
        }
        public bool LoginAccountStaff(int userName, string passWord)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LoginAccountStaff @userName , @passWord", new object[] { userName, passWord });
            return data.Rows.Count > 0;
        }
        public Photo GetPhotoByID(int id)
        {
            Photo photo = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Photo WHERE id = @id", new object[] { id });
            if (data.Rows.Count > 0)
                photo = new Photo(data.Rows[0]);
            return photo;
        }

        public Staff GetStaffByID(int id)
        {
            Staff staff = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Staff WHERE id = @id", new object[] { id });
            if (data.Rows.Count > 0)
                staff = new Staff(data.Rows[0]);
            return staff;
        }
        public int GetIDMax()
        {
            int result = (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Staff");
            return result;
        }
        public bool InsertStaff(string fname, string lname, string identityNumber, string gender, DateTime bdate, string address, string phone, Image photo, int idSpeciality, string passWord, float salary, float bonus)
        {
            MemoryStream pic = new MemoryStream();
            photo.Save(pic, photo.RawFormat);
            string query = "EXEC USP_InsertStaff @fname , @lname , @identityNumber , @gender , @bdate , @address , @phone , @photo , @idSpeciality , @passWord , @salary , @bonus";
            object[] obj = new object[] { fname, lname, identityNumber, gender, bdate, address, phone, pic.ToArray(), idSpeciality, passWord, salary, bonus };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool UpdateStaff(int id, string fname, string lname, string identityNumber, string gender, DateTime bdate, string address, string phone, Image photo, int idSpeciality, string passWord, float salary, float bonus)
        {
            MemoryStream pic = new MemoryStream();
            photo.Save(pic, photo.RawFormat);
            string query = "EXEC USP_UpdateStaff @id , @fname , @lname , @identityNumber , @gender , @bdate , @address , @phone , @photo , @idSpeciality , @passWord , @salary , @bouns";
            object[] obj = new object[] { id, fname, lname, identityNumber, gender, bdate, address, phone, pic.ToArray(), idSpeciality, passWord, salary, bonus };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool DeleteStaffByID(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_DeleteStaff @id", new object[] { id });
            return result > 0;
        }

        public DataTable GetListStaff()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListStaff");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable SearchInfoStaff(string keyWord)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_SearchListStaff @keyWord", new object[] { keyWord });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public bool UpdateBonusByIDStaff(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE Staff SET bonus = bonus + 1000 WHERE id = @id", new object[] { id });
            return result > 0;
        }
    }
}
