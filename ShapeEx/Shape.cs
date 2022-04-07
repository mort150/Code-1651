using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public abstract class Shape
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") throw new Exception("Invalid Name!!!");
                else name = value;
            }
        }
        public Shape()
        {
            name = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public override string ToString()
        {
            return "Shape: " + Name + "\nPerimeter: " + Perimeter() + "\nArea: " + Area() + "\n-----------************-----------";
        }
    }
}