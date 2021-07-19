using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop.DTO;

namespace WorkShop.DAO
{
    public class TypeCustomerDAO
    {
        private static TypeCustomerDAO instance;

        public static TypeCustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TypeCustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private TypeCustomerDAO() { }

        public List<TypeCustomer> GetListTypeCustomer()
        {
            List<TypeCustomer> listTypeCustomer = new List<TypeCustomer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TypeCustomer");
            foreach (DataRow item in data.Rows)
            {
                TypeCustomer typeCustomer = new TypeCustomer(item);
                listTypeCustomer.Add(typeCustomer);
            }
            return listTypeCustomer;
        }
    }
}
