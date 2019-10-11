using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha20
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 0, p2 = 8, q1 = 0, q2 = 6;

            if (p1 > p2)
            {
                if (q1 > q2)
                {
                    while (p1 != p2 || q1 != q2)
                    {
                        if (p1 == p2)
                        {
                            q1--;
                        }
                        else if (q1 == q2)
                        {
                            p1--;
                        }
                        else
                        {

                            p1--;
                            q1--;
                        }
                        Console.WriteLine("p1 = " + p1 + " q1 = " + q1);
                    }
                }
                else
                {
                    while (p1 != p2 || q1 != q2)
                    {
                        if (p1 == p2)
                        {
                            q1++;
                        }
                        else if (q1 == q2)
                        {
                            p1--;
                        }
                        else
                        {

                            p1--;
                            q1++;
                        }
                        Console.WriteLine("p1 = " + p1 + " q1 = " + q1);
                    }
                }
            }
            else
            {
                if (q1 > q2)
                {
                    while (p1 != p2 || q1 != q2)
                    {
                        if (p1 == p2)
                        {
                            q1--;
                        }
                        else if (q1 == q2)
                        {
                            p1++;
                        }
                        else
                        {

                            p1++;
                            q1--;
                        }
                        Console.WriteLine("p1 = " + p1 + " q1 = " + q1);
                    }
                }
                else
                {
                    while (p1 != p2 || q1 != q2)
                    {
                        if (p1 == p2)
                        {
                            q1++;
                        }
                        else if (q1 == q2)
                        {
                            p1++;
                        }
                        else
                        {

                            p1++;
                            q1++;
                        }
                        Console.WriteLine("p1 = " + p1 + " q1 = " + q1);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

