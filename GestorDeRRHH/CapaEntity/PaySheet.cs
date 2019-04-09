using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class PaySheet
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public decimal Amount { get; set; }
        public string Year { get; set; }
    }
}
