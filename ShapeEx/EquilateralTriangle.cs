using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class EquilateralTriangle : Shape
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
        public EquilateralTriangle() : base("Square")
        {
            side = 1;
        }
        public EquilateralTriangle(string name, int side) : base(name)
        {
            Name = name;
            Side = side;
        }
        public override double Area()
        {
            return Math.Sqrt(3)/4 * Math.Pow(Side, 2);
        }
        public override double Perimeter()
        {
            return Side * 3;
        }
    }
}