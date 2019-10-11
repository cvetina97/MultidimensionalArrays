using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 6, 3, 1 }, { 5, 0, 2 }, { 3, 2, 4 }, { 2, 6, 5 } };
            double sumStudent = 0;
            double sumSubject = 0;
            double averageSubject = 0;
            double allAverage = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            { 
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumStudent += matrix[i, j];
                }
                allAverage += sumStudent / matrix.GetLength(1);
                Console.WriteLine("The average grade for student {0} is {1}",i,sumStudent / matrix.GetLength(1));
                sumStudent = 0;
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sumSubject += matrix[i, j];
                }
                Console.WriteLine("The average grade for subject {0} is {1}", j, sumSubject / matrix.GetLength(0));
                sumSubject = 0;
            }
            Console.WriteLine("The average grade for the class is {0}", allAverage / matrix.GetLength(0));




        }
    }
}
