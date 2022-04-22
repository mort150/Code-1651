using System;
using System.Collections.Generic;
using System.Text;

namespace June82021
{
    class DemoninatorIsZeroException : Exception
    {
        public DemoninatorIsZeroException()
        {

        }
        public DemoninatorIsZeroException(string message) : base (message)
        {

        }
    }
}
