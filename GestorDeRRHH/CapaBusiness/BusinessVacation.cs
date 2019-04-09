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
    public class BusinessVacation
    {
        private DbVacation _DbVacation = new DbVacation();

        public bool InsertUpdateVacation(Vacation Vacation)
        {
            bool allCorrect = false;

            if (ValidateFiels(Vacation))
            {
                if (Vacation.Id == 0)
                {
                    _DbVacation.InsertVacation(Vacation);
                    allCorrect = true;

                }
                else
                {
                    _DbVacation.UpdateVacation(Vacation);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public List<Vacation> SelectVacation()
        {
            return _DbVacation.SelectVacation();
        }

        public List<Vacation> SeachVacationForYear(string year)
        {
            return _DbVacation.SearchVacation(year);
        }

        public bool ValidateFiels(Vacation Vacation)
        {
            bool allCorrect = false;

            if (Vacation != null)
            {
                if (string.IsNullOrEmpty(Vacation.Comment))
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

