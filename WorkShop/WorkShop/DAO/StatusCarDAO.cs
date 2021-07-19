using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DAO
{
    public class StatusCarDAO
    {
        private static StatusCarDAO instance;

        public static StatusCarDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StatusCarDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private StatusCarDAO() { }
    }
}
