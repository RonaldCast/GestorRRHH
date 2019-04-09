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
    public class BusinessLicense
    {
        private DbLicense _DbLicense = new DbLicense();

        public bool InsertUpdateLicense(Licenses License)
        {
            bool allCorrect = false;

            if (ValidateFiels(License))
            {
                if (License.Id == 0)
                {
                    _DbLicense.InsertLicense(License);
                    allCorrect = true;

                }
                else
                {
                    _DbLicense.UpdateLicense(License);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public bool DeleteLicense(int id)
        {
            bool allCorrect = false;

            if (id != 0)
            {
                _DbLicense.DeleteLicense(id);
                allCorrect = true;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cargo para eliminar", "Alerta");
                allCorrect = false;
            }

            return allCorrect;
        }

        public List<Licenses> SelectLicense()
        {
            return _DbLicense.SelectLicense();
        }

        public bool ValidateFiels(Licenses License)
        {
            bool allCorrect = false;

            if (License != null)
            {
                if (string.IsNullOrEmpty(License.Comment) || string.IsNullOrEmpty(License.Reason))

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

