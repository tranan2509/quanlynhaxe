using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DAO
{
    public class ReceiptDAO
    {
        private static ReceiptDAO instance;

        public static ReceiptDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReceiptDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ReceiptDAO() { }
    }
}
