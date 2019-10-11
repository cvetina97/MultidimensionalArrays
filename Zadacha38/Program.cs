using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha38
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[,] matrix = { { -3, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 2 - i; j >= 0; j--)
                {
                    sum += matrix[i, j];
                    break;
                }

            }
            Console.WriteLine("Sum of the elements exactly above the second diagonal is : " + sum);
        }
    }
}
