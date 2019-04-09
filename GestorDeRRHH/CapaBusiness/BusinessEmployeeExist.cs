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
    public class BusinessEmployeeExist
    {
        private DbEmployeeExist _DbEmployeeExist = new DbEmployeeExist();

        public bool InsertUpdateEmployeeExist(EmployeeExist EmployeeExist)
        {
            bool allCorrect = false;

            if (ValidateFiels(EmployeeExist))
            {
                if (EmployeeExist.Id == 0)
                {
                    _DbEmployeeExist.InsertEmployeeExist(EmployeeExist);
                    allCorrect = true;

                }
                else
                {
                    _DbEmployeeExist.UpdateEmployeeExist(EmployeeExist);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public List<EmployeeExist> SelectEmployeeExist()
        {
            return _DbEmployeeExist.SelectEmployeeExist();
        }

        public List<EmployeeExist> SeachEmployeeExistForMonth(string Month)
        {
            return _DbEmployeeExist.SearchEmployeeExist(Month);
        }

        public bool ValidateFiels(EmployeeExist EmployeeExist)
        {
            bool allCorrect = false;

            if (EmployeeExist != null)
            {
                if (string.IsNullOrEmpty(EmployeeExist.Reason))
                    MessageBox.Show("Debe de llenar el campo", "Alerta");
                else
                    allCorrect = true;
            }
            else
            {
                MessageBox.Show("Debe de llenar el campo", "Alerta");
            }

            return allCorrect;
        }
    }
}

