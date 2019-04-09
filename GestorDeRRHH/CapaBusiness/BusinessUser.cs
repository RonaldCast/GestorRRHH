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
    public class BusinessUser
    {
        private DbUser _DbUser = new DbUser();

        public bool InsertUpdateUser(User User)
        {
            bool allCorrect = false;

            if (ValidateFiels(User))
            {
                if (User.Id == 0)
                {
                    _DbUser.InsertUser(User);
                    allCorrect = true;

                }
                else
                {
                    _DbUser.UpdateUser(User);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public bool DeleteUser(int id)
        {
            bool allCorrect = false;

            if (id != 0)
            {
                _DbUser.DeleteUser(id);
                allCorrect = true;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cargo para eliminar", "Alerta");
                allCorrect = false;
            }

            return allCorrect;
        }

        public List<User> SelectUser()
        {
            return _DbUser.SelectUser();
        }


        public List<User> SearchUser(string User)
        {
            return _DbUser.SearchUser(User);
        }

        public bool ValidateFiels(User User)
        {
            bool allCorrect = false;

            if (User != null)
            {
                if (string.IsNullOrEmpty(User.NameUser) || string.IsNullOrEmpty(User.Password))

                {
                    MessageBox.Show("Debe de llenar el campo", "Alerta");
                }
                else
                {
                    if (User.Password == User.PasswordConfirm)
                    {
                        allCorrect = true;
                    }
                    else
                    {

                        MessageBox.Show("Las contraseñas no coinciden", "Alerta");
                    }
                   
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

