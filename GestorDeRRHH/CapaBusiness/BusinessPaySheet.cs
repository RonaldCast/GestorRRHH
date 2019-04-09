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
    public class BusinessPaySheet
    {
        private DbPaySheet _DbPaySheet = new DbPaySheet();

        public bool InsertUpdatePaySheet(PaySheet PaySheet)
        {
            bool allCorrect = false;

            if (ValidateFiels(PaySheet))
            {
                if (PaySheet.Id == 0)
                {
                    _DbPaySheet.InsertPaySheet(PaySheet);
                    allCorrect = true;

                }
            }

            return allCorrect;
        }



        public List<PaySheet> SeachPaySheetForMonth(string Month)
        {
            return _DbPaySheet.SearchPaySheet(Month);
        }

        public bool ValidateFiels(PaySheet PaySheet)
        {
            bool allCorrect = false;

            if (PaySheet != null)
            {
                if (string.IsNullOrEmpty(PaySheet.Month))
                    MessageBox.Show("Debe de llenar el campo", "Alerta");
                else
                {
                    try
                    {
                        if (PaySheet.Year.Length == 4)
                        {
                            
                            Convert.ToInt32(PaySheet.Year);
                            allCorrect = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe de llenar el campo", "Alerta");
                        }
                       
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Valor incorrecto", "Alerta");
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

