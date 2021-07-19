using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class Staff
    {
        public Staff(int id, string fname, string lname, string identityNumber, string gender, DateTime bdate, 
            string address, string phone, int idPhoto, float salary, float bonus, int idSpeciality, string pass)
        {
            this.ID = id;
            this.Fname = fname;
            this.Lname = lname;
            this.IdentityNumber = identityNumber;
            this.Gender = gender;
            this.Bdate = bdate;
            this.Address = address;
            this.Phone = phone;
            this.IDPhoto = idPhoto;
            this.Salary = salary;
            this.Bonus = bonus;
            this.IDSpeciality = idSpeciality;
            this.Pass = pass;
        }

        public Staff(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Fname = row["fname"].ToString() ;
            this.Lname = row["lname"].ToString();
            this.IdentityNumber = row["identityNumber"].ToString();
            this.Gender = row["gender"].ToString();
            this.Bdate = (DateTime)row["bdate"];
            this.Address = row["address"].ToString();
            this.Phone = row["phone"].ToString();
            this.IDPhoto = (int)row["idPhoto"];
            this.Salary = (float)Convert.ToDouble(row["salary"].ToString());
            this.Bonus = (float)Convert.ToDouble(row["bonus"].ToString());
            this.IDSpeciality = (int)row["idSpeciality"];
            this.Pass = row["pass"].ToString();
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
        private DateTime bdate;

        public DateTime Bdate
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
        private float salary;

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        private float bonus;

        public float Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        private int iDSpeciality;

        public int IDSpeciality
        {
            get { return iDSpeciality; }
            set { iDSpeciality = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

    }
}
