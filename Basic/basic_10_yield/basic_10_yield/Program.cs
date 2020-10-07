using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_10_yield
{
    class Program
    {
        //num received
        static IEnumerable<int> GetNumber()
        {
            //one return for each round?
            yield return 10;
            yield return 20;
            yield return 30;
        }
        static void Main(string[] args)
        {
            //num passing
            foreach (int num in GetNumber())
                System.Console.WriteLine(num);
        }
    }
}
