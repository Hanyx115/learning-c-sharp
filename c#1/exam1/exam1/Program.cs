using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int sum = 0;
            int avg = 0;
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                sum = arr[i] + sum;
                avg = sum / arr.Length;  


            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > avg)
                {
                    Console.WriteLine(arr[i]);
                }
                if (arr[i] == arr[2])
                {
                    count++;
                    

                }


            }
            Console.WriteLine(count);
        }



        }

}
