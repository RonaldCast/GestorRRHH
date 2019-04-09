using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBusiness
{
    public class CodeObject
    {
        public string CreateCode(string word)
        {
            StringBuilder code = new StringBuilder();
                code.Append(word.Length > 3 ? word.Substring(0, 3) : word);
                code.Append("-");
                code.Append(DateTime.Now.Minute.ToString());

            return code.ToString();
        }

        public string CreateCode(Employee employee)
        {
            StringBuilder code = new StringBuilder();
            code.Append(employee.Name.Substring(0, 1));
            code.Append(employee.Name.Substring(1, 2));
            code.Append("-");
            code.Append(employee.DateEntry.Year);

            return code.ToString();
        }


    }
}
