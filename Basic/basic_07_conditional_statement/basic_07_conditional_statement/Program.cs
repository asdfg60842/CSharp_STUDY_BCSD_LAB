using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_07_conditional_statement
{
    class Program
    {
        enum category
        {
           Strawberry,
           Watermelon,
           Apple = 5,
           Grape = 10
        }
        static void Main(string[] args)
        {
            int value;
            int num = 5;

            //if conditional statement
            if (num == 5)
                System.Console.WriteLine("num = 5");
            else
                System.Console.WriteLine("num != 5");


            value = (int)category.Strawberry;

            //switch conditional statement
            switch (value)
            {
                case 0:
                    System.Console.WriteLine("딸기");
                    break;
                case 1:
                    System.Console.WriteLine("수박");
                    break;
                case 5:
                    System.Console.WriteLine("사과");
                    break;
                case 10:
                    System.Console.WriteLine("포도");
                    break;
                default:
                    System.Console.WriteLine("딸기");
                    break;
            }
        }
    }
}
