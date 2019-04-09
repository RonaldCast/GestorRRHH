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
    public class DbEmployeeExist
    {
        private readonly Connetion conn;

        public DbEmployeeExist()
        {
            conn = new Connetion();
        }

        public void InsertEmployeeExist(EmployeeExist EmployeeExist)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertEmployeeExist", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmployee", EmployeeExist.IdEmployee);
                cmd.Parameters.AddWithValue("@DateExist", EmployeeExist.DateExist);
                cmd.Parameters.AddWithValue("@TypeExist", EmployeeExist.TypeExist);
                cmd.Parameters.AddWithValue("@Reason", EmployeeExist.Reason);
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

        public void UpdateEmployeeExist(EmployeeExist EmployeeExist)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateEmployeeExist", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", EmployeeExist.Id);
                cmd.Parameters.AddWithValue("@CodeEmployee", EmployeeExist.IdEmployee);
                cmd.Parameters.AddWithValue("@DateExist", EmployeeExist.DateExist);
                cmd.Parameters.AddWithValue("@TypeExist", EmployeeExist.TypeExist);
                cmd.Parameters.AddWithValue("@Reason", EmployeeExist.Reason);
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

        public List<EmployeeExist> SelectEmployeeExist()
        {
            List<EmployeeExist> listEmployeeExist = new List<EmployeeExist>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectEmployeeExist", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listEmployeeExist.Add(new EmployeeExist() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            DateExist = Convert.ToDateTime(dr["date_exist"].ToString()),
                            Reason = dr["reason"].ToString(),
                            TypeExist = dr["type_exist"].ToString(),
                            CodeEmployee = dr["code_employee"].ToString()
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

            return listEmployeeExist;
        }

        public List<EmployeeExist> SearchEmployeeExist(string month)
        {
            List<EmployeeExist> listEmployeeExist = new List<EmployeeExist>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SearchEmployeeExist", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Month", month);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listEmployeeExist.Add(new EmployeeExist()
                        {
                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            DateExist = Convert.ToDateTime(dr["date_exist"].ToString()),
                            Reason = dr["reason"].ToString(),
                            TypeExist = dr["type_exist"].ToString(),
                            CodeEmployee = dr["code_employee"].ToString()
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

            return listEmployeeExist;
        }

    }
}
