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
    public class BusinessJobTitle
    {
        private DbJobTitle _DbJobTitle = new DbJobTitle();

        public bool InsertUpdateJobTitle(JobTitle Job)
        {
            bool allCorrect = false;

            if (ValidateFiels(Job))
            {
                if (Job.Id == 0)
                {
                    _DbJobTitle.InsertJobTitle(Job);
                    allCorrect = true;

                }
                else
                {
                    _DbJobTitle.UpdateJobTitle(Job);
                    allCorrect = true;
                }
            }

            return allCorrect;
        }


        public bool DeleteJobTitle(int id)
        {
            bool allCorrect = false;

            if (id != 0)
            {
                _DbJobTitle.DeleteJobTitle(id);
                allCorrect = true;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cargo para eliminar", "Alerta");
                allCorrect = false;
            }

            return allCorrect;
        }

        public List<JobTitle> SelectJobTitle()
        {
            return _DbJobTitle.SelectJobTitle();
        }


        public List<JobTitle> SearchJobTitle(string job)
        {
            return _DbJobTitle.SearchJobTitle(job);
        }

        public bool ValidateFiels(JobTitle Job)
        {
            bool allCorrect = false;

            if (Job != null)
            {
                if (string.IsNullOrEmpty(Job.Job))

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

