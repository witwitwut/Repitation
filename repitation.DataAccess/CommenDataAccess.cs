﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace repitation.DataAccess
{
    public class CommenDataAccess
    {
        private string conString;

        public CommenDataAccess(string conString)
        {
            ConString = conString;
        }

        public string ConString
        {
            get { return conString; }
            private set { conString = value; }
        }

        public int ExecuteNonQuery(string q)
        {
            int rowsaffected;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand com = new SqlCommand(q, con))
                {
                    con.Open();

                    rowsaffected = com.ExecuteNonQuery();                                      
                }
            }
            return rowsaffected;
        }

        public DataSet ExecuteQuery(string q)
        {
            DataSet info;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand com = new SqlCommand(q, con))
                {
                    con.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(com);

                    da.Fill(ds);

                    info = ds;
                }
            }
            return info;
        }
    }
}
