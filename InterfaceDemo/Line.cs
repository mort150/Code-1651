using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Line : Shape
    {
        public int Length { get; set; }
        public Line() : base("Line")
        {
            Length = 1;
        }
        public Line(string name, int lenght) : base(name)
        {
            Name = name;
            Length = lenght;
        }
        public override void Print()
        {
            base.Print();
            for(int i = 0; i < Length; i++){
                Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}