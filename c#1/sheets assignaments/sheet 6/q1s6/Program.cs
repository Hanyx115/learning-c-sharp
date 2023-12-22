using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1s6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point(1.5, 2.5);

            Console.WriteLine("Point 1: " + point1.ToString());
            Console.WriteLine("Point 2: " + point2.ToString());
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(3.0, 4.0, 2.5);

            Console.WriteLine("Circle 1: " + circle1.ToString());
            Console.WriteLine("Circle 2: " + circle2.ToString());
        }
    }
}
