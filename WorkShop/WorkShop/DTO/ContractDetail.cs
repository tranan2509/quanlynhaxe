using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class ContractDetail
    {
        public ContractDetail(int id, int idContract, int idWork, string detail)
        {
            this.ID = id;
            this.IDContract = idContract;
            this.IDWork = idWork;
            this.Detail = detail;
        }
        
        public ContractDetail(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDContract = (int)row["idContract"];
            this.IDWork = (int)row["idWork"];
            this.Detail = row["detail"].ToString();
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private int iDContract;

        public int IDContract
        {
            get { return iDContract; }
            set { iDContract = value; }
        }
        private int iDWork;

        public int IDWork
        {
            get { return iDWork; }
            set { iDWork = value; }
        }
        private string detail;

        public string Detail
        {
            get { return detail; }
            set { detail = value; }
        }

    }
}
