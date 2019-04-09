using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; } 
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DateEntry { get; set; }
        public decimal Salary { get; set; }
        public string Status { get; set; }
        public int IdDepartamento { get; set; }
        public int IdJobTitle { get; set; }
        public string Departamento { get; set; }
        public string JobTitle { get; set; }

    }
}
