using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace q1s6
{
    class Point
    {
        private double x;
        private double y;
        public Point()
        {
            x = 0.0;
            y = 0.0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    class Circle : Point
    {
        private double radius;
        public Circle() : base()
        {
            radius = 0.0;
        }
        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            return $"Center: {base.ToString()}, Radius: {radius}";
        }
    }
}
