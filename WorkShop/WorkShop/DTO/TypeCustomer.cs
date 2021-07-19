using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class TypeCustomer
    {
        public TypeCustomer(int id, string name, float discount)
        {
            this.ID = id;
            this.Name = name;
            this.Discount = discount;
        }

        public TypeCustomer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Discount = (float)Convert.ToDouble(row["discount"].ToString());
        }

        private int iD;
        private string name;
        private float discount;

        public int ID { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public float Discount { get { return discount; } set { discount = value; } }
    }
}
