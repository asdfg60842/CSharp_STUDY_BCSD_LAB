using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_06_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // ?? operator : 
            int? i = null;
            i = i ?? 0;

            string s = null;
            s = s ?? string.Empty;
        }
    }
}
