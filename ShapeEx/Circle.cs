using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class Circle : Shape
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid Radius!!!");
                else radius = value;
            }
        }
        public Circle() : base("Circle")
        {
            radius = 1;
        }
        public Circle(string name, int radius) : base(name)
        {
            Name = name;
            Radius = radius;
        }
        public override double Area()
        {
            // return 3.14 * Radius * Radius;
            return 3.14 * Math.Pow(Radius,2);
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}