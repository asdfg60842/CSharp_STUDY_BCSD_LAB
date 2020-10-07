using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_05_enum
{
    class Program
    {
        enum City
        {
            Seoul,   // 0
            Daejun,  // 1
            Busan = 5,  // 5
            Jeju = 10   // 10
        }
        static void Main(string[] args)
        {
            City myCity;

            //How to assign a value to an enum type
            myCity = City.Seoul;

            //How to cast an enum to int
            //(int) is specified in front.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) //How to compare enum values 
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
}
