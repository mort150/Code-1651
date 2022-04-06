using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random a = new Random();
            // System.Console.WriteLine("Random number is: " + a.Next(10));
            Game guessing = new Game();
            guessing.Play();
            
        }
    }
}
