using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha45
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int maxSum = 0;
            int currentSum = 0;
            int indexRow = 0;

            int[,] matrix = { { -3, -8, 1 }, { -5, -2, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    currentSum += matrix[i, j];
                }
                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    indexRow = i;
                }
                currentSum = 0;
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[indexRow,j] < min)
                {
                    min = matrix[indexRow, j];
                }
            }
            Console.WriteLine("The row with the biggest elements' sum is {0} with sum ({1}). The smallest element in it is {2}",indexRow,maxSum,min);
        }
    }
}
