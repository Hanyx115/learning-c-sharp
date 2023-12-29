using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3s4
{
    public class Shape
    {
        private float length;
        private float width;
        public float Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length must be a non-negative value.");
                }
            }
        }

        public float Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width must be a non-negative value.");
                }
            }
        }
        public string CheckShapeType()
        {
            if (length == width)
            {
                return "Square";
            }
            else
            {
                return "Rectangle";
            }
        }
        public static Shape operator +(Shape shape1, Shape shape2)
        {
            Shape newShape = new Shape
            {
                Length = shape1.Length + shape2.Length,
                Width = shape1.Width + shape2.Width
            };
            return newShape;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
