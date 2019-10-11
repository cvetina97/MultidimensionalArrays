using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha36
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 1;

            int[,] matrix = { { -3, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i + 1 < matrix.GetLength(1))
                {
                    product *= matrix[i, i + 1];
                }
            }
            Console.WriteLine("Product of elements above the basic diagonal is : " + product);
        }
    }
}
