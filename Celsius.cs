using System;
namespace Celsiuss
{
    class Celsiuss
    {
        static void Main()
        {

            Console.Write("Enter the Amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int kelvin = celsius + 273;
            int fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("The Kelvin Degree is:" + kelvin);
            Console.WriteLine("The Fahrenheit Degree is:" + fahrenheit);
            Console.WriteLine("The celsius Degree is:" + celsius);
        }


    }
}