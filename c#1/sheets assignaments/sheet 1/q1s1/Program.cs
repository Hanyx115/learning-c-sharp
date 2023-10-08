using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1s1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
