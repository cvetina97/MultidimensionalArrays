using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            int temp = 0;


            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp = matrix[0, j];
                matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
                matrix[matrix.GetLength(0) - 1, j]=temp;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
