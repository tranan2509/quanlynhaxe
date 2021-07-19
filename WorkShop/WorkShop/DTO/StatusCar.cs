using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class StatusCar
    {
        public StatusCar()
        {

        }

        public StatusCar(int id, int idCar, int idOwner, int idRenter, int isOwner)
        {
            this.ID = id;
            this.IDCar = idCar;
            this.IDOwner = idOwner;
            this.IDRenter = idRenter;
            this.IsOwner = isOwner;
        }

        public StatusCar(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDCar = (int)row["idCar"];
            this.IDOwner = (int)row["idOwner"];
            this.IDRenter = (int)row["idRenter"];
            this.IsOwner = (int)row["isOwner"];    
        }

        private int iD;
        private int iDCar;
        private int iDOwner;
        private int iDRenter;
        private int isOwner;

        public int ID { get { return iD; } set { iD = value; } }
        public int IDCar { get { return iDCar; } set { iDCar = value; } }
        public int IDOwner { get { return iDOwner; } set { iDOwner = value; } }
        public int IDRenter { get { return iDRenter; } set { iDRenter = value; } }
        public int IsOwner { get { return isOwner; } set { isOwner = value; } }
    }
}
