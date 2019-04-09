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
    public class DbDepartament
    {
        private readonly Connetion conn;

        public DbDepartament()
        {
            conn = new Connetion();
        }

        public void InsertDepartament(Departament departament)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertDepartament", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeDepartament", departament.Code);
                cmd.Parameters.AddWithValue("@name", departament.Name);
                cmd.Parameters.AddWithValue("@id_employee", 
                    departament.Mandated == null ? System.Data.SqlTypes.SqlInt32.Null : departament.Mandated.Value);
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

        public void UpdateDepartament(Departament departament)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateDepartament", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",departament.Id);
                cmd.Parameters.AddWithValue("@codeDepartament", departament.Code);
                cmd.Parameters.AddWithValue("@name", departament.Name);
                cmd.Parameters.AddWithValue("@id_employee",
                      departament.Mandated == null ? System.Data.SqlTypes.SqlInt32.Null : departament.Mandated.Value);
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

        public void DeleteDepartament(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteDepartament", conn.OpenConnection());
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

        public List<Departament> SelectDepartament()
        {
            List<Departament> listDepartament = new List<Departament>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectDepartamentJoin", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        listDepartament.Add(new Departament() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            Code = dr["code_Departament"].ToString(),
                            Name = dr["name"].ToString(),
                            Mandated = dr["id_employee"].ToString() == "" ? 0 : Convert.ToInt32(dr["id_employee"].ToString()),
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

            return listDepartament;
        }


        public List<Departament> SearchDepartament(string departament)
        {
            List<Departament> listDepartament = new List<Departament>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectDepartamentJoin", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", departament);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listDepartament.Add(new Departament()
                        {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            Code = dr["code_Departament"].ToString(),
                            Name = dr["name"].ToString(),
                            Mandated = dr["id_employee"].ToString() == "" ? 0 : Convert.ToInt32(dr["id_employee"].ToString()),
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

            return listDepartament;
        }

        public Departament SelectDepartamentForID(int id)
        {
            Departament Departament = new Departament();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectDepartamentForId", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        Departament.Name = dr["name"].ToString();
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

            return Departament;
        }
    }
}
