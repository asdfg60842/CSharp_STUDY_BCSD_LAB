using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_13_struct
{
    class Program
    {
        //The struct is used to create the structure and define the value type
        struct MyPoint
        {
            public int x;
            public int y;

            public MyPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            //With ToString method, we can change data type int to char
            public override string ToString()
            {
                return string.Format("({0}, {1})", x, y);
            }
        }
        static void Main(string[] args)
        {
            MyPoint pt = new MyPoint(1, 5);
            System.Console.WriteLine(pt.ToString());
        }
    }
}
