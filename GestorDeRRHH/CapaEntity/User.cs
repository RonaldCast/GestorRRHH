using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class User
    {
        public int Id { get; set; }
        public string NameUser { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string CodeEmployee { get; set; }
        public int IdEmployee { get; set; }
        
    }
}
