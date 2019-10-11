using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha22
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = { { 3, 8, 1 }, { 5, 0, 2 }, { 3, 2, 4 } };
            int start = 0;
            int end = matrix.GetLength(0) - 1;
            int currentNum = 0;
            int counter = 0;
            bool is_simple = true;
            //top
            for (int col = start; col <= end; col++)
            {
                currentNum= matrix[start, col];
                is_simple = Erathosten(currentNum);
                if (is_simple==true)
                {
                    counter++;
                }
            }
            //right
            for (int row = start; row <= end; row++)
            {
                currentNum=matrix[row, end];
                is_simple = Erathosten(currentNum);
                if (is_simple==true)
                {
                    counter++;
                }
            }
            //bottom
            for (int col = end; col >= start; col--)
            {
                 currentNum= matrix[end, col];
                is_simple = Erathosten(currentNum);
                if (is_simple == true)
                {
                    counter++;
                }
            }
            //left
            for (int row = end; row <= start; row--)
            {
                currentNum= matrix[row, start];
                is_simple = Erathosten(currentNum);
                if (is_simple==true)
                {
                    counter++;
                }
            }
            Console.WriteLine("The simple numbers from the boundaries of the matrix are {0} ", counter);

        }
        public static bool Erathosten(int number)
        {
            bool is_simple = true;
            
                for (int i = 2; i < 14; i++)
                {
                    if(number == i)
                    {
                        i++;
                    continue;
                    }
                    else if(number <= 2)
                    {
                        is_simple = true;
                        break;
                    }
                    else if (number % i == 0)
                    {
                        is_simple = false;
                        break;
                    }


                }
                if (is_simple)
                {
                    return is_simple=true;
                }
            
            return is_simple;
        }
    }
}
