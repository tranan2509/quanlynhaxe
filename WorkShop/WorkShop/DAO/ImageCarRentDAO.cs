using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DAO
{
    public class ImageCarRentDAO
    {
        private static ImageCarRentDAO instance;

        public static ImageCarRentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ImageCarRentDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ImageCarRentDAO() { }

    }
}
