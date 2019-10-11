using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha24
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
                    if (i < j)
                    {
                        product *= matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Product of the elements above the basic diagonal is : " + product);
        }
    }
}
