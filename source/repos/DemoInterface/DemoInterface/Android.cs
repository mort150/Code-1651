using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInterface
{
    public class Android : Mobile, ICharger
    {
        public Android()
        {
            name = "Android phone";
        }

        public void charge()
        {
            Console.WriteLine("Quick charging ... for " + name);
        }
    }
}
