using System;
public class SumAvg
{
    public static void Main()
    {

        double avg = 0, avg1 = 0;
        double sum = 0, sum1 = 0;
        int a;
        Console.WriteLine("Enter The Numbers");
        for (int i = 1; i <= 10; i++)
        {

            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                sum = sum + a;
            }
            else
            {
                sum1 = sum1 - a;
            }
        }
        avg = sum / 10;
        avg1 = sum1 / 10;
        Console.WriteLine(" sum of all +ve numbers" + sum);
        Console.WriteLine(" sum of all -ve numbers" + sum1);
        Console.WriteLine(" avg of all +ve numbers" + avg);
        Console.WriteLine(" avg of all -ve numbers" + avg1);
    }
}

