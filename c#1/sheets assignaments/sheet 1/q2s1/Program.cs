using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2s1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float item1 = float.Parse(Console.ReadLine());
            float item2=float.Parse(Console.ReadLine());
            float item3= float.Parse(Console.ReadLine());
            float sum=item1 + item2 + item3;
            float discount = (float)(sum * 0.1);
            float netammount =sum-discount;
            Console.WriteLine("net payable amount is=" + netammount);

        }
    }
}
