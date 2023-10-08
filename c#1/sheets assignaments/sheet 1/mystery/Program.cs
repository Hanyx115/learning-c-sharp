using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mystery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int sum1 = 0 ; int sum2 = 0;
            while (number <= 15)
            {
                if (number % 2 != 0)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
             number++;
             Console.WriteLine($"{sum1}\t {sum2}");
            }
        }
    }
}
