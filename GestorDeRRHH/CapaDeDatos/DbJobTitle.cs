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
    public class DbJobTitle
    {
        private readonly Connetion conn;

        public DbJobTitle()
        {
            conn = new Connetion();
        }

        public void InsertJobTitle(JobTitle job)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertJobTitle", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codeJob", job.CodeJob);
                cmd.Parameters.AddWithValue("@JobTitle", job.Job);
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

        public void UpdateJobTitle(JobTitle job)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateJobTitle", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id",job.Id);
                cmd.Parameters.AddWithValue("@codeJob", job.CodeJob);
                cmd.Parameters.AddWithValue("@JobTitle", job.Job);
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

        public void DeleteJobTitle(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteJobTitle", conn.OpenConnection());
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

        public List<JobTitle> SelectJobTitle()
        {
            List<JobTitle> listJob = new List<JobTitle>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectJobTitle", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listJob.Add(new JobTitle() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            CodeJob = dr["code_jobTitle"].ToString(),
                            Job = dr["JobTitle"].ToString()
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

            return listJob;
        }


        public List<JobTitle> SearchJobTitle(string job)
        {
            List<JobTitle> listJob = new List<JobTitle>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SearchJobTitle", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Job", job);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listJob.Add(new JobTitle()
                        {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            CodeJob = dr["code_jobTitle"].ToString(),
                            Job = dr["JobTitle"].ToString()
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

            return listJob;
        }
    }
}
