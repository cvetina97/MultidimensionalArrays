using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3 }, { 5, 6, 7 } , {-4,0,-6} };
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1)-1-i; j >= 0; j--)
                {
                    sum += matrix[i, j];
                    break;
                }
            }
            Console.WriteLine("The sum of the elements from the second diagonal is : " + sum);
        }
    }
}
