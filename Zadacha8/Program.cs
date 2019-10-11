using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] B = { 3, 6, 0 };
            int[,] A = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 } };

            for (int i = 0; i < B.Length; i++)
            {
                A[i, i] = B[i];
                A[i, B.Length - 1 - i] = B[i];
            }

            for (int row = 0; row < A.GetLength(0); row++)
            {
                for (int col = 0; col < A.GetLength(1); col++)
                {
                    Console.Write(" " + A[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}
