using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class Square : Shape
    {
        private int side;
        public int Side
        {
            get { return side; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid Side!!!");
                else side = value;
            }
        }
        public Square() : base("Square")
        {
            side = 1;
        }
        public Square(string name, int side) : base(name)
        {
            Name = name;
            Side = side;
        }
        public override double Area()
        {
            return Math.Pow(Side,2);
        }
        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}