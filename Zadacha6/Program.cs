using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the size of a matrix ");
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                product *= matrix[i, i];
            }
            Console.WriteLine("The product of all elements in the basic diagonal is :  " + product);
        }
    }
}
