using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntity;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace CapaDeDatos
{
    public class DbUser
    {
        private readonly Connetion conn;

        public DbUser()
        {
            conn = new Connetion();
        }

        public void InsertUser(User User)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertUser", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NameUse", User.NameUser);
                cmd.Parameters.AddWithValue("@Password", User.Password);
                cmd.Parameters.AddWithValue("@idEmployee", User.IdEmployee);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("El nombre de usuario, ya existe");
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public void UpdateUser(User User)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateUser", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", User.Id);
                cmd.Parameters.AddWithValue("@NameUse", User.NameUser);
                cmd.Parameters.AddWithValue("@Password", User.Password);
                cmd.Parameters.AddWithValue("@idEmployee", User.IdEmployee); 
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("El nombre de usuario, ya existe");
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteUser", conn.OpenConnection());
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

        public List<User> SelectUser()
        {
            List<User> listUser = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectUser", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listUser.Add(new User() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            NameUser = dr["name_user"].ToString(),
                            CodeEmployee = dr["code_employee"].ToString(),
                            Password = dr["password_user"].ToString()
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

            return listUser;
        }

        public List<User> SearchUser(string user)
        {
            List<User> listUser = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SearchUser", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", user);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listUser.Add(new User()
                        {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            IdEmployee = Convert.ToInt32(dr["id_employee"].ToString()),
                            NameUser = dr["name_user"].ToString(),
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

            return listUser;
        }


    }
}
