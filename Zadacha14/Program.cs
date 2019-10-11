using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha14
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiveCounter = 0;
            int negativeCounter = 0;
            int zeroCounter = 0;
            int[,] matrix = { { 6, 8, 1 }, { -5, 0, 14 }, { 3, -2, 4 }, { 15, 7, 2 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                     if(matrix[i,j] > 0)
                    {
                        positiveCounter++;
                    }
                    else if(matrix[i,j] < 0)
                    {
                        negativeCounter++;
                    }
                    else
                    {
                        zeroCounter++;
                    }
                }
                Console.WriteLine("For the {0} row - positive elements are {1} , negative elements are {2} and the zero elements are {3}",
                    i,positiveCounter,negativeCounter,zeroCounter);

                positiveCounter = 0;
                negativeCounter = 0;
                zeroCounter = 0;
                
            }
        }
    }
}
