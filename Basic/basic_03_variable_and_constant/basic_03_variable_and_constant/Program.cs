using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_03_variable_and_constant
{
    class CSVar
    {
        //Field(global variable commonly used within class)
        //It is automatically initialized to 0 even if it is not initialized.
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            //local variable
            int localVar;

            //If there is no assignment below, an error occurs
            localVar = 100;

            System.Console.WriteLine(globalVar);
            System.Console.WriteLine(localVar);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}
