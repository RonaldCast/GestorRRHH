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
    public class DbPermission
    {
        private readonly Connetion conn;

        public DbPermission()
        {
            conn = new Connetion();
        }

        public void InsertPermission(Permission permission)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertPermission", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmployee", permission.IdEmployee);
                cmd.Parameters.AddWithValue("@DateSince", permission.DateSince);
                cmd.Parameters.AddWithValue("@DateUntil", permission.DateUntil);
                cmd.Parameters.AddWithValue("@Comment", permission.Comment);
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

        public void UpdatePermission(Permission permission)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdatePermission", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", permission.Id);
                cmd.Parameters.AddWithValue("@CodeEmployee", permission.IdEmployee);
                cmd.Parameters.AddWithValue("@DateSince", permission.DateSince);
                cmd.Parameters.AddWithValue("@DateUntil", permission.DateUntil);
                cmd.Parameters.AddWithValue("@Comment", permission.Comment);
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

        public void DeletePermission(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DeletePermission", conn.OpenConnection());
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

        public List<Permission> SelectPermission()
        {
            List<Permission> listpermission = new List<Permission>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectPermission", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listpermission.Add(new Permission() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            DateSince = Convert.ToDateTime(dr["date_since_hour"].ToString()),
                            DateUntil = Convert.ToDateTime(dr["date_until_hour"].ToString()),
                            Comment = dr["commentary"].ToString(),
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

            return listpermission;
        }

    }
}
