using System;

internal class Program
{
    private static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers less than 10,000:");
        for (int i = 2; i < 10000; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}

