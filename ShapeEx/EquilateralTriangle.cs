using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeEx
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle() : base("EquilateralTriangle", 1, 1, 1)
        {

        }
        public EquilateralTriangle(string name, int side) : base(name, side, side, side)
        {

        }
    }
}