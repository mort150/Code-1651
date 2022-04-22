using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Utils
    {
        public static int GetInteger(string prompt)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    System.Console.Write(prompt);
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Invalid number, try again!!!");
                }
            }
            return n;
        }
    }
}