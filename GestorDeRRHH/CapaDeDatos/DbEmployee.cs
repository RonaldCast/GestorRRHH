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
    public class DbEmployee
    {
        private readonly Connetion conn;

        public DbEmployee()
        {
            conn = new Connetion();
        }

        public void InsertEmployee(Employee Employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertEmployee", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Employee.Name);
                cmd.Parameters.AddWithValue("@codeDEmployee", Employee.Code);
                cmd.Parameters.AddWithValue("@LastName", Employee.LastName);
                cmd.Parameters.AddWithValue("@Phone", Employee.Phone);
                cmd.Parameters.AddWithValue("@DateEntry", Employee.DateEntry);
                cmd.Parameters.AddWithValue("@Salary", Employee.Salary);
                cmd.Parameters.AddWithValue("@StatusEmployee", "Activos");
                cmd.Parameters.AddWithValue("@IdDepartament", Employee.IdDepartamento);
                cmd.Parameters.AddWithValue("@IdJobTitle", Employee.IdJobTitle);
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

        public void UpdateEmployee(Employee Employee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Employee.Id);
                cmd.Parameters.AddWithValue("@name", Employee.Name);
                cmd.Parameters.AddWithValue("@LastName", Employee.LastName);
                cmd.Parameters.AddWithValue("@Phone", Employee.Phone);
                cmd.Parameters.AddWithValue("@DateEntry", Employee.DateEntry);
                cmd.Parameters.AddWithValue("@Salary", Employee.Salary);
                cmd.Parameters.AddWithValue("@IdDepartament", Employee.IdDepartamento);
                cmd.Parameters.AddWithValue("@IdJobTitle", Employee.IdJobTitle);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.CloseConnection();
            }
        }


        public List<Employee> SelectEmployee(string name, string status, string Month, string departament)
        {

            List<Employee> listEmployee = new List<Employee>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SelectEmployee", conn.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Status",  status);
                cmd.Parameters.AddWithValue("@Month", Month);
                cmd.Parameters.AddWithValue("@Departament", departament );

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                      object m =  dr["id_jobTitle"].ToString();
                        listEmployee.Add(new Employee() {

                            Id = Convert.ToInt32(dr["id"].ToString()),
                            Code = dr["code_Employee"].ToString(),
                            Name = dr["name"].ToString(),
                            LastName = dr["last_Name"].ToString(),
                            Phone = dr["Phone"].ToString(),
                            DateEntry = Convert.ToDateTime(dr["date_entry"].ToString()),
                            Salary = Convert.ToInt32(dr["salary"].ToString()),
                            Status = dr["Status_employee"].ToString(),
                            IdDepartamento = Convert.ToInt32(dr["id_departament"].ToString() == "" ? "0" : dr["id_departament"].ToString()),
                            Departamento = dr["name_departament"].ToString(),
                            IdJobTitle = Convert.ToInt32(dr["id_jobTitle"].ToString() == "" ? "0": dr["id_jobTitle"].ToString() ),
                            JobTitle = dr["JobTitle"].ToString(),

                        });
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }

            return listEmployee;
        }


       
    }
}
