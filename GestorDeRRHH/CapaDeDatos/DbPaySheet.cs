using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntity;
//using System.Windows.Forms;

namespace CapaDeDatos
{
    public class DbPaySheet
    {
        private readonly Connetion conn;

        public DbPaySheet()
        {
            conn = new Connetion();
        }

        public void InsertPaySheet(PaySheet PaySheet)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertPaySheet", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", PaySheet.Year);
                cmd.Parameters.AddWithValue("@Month", PaySheet.Month);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

      
        public List<PaySheet> SearchPaySheet(string PaySheet)
        {
            List<PaySheet> listPaySheet = new List<PaySheet>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectPaySheetForMonth", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Month", PaySheet);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listPaySheet.Add(new PaySheet()
                        {
                            Id = Convert.ToInt32(dr["id"].ToString()),
                            Amount = Convert.ToDecimal(dr["amount_pay"].ToString()),
                            Year = dr["year_pay"].ToString(),
                            Month = dr["month_pay"].ToString()

                        });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.CloseConnection();
            }

            return listPaySheet;
        }

    }
}
