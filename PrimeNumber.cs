using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Primenumber
    {
        private static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            isprime();
        }
        public static void isprime()
        {
            bool isprime = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    Console.WriteLine(num + " is not prime number");
                    break;
                }
            }
            if (isprime)
            {
                Console.WriteLine(num + " is a prime number");
                
            }

        }
    }
}