using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            while (n <= 10)
            {
                Console.WriteLine(a + " * " + n + "=" + (a * n));
                n++;
            }
        }
    }


}

