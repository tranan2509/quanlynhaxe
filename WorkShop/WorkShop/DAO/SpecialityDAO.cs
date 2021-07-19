using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class SpecialityDAO
    {
        private static SpecialityDAO instance;

        public static SpecialityDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SpecialityDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private SpecialityDAO() { }

        public List<Speciality> GetListSpeciality()
        {
            List<Speciality> listSpeciality = new List<Speciality>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Speciality");
            foreach (DataRow item in data.Rows)
            {
                Speciality speciality = new Speciality(item);
                listSpeciality.Add(speciality);
            }
            return listSpeciality;
        }
    }
}
