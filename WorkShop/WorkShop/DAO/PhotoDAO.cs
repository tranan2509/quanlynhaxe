using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class PhotoDAO
    {
        private static PhotoDAO instance;

        public static PhotoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhotoDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private PhotoDAO() { }

        public Photo GetPhotoByID(int id)
        {
            Photo photo = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Photo WHERE id = @id", new object[] { id });
            if (data.Rows.Count > 0)
                photo = new Photo(data.Rows[0]);
            return photo;
        }
    }
}
