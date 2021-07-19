using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DAO
{
    public class ContractDetailDAO
    {
        private static ContractDetailDAO instance;

        public static ContractDetailDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ContractDetailDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ContractDetailDAO() { }
    }
}
