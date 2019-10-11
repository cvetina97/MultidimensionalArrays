using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha42
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentCounter = 0;
            int counter = 0;
            int columnIndex = 0;

            int[,] matrix = { { -3, -8, 1 }, { -5, -2, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    columnIndex = j;
                }
                currentCounter = 0;
                
            }
            Console.WriteLine("The column with the most negative elements ({0}) is {1}  ",counter, columnIndex);
        }
    }
}
