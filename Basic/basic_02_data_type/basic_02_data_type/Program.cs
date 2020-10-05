using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_02_data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////
            //Data type//
            /////////////
            

            //Bool
            bool b = true;

            //Numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;      // L suffix
            float f = 123.45F;   // F suffix
            double d1 = 123.45;
            double d2 = 123.45D; // D suffix
            decimal d = 123.45M; // M suffix

            // Char/String
            char c = 'A';
            string s = "Hello";

            // DateTime  2020-10-4 11:32
            DateTime dt = new DateTime(2020, 10, 4, 11, 32, 0);


            //////////////////
            //Max, Min Value//
            //////////////////
     

            int Max = int.MaxValue;
            float Min = float.MinValue;


            ////////
            //NULL//
            ////////


            string s_n;
            s = null;


            /////////////////
            //Nullable type//
            /////////////////


            int? aa = null;
            aa = 100;

            bool? bb = null;

            Nullable<int> cc = null;
            cc = 10;
            int dd = cc.Value;
        }
    }
}
