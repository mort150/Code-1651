using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class BoxLeaf : BoxComponent
    {
            public BoxLeaf(string name) : base(name)
            {

            }
        public override double Cost()
        {
            return Items * PRICE;
        }
    }
}