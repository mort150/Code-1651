using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Shape : IPrintable
    {
        public string Name { get; set; }
        public Shape()
        {
            Name = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            System.Console.WriteLine(Name);
        }
    }
}