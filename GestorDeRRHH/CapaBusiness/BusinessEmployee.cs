using CapaDeDatos;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaBusiness
{
    public class BusinessEmployee
    {
        private DbEmployee _DbEmployee = new DbEmployee();
        private CodeObject _CodeObject = new CodeObject();

        public bool InsertUpdateEmployee(Employee employee)
        {
            bool allCorrect = false;

            if (ValidateFiels(employee))
            {
                if (employee.Id == 0)
                {
                    employee.Code = _CodeObject.CreateCode(employee);
                    _DbEmployee.InsertEmployee(employee);
                    allCorrect = true;

                }
                else
                {
                    _DbEmployee.UpdateEmployee(employee);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }



        /*public List<Employee> SelectEmployee()
        {
            return _DbEmployee.SelectEmployee
        }*/


        public List<Employee> SearchEmployee(string name, string status, string Month, string departament)
        {
            return _DbEmployee.SelectEmployee(name, status,
                 Month, departament);
        }

        public bool ValidateFiels(Employee employee)
        {
            bool allCorrect = false;

            if (employee != null)
            {
                if (string.IsNullOrEmpty(employee.Name) || string.IsNullOrEmpty(employee.LastName)
                    || string.IsNullOrEmpty(employee.Phone) || employee.Salary == 0 
                    || employee.IdJobTitle == 0 || employee.IdDepartamento == 0)

                {
                    MessageBox.Show("Debe de llenar el campo", "Alerta");
                }
                else
                {
                    allCorrect = true;
                }
            }
            else
            {
                MessageBox.Show("Debe de llenar el campo", "Alerta");
            }

            return allCorrect;
        }
    }
}

