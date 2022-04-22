using System;
using System.Collections.Generic;
using System.Text;

namespace DemoState
{
    public class Player
    {
        private Gun gun;
        private int level;

        public Player()
        {
            level = 1;
            gun = new SmallGun();
        }

        public void Play()
        {

            Move();

            level++;
            Console.WriteLine("Level up! Current level: " + level);
            gun = new BigGun();
            Console.ReadKey();

            Move();

            level++;
            Console.WriteLine("Level up! Current level: " + level);
            gun = new SuperGun();
            Console.ReadKey();

            Move();

        }

        private void Move()
        {
            Console.WriteLine("Walking around ...");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("See monsters ...");
                gun.Fire(5);
            }
        }
    }
}
