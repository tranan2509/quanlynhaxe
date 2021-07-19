using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DAO
{
    public class WorkDAO
    {
        private static WorkDAO instance;

        public static WorkDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WorkDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private WorkDAO() { }
    }
}
