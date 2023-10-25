using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static int Lcm(int a, int b)
    {
        
        return (a * b) / Gcd(a, b);
    }

    public static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static void Main(string[] args)
    {
        
        Console.Write("Enter the first integer: ");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.Write("Enter the second integer: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                
                int lcm = Lcm(num1, num2);
                Console.WriteLine($"The Lowest Common Multiple of {num1} and {num2} is: {lcm}");
            }
            else
            {
                Console.WriteLine("Invalid input for the second integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the first integer.");
        }
    }
}

