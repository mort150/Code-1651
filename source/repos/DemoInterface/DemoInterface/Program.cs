using System;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone xs = new Iphone();
            AndroidPhone galaxy = new AndroidPhone();
            ECigarette vape = new ECigarette();
            Beat dj = new Beat();

            ICharger[] devices = { xs, galaxy, vape, dj};

            for (int i = 0; i < devices.Length; i++)
            {
                devices[i].charge();
            }
        }
    }
}
