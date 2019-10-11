using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 6, 8, 1 }, { -5, -1, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            int product = 1;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (j == k || matrix[i, k] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            product *= matrix[i, k];
                        }
                    }

                }
                Console.WriteLine("The product of the elements except from zero without {0}-column is {1}  .", j, product);
                product = 1;
            }
        }
    }
}
