using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double sum = 0;
            double average = 0;

            Console.WriteLine("Please , enter n ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (matrix[row,col] >= 0)
                    {
                        continue;
                    }
                    else
                    {
                        sum += matrix[row,col];
                        counter++;
                    }
                    average = sum / counter;
                }
            }
            Console.WriteLine("The sum of all negative numbers in the matrix is {0} , their count is  {1} and average = {2}", sum, counter, average);

        }
    }
}
