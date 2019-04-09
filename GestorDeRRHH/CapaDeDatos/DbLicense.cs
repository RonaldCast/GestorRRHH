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
    public class DbLicense
    {
        private readonly Connetion conn;

        public DbLicense()
        {
            conn = new Connetion();
        }

        public void InsertLicense(Licenses License)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertLicense", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmployee", License.IdEmployee);
                cmd.Parameters.AddWithValue("@DateSince", License.DateSince);
                cmd.Parameters.AddWithValue("@DateUntil", License.DateUntil);
                cmd.Parameters.AddWithValue("@Comment", License.Comment);
                cmd.Parameters.AddWithValue("@Reason", License.Reason);
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

        public void UpdateLicense(Licenses License)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateLicense", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", License.Id);
                cmd.Parameters.AddWithValue("@CodeEmployee", License.IdEmployee);
                cmd.Parameters.AddWithValue("@DateSince", License.DateSince);
                cmd.Parameters.AddWithValue("@DateUntil", License.DateUntil);
                cmd.Parameters.AddWithValue("@Comment", License.Comment);
                cmd.Parameters.AddWithValue("@Reason", License.Reason);

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

        public void DeleteLicense(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteLicense", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
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

        public List<Licenses> SelectLicense()
        {
            List<Licenses> listLicense = new List<Licenses>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectLicense", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listLicense.Add(new Licenses() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            DateSince = Convert.ToDateTime(dr["date_since"].ToString()),
                            DateUntil = Convert.ToDateTime(dr["date_until"].ToString()),
                            Comment = dr["commentary"].ToString(),
                            CodeEmployee = dr["code_employee"].ToString(),
                            Reason = dr["reason"].ToString()
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

            return listLicense;
        }

    }
}
