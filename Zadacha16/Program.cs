using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            int temp = 0;


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp = matrix[i, 0];
                matrix[i, 0] = matrix[i, matrix.GetLength(1) - 1];
                matrix[i, matrix.GetLength(1) - 1] = temp;
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
