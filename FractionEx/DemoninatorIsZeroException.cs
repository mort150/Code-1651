using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionEx
{
    public class DemoninatorIsZeroException : Exception
    {
        public DemoninatorIsZeroException()
        {

        }
        public DemoninatorIsZeroException(string msg) : base(msg)
        {

        }
    }
}