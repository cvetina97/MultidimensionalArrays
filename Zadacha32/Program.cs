using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            int product = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if (i == k || matrix[k, j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            product *= matrix[k, j];
                        }
                    }

                }
                Console.WriteLine("The product of the elements except from zero without {0}-row is {1}  ." ,i, product);
                product = 1;
            }
        }
    }
}
