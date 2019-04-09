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
    public class BusinessDepartament
    {
        private DbDepartament _DbDepartament = new DbDepartament();

        public bool InsertUpdateDepartament(Departament Departament)
        {
            bool allCorrect = false;

            if (ValidateFiels(Departament))
            {
                
                if (Departament.Id == 0)
                {
                    _DbDepartament.InsertDepartament(Departament);
                    allCorrect = true;

                }
                else
                {
                    _DbDepartament.UpdateDepartament(Departament);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public bool DeleteDepartament(int id)
        {
            bool allCorrect = false;

            if (id != 0)
            {
                _DbDepartament.DeleteDepartament(id);
                allCorrect = true;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cargo para eliminar", "Alerta");
                allCorrect = false;
            }

            return allCorrect;
        }

        public List<Departament> SelectDepartament()
        {
            return _DbDepartament.SelectDepartament();
        }


        public List<Departament> SearchDepartament(string Departament)
        {
            return _DbDepartament.SearchDepartament(Departament);
        }

        public Departament SelectDepartamentForID(int id)
        {
            Departament departament = new Departament();

            if (id == 0)
                departament.Name = "";
            else
                departament = _DbDepartament.SelectDepartamentForID(id);

            return departament;
        }

        public bool ValidateFiels(Departament Departament)
        {
            bool allCorrect = false;

            if (Departament != null)
            {
                if (string.IsNullOrEmpty(Departament.Name))

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

