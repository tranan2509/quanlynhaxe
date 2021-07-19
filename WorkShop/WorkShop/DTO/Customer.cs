using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class Customer
    {

        public Customer(int id, string qrCode, int typeCustomer = 0, float totalMoney = 0, string fname = null, string lname = null,
            string identityNumber = null, string gender = null, DateTime? bdate = null, string address = null, string phone = null, int idPhoto = -1)
        {
            this.ID = id;
            this.QrCode = qrCode;
            this.TypeCustomer = typeCustomer;
            this.TotalMoney = totalMoney;
            this.Fname = fname;
            this.Lname = lname;
            this.IdentityNumber = identityNumber;
            this.Gender = gender;
            this.Bdate = bdate;
            this.Address = address;
            this.Phone = phone;
            this.IDPhoto = idPhoto;
        }

        public Customer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.QrCode = row["qrCode"].ToString();
            this.TypeCustomer = (int)row["typeCustomer"];
            this.TotalMoney = (float)Convert.ToDouble(row["totalMoney"].ToString());
            this.Fname = row["fname"].ToString();
            this.Lname = row["lname"].ToString();
            this.IdentityNumber = row["identityNumber"].ToString();
            this.Gender = row["gender"].ToString();
            if (row["bdate"].ToString() != "")
                this.Bdate = (DateTime?)row["bdate"];
            else this.Bdate = null;
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            if (row["idPhoto"].ToString() != "")
                this.IDPhoto = (int)row["idPhoto"];
            else this.IDPhoto = -1;
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        private string identityNumber;

        public string IdentityNumber
        {
            get { return identityNumber; }
            set { identityNumber = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private DateTime? bdate;

        public DateTime? Bdate
        {
            get { return bdate; }
            set { bdate = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private int iDPhoto;

        public int IDPhoto
        {
            get { return iDPhoto; }
            set { iDPhoto = value; }
        }
        private int typeCustomer;

        public int TypeCustomer
        {
            get { return typeCustomer; }
            set { typeCustomer = value; }
        }
        private float totalMoney;

        public float TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }
        private string qrCode;

        public string QrCode
        {
            get { return qrCode; }
            set { qrCode = value; }
        }
    }
}
