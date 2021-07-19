using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DTO
{
    public class Work
    {
        public Work(int id, string content)
        {
            this.ID = id;
            this.Content = content;
        }

        public Work(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Content = row["content"].ToString();
        }
        private int iD;
        private string content;

        public int ID { get { return iD; } set { iD = value; } }
        public string Content { get { return content; } set { content = value; } }
    }
}
