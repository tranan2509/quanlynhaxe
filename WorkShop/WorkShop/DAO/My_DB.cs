﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop.DAO
{
    public class My_DB
    {
        private static My_DB instance;
        public static My_DB Instance
        {
            get
            {
                if (instance == null)
                    instance = new My_DB();
                return instance;
            }
            private set { instance = value; }
        }

        private My_DB() { }

        private static string strconn = @"Data Source=DESKTOP-7ORN27A;Initial Catalog=WORKSHOP;Integrated Security=True";

        private SqlConnection con = new SqlConnection(strconn);

        public SqlConnection getConnection
        {
            get { return con; }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
