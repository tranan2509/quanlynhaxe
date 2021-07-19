using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class Car
    {
        public Car(int id, string licensePlates, string type, string color)
        {
            this.ID = id;
            this.LicensePlates = licensePlates;
            this.Type = type;
            this.Color = color;
        }

        public Car(DataRow row)
        {
            this.ID = (int)row["id"];
            this.LicensePlates = row["licensePlates"].ToString();
            this.Type = row["type"].ToString();
            this.Color = row["color"].ToString();
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string licensePlates;

        public string LicensePlates
        {
            get { return licensePlates; }
            set { licensePlates = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
