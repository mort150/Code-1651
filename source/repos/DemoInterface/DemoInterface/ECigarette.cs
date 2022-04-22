using System;
namespace DemoInterface
{
    public class ECigarette : ICharger
    {
        public ECigarette()
        {
        }

        public void charge()
        {
            Console.WriteLine("Slow charging ...");
        }
    }
}
