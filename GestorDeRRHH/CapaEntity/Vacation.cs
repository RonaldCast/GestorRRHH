using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class Vacation
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public DateTime DateSince {get; set;}
        public DateTime DateUntil { get; set; }
        public string Comment { get; set; }
        public string CodeEmployee { get; set; }
        public string Year { get; set; }
    }
}
