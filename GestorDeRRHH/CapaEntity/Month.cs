using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class Month
    {
        public string MonthEnglish { get; set; }
        public string MonthSpanish { get; set; }

        public static List<Month> GetListMonth()
        {
            List<Month> listMonths = new List<Month>();
            string[] monthSpanish = new string[]
            {
                "Todos",
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"

            };

            string[] monthEnglish = new string[]
            {
                "",
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            for (int i = 0; i < monthEnglish.Length; i++)
            {
                listMonths.Add(new Month()
                {
                    MonthEnglish = monthEnglish[i],
                    MonthSpanish = monthSpanish[i]
                });
            }

            return listMonths;
        }
    }
}
