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
    public class DbVacation
    {
        private readonly Connetion conn;

        public DbVacation()
        {
            conn = new Connetion();
        }

        public void InsertVacation(Vacation Vacation)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertVacation", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodeEmployee", Vacation.IdEmployee);
                cmd.Parameters.AddWithValue("@DateSince", Vacation.DateSince);
                cmd.Parameters.AddWithValue("@DateUntil", Vacation.DateUntil);
                cmd.Parameters.AddWithValue("@Comment", Vacation.Comment);
                cmd.Parameters.AddWithValue("@year", Vacation.Year);
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

        public void UpdateVacation(Vacation Vacation)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateVacation", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Vacation.Id);
                cmd.Parameters.AddWithValue("@CodeEmployee", Vacation.IdEmployee);
                cmd.Parameters.AddWithValue("@DateSince", Vacation.DateSince);
                cmd.Parameters.AddWithValue("@DateUntil", Vacation.DateUntil);
                cmd.Parameters.AddWithValue("@Comment", Vacation.Comment);
                cmd.Parameters.AddWithValue("@Year", Vacation.Year);
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

        public List<Vacation> SelectVacation()
        {
            List<Vacation> listVacation = new List<Vacation>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectVacation", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listVacation.Add(new Vacation() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            DateSince = Convert.ToDateTime(dr["date_since"].ToString()),
                            DateUntil = Convert.ToDateTime(dr["date_until"].ToString()),
                            Comment = dr["commentary"].ToString(),
                            Year = dr["year_vacation"].ToString(),
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

            return listVacation;
        }

        public List<Vacation> SearchVacation(string Vacation)
        {
            List<Vacation> listVacation = new List<Vacation>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SearchVacation", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Vacation);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listVacation.Add(new Vacation()
                        {
                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            DateSince = Convert.ToDateTime(dr["date_since"].ToString()),
                            DateUntil = Convert.ToDateTime(dr["date_until"].ToString()),
                            Comment = dr["commentary"].ToString(),
                            Year = dr["year_vacation"].ToString(),
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

            return listVacation;
        }

    }
}
