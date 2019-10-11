using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha26
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            int[,] matrix = { { -3, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 2 - i; j >= 0; j--)
                {
                    if(matrix[i,j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                
            }
            Console.WriteLine("Min element above the second diagonal is : " + min);
        }
    }
}
