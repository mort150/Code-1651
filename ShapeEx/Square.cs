using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class Square : Rectangle
    {
        public Square() : base("Square", 1, 1)
        {

        }
        public Square(string name, int side) : base(name, side,side)
        {
        }
    }
}