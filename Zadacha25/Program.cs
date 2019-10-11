using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            int max =int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        if(matrix[i,j] > max)
                        {
                            max = matrix[i, j];
                        }
                    }
                }
            }
            Console.WriteLine("The biggest element under the basic diagonal is  : " + max);
        }
    }
}
