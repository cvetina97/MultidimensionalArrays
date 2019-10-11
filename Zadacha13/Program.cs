using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {  { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 },{ 15,7,2}  };
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Sum of the elements from the {0} column is {1}", j, sum);
                sum = 0;
            }
            
        }
    }
}
