using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sorting
{
    class Sortingthreenumbers
    {
        private static void Main()
        {
            sorting(2,10,1);
            sorting(20,10,1);
            sorting(2,10,100);
            sorting(0, 12, 2);
            sorting(0, 1, 22);
        }

        private static void sorting(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }
            }
            else
            {
                if (c > a && c > b)
                {
                    if (a > b)
                    {
                        Console.WriteLine("{0},{1},{2}", c, a, b);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", c, b, a);
                    }
                }
            }
        }
    }
}

