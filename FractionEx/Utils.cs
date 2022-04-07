using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionEx
{
    public class Utils
    {
        public static int GetInteger(string a)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    System.Console.WriteLine(a);
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Invalid format type, enter again!!!");
                }
            }
            return n;
        }

        public static int GetIntegerDifZero(string a)
        {
            int n = 1;
            while (true)
            {
                try
                {
                    System.Console.WriteLine(a);
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n != 0) break;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Invalid format type, enter again!!!");
                }
                catch (Exception)
                {
                    System.Console.WriteLine("The Demoninator must not be Zero, enter again!!!");
                }
            }
            return n;
        }
    }
}