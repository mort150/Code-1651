using System;
namespace DemoInterface
{
    public class Iphone : Mobile, ICharger
    {
        public Iphone()
        {
            name = "Iphone";
        }

        public void charge()
        {
            Console.WriteLine(name + " Smart charging ...");
        }
    }
}
