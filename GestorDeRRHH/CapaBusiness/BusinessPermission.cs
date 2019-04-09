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
    public class BusinessPermission
    {
        private DbPermission _DbPermission = new DbPermission();

        public bool InsertUpdatePermission(Permission permission)
        {
            bool allCorrect = false;

            if (ValidateFiels(permission))
            {
                if (permission.Id == 0)
                {
                    _DbPermission.InsertPermission(permission);
                    allCorrect = true;

                }
                else
                {
                    _DbPermission.UpdatePermission(permission);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public bool DeletePermission(int id)
        {
            bool allCorrect = false;

            if (id != 0)
            {
                _DbPermission.DeletePermission(id);
                allCorrect = true;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cargo para eliminar", "Alerta");
                allCorrect = false;
            }

            return allCorrect;
        }

        public List<Permission> SelectPermission()
        {
            return _DbPermission.SelectPermission();
        }

        public bool ValidateFiels(Permission permission)
        {
            bool allCorrect = false;

            if (permission != null)
            {
                if (string.IsNullOrEmpty(permission.Comment))

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

