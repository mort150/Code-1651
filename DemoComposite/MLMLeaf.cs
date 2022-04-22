using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class MLMLeaf : MLMComponent
    {
        public MLMLeaf(string name) : base(name)
        {

        }
        public override double Salary()
        {
            return Products * INTEREST;
        }
    }
}