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
        public int SideA
        {
            get { return sideA; }
            set
            {
                if (!IsValid(value, sideB, sideC))
                    System.Console.WriteLine("Invalid sideA!!!");
                else sideA = value;
            }
        }
        public int SideB
        {
            get { return sideB; }
            set
            {
                if (!IsValid(sideA, value, sideC)) System.Console.WriteLine("Invalid sideB!!!");
                else sideB = value;
            }
        }
        public int SideC
        {
            get { return sideC; }
            set
            {
                if (!IsValid(sideA, sideB, value)) System.Console.WriteLine("Invalid sideC!!!");
                else sideC = value;
            }
        }
        public Triangle() : base("Triangle")
        {
            sideA = 1;
            sideB = 1;
            sideC = 1;
        }
        public Triangle(string name, int a, int b, int c) : base(name)
        {
            if (!IsValid(a, b, c))
            {
                System.Console.WriteLine("Invalid sides!!!");
                sideA = 1;
                sideB = 1;
                sideC = 1;
            }
            else
            {
                sideA = a;
                sideB = b;
                sideC = c;
            }
            Name = name;
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
        private bool IsValid(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return false;
            if (a + b <= c || a + c <= b || b + c <= a) return false;
            return true;
        }
    }
}