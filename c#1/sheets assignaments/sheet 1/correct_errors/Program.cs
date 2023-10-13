using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correct_errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)//
            string age= Console.ReadLine();
            if (int.Parse(age) >=65) {
                Console.WriteLine("Age greater than or equal to 65");
                    }
            else {
                Console.WriteLine("Age is less than 65");
            }
            //b)//
            int x = 1;
            int total=0;
            while (total <= 10)
            {
                total += x;
                ++x;
            }
            //c)//
            while (total <= 10)
            {
                total += x;
                ++x;
            }
            //d)//
            int y=0;
            while (y < 10){
                Console.WriteLine(y);
                ++y;
            }
        }
    }
}
