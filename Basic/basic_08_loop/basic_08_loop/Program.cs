using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_08_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string[] array = new string[] { "AB", "CD", "EF" };

            //The foreach statement is mainly used for arrays or collections.
            foreach (string s in array)
                System.Console.WriteLine(s);

            for (i = 0; i < 10; i++)
                System.Console.WriteLine("Loop {0}", i);

            while (i > 0)
            {
                System.Console.WriteLine(i);
                i--;
            }

            do
            {
                System.Console.WriteLine(i);
                i++;
            } while (i < 10);
        }
    }
}
