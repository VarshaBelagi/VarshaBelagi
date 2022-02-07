using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaccis
{
    class fibonaccis
    {
        public static void Main()
        {

            int a = 0, b = 1, c, i, num;
            Console.WriteLine("Enter the Number of Digits:");
            num = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (i = 1; i <= num; ++i)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}