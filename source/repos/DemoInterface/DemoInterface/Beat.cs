using System;
namespace DemoInterface
{
    public class Beat : ICharger
    {
        public Beat()
        {
        }

        public void charge()
        {
            Console.WriteLine("Charging...");
        }
    }
}
