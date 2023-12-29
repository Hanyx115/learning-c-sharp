using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1s7
{
    class Rectangle
    {
        private float _base;
        private float _height;

        public float Base
        {
            get { return _base; }
            set
            {
                if (value >= 0.0)
                {
                    _base = value;
                }
            }
        }

        public float Height
        {
            get { return _height; }
            set
            {
                if (value >= 0.0)
                {
                    _height = value;
                }
            }
        }

        public Rectangle(float baseValue, float height)
        {
            Base = baseValue;
            Height = height;
        }

        public virtual float Area()
        {
            return Base * Height;
        }

        public virtual void Shape()
        {
            Console.WriteLine("Shape: Rectangle");
        }

        public override string ToString()
        {
            return $"Base: {_base}, Height: {_height}";
        }
    }

    class Parallelogram : Rectangle
    {
        public Parallelogram(float baseValue, float height) : base(baseValue, height)
        {
        }

        public override void Shape()
        {
            Console.WriteLine("Shape: Parallelogram");
        }
    }

    class Trapezium : Rectangle
    {
        private float _base2;

        public float Base2
        {
            get { return _base2; }
            set
            {
                if (value >= 0.0)
                {
                    _base2 = value;
                }
            }
        }

        public Trapezium(float baseValue, float height, float base2) : base(baseValue, height)
        {
            Base2 = base2;
        }

        public override void Shape()
        {
            Console.WriteLine("Shape: Trapezium");
        }

        public override float Area()
        {
            return (Base + Base2) / 2 * Height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Base2: {_base2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
