using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1s2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many times you want to change the temprature");
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                Console.WriteLine("please insert '0' for converting fahrenhite to celcius or '1' for converting celcius to fahrenhite");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 0)
                {
                    string Fahrenheit = Console.ReadLine();
                    double fah = double.Parse(Fahrenheit);
                    Console.WriteLine("celcius = " + cels(fah));
                }
                else if (ans == 1)
                {
                    string celcius = Console.ReadLine();
                    double fah = double.Parse(celcius);
                    Console.WriteLine("Fahrenhite = " + fehr(fah));

                }
                n = n - 1;



            }
        }
        static double cels(double x)
        {
            double celsius = (5.0 / 9.0) * (x - 32);
            return celsius;
        }
        static double fehr(double x)
        {
            double fah = (9.0 / 5.0) * (x + 32);
            return fah;

        }
    }
}
  
