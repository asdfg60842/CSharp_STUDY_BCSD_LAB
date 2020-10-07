using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_04_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 dimensional array
            string[] players = new string[10];
            string[] Regions = { "서울", "경기", "부산" };

            //2 dimensional array
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            //Jagged Array
            //1 dimensional array's size must be specified
            int[][] A = new int[3][];

            //each 1 dimensional array elements can be allocated for each other size array 
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;

            //array e.g.
            int[] scores = { 80, 78, 60, 90, 100 };
            int sum = CalculateSum(scores); // Array passing
            Console.WriteLine(sum);


        }
        static int CalculateSum(int[] scoresArray) // Array receiving 
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }
    }
}

