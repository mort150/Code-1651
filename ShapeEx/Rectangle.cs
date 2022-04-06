using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid Width!!!");
                else width = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid Height!!!");
                else height = value;
            }
        }

        public Rectangle() : base("Rectangle")
        {
            width = 1;
            height = 1;
        }
        public Rectangle(string name, int width, int height) : base(name)
        {
            Name = name;
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return (Width + Height) * 2;
        }
    }
}