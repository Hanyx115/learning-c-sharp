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

            /*answer is 
1        0
1        2
4        2
4        6
9        6
9        12
16       12
16       20
25       20
25       30
36       30
36       42
49       42
49       56
64       56
*/
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
