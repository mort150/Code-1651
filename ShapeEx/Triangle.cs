using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class Triangle : Shape
    {
        private int sideA;
        private int sideB;
        private int sideC;
        public int SideA{
            get { return sideA; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid sideA!!!");
                else sideA = value;
            }
        }
        public int SideB{
            get { return sideB; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid sideB!!!");
                else sideB = value;
            }
        }
        public int SideC{
            get { return sideC; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid sideC!!!");
                else sideC = value;
            }
        }
        public Triangle() : base("Triangel")
        {
            sideA = 1;
            sideB = 1;
            sideC = 1;
        }
        public Triangle(string name, int a, int b, int c) : base(name)
        {
            Name = name;
            SideA = a;
            SideB = b;
            SideC = c;
        }
        public override double Area()
        {
            int p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}