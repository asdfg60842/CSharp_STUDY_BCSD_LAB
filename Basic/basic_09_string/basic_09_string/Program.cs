using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_09_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "C# Studies";

            //One-character access from string to array index
            for (int i = 0; i < s.Length; i++)
            {
                System.Console.WriteLine("{0}:  {1}", i, s[i]);
            }

            //Convert string to character array
            string str = "Hello";
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                System.Console.WriteLine(charArray[i]);
            }

            //Convert character array to string 
            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(charArray2);

            System.Console.WriteLine(s);

            char c1 = 'A';
            char c2 = (char)(c1 + 3);
            System.Console.WriteLine(c2);

        }
    }
}
