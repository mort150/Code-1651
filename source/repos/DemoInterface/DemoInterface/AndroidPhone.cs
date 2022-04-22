using System;
namespace DemoInterface
{
    public class AndroidPhone : Mobile, ICharger
    {
        public AndroidPhone()
        {
            name = "Android phone";
        }

        public void charge()
        {
            Console.WriteLine("Quick charging ... for " + name);
        }
    }
}
