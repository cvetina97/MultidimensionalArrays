using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha27
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[,] matrix = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= matrix.GetLength(1)-i; j--)
                {
                    sum += matrix[i, j];
                }

            }
            Console.WriteLine("Sum of the elements below the second diagonal is : " + sum);
        }
    }
}
