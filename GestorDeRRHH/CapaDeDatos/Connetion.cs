using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
   public class Connetion
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-28TN5NO\SQLEXPRESS;Initial Catalog=GestorRRHH;Integrated Security=True");

        public SqlConnection OpenConnection()
        {
            conn.Open();

            return conn;
        }

        public void CloseConnection()
        {
            conn.Close();
        }
    }
}
