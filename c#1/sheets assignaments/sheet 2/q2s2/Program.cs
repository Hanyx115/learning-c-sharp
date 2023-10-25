using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2s2
{
    internal class Program
    {

        //A)no access modifier used
        public void G()
        {
            Console.WriteLine("inside g");
        
        }

        private static void H()
        {
            Console.WriteLine("inside H");

        }
        //B)no returned value
        public int sum(int x,int y)
        {
            return x + y;
        }
        //C)declaring variables with common name
        public void F(float a)
        {
            float z;
            Console.WriteLine(a);
        
        }

        //D)returning value while diclaring method as void 
        public int Product()
        {
            int a=6,b=5,c=4,result;
            result = a * b * c;
            Console.WriteLine("result is "+result);
            return result;
        }








        static void Main(string[] args)
        {
            

        }
    }
}
