using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha40
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 1;

            int[,] matrix = { { -3, 8, 1 }, { -5, 2, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < matrix.GetLength(1))
                {
                    product *= matrix[i, i];
                }

                for (int j = matrix.GetLength(1) - 1 - i; j >= 0; j--)
                {
                    if (matrix[i, i] != matrix[i, j])
                    {
                        product *= matrix[i, j];
                    }
                    break;
                }
            }
            Console.WriteLine("Product of the elements both from the basic and the second diagonal is : " + product);
        }
    }
}
