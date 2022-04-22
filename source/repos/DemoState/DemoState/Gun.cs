using System;
using System.Collections.Generic;
using System.Text;

namespace DemoState
{
    public abstract class Gun
    {
        public abstract void Fire(int nBullets);
    }

    public class SmallGun : Gun
    {
        public override void Fire(int nBullets)
        {
            for (int i = 0; i < nBullets; i++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    public class BigGun : Gun
    {
        public override void Fire(int nBullets)
        {
            for (int i = 0; i < nBullets; i++)
                Console.Write("O");
            Console.WriteLine();
        }
    }

    public class SuperGun : Gun
    {
        public override void Fire(int nBullets)
        {
            for (int i = 0; i < nBullets; i++)
                Console.Write("<@>");
            Console.WriteLine();
        }
    }
}
