using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please , enter n : ");
            int n = int.Parse(Console.ReadLine());
            int b = 5;
            int[,] A = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    A[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (A[row, col] > b)
                    {
                        Console.WriteLine("Number {0} is bigger than b ", A[row, col]);
                    }
                }
            }
        }
    }
}
