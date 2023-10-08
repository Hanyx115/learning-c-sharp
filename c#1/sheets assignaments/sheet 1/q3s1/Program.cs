using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3s1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NumberFiveDigits = Console.ReadLine();
            if (NumberFiveDigits.Length != 5 ||! int.TryParse(NumberFiveDigits, out int number))
            {
                Console.WriteLine("write number again");
                NumberFiveDigits = Console.ReadLine();
            }
            else
                foreach (char C in NumberFiveDigits)
                {
                    Console.Write($"{C}   ");
                }
        }
    }
}
