using System;
using System.Collections.Generic;
using System.Text;

namespace June82021
{
    class MyUtils
    {
        public static int GetInteger(string message)
        {

            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format! Please type again.");
                }
            }
            return n;

        }
        public static Fraction GetFraction(string message)
        {
            Console.WriteLine(message);
            int n = GetInteger("Enter numerator: ");

            int d = 0;
            while (d == 0)
            {
                d = GetInteger("Enter demoninator: ");
                if (d == 0) Console.WriteLine("Demoninator must not be zero. PLease try again.");
            }
            

            return new Fraction(n, d);
        }
    }
}
