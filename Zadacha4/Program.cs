using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int product = 1;
            int nok = 1;
            int a = 1;
            int b = 1;

            int[] A = { 15, 2, 4, 6 };
            int[] B = { 3, 7, 9, 11, 16 };
            int[,] C = new int[A.Length, B.Length];

            

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    a = A[i];
                    b = B[j];

                    while (b != 0)
                    {
                        int oldB = b;
                        b = a % b;
                        a = oldB;
                    }
                    product = a;

                    nok = A[i] * B[j] / product;



                    Console.WriteLine("A is " + A[i] + " B is " + B[j]);
                    Console.Write("GCD={0}", product);
                    Console.WriteLine("nok {0}", nok);

                    C[i, j] = nok;

                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    Console.Write(C[i, j] + " , ");
                }
            }

            Console.ReadKey();
        }
    }
}
