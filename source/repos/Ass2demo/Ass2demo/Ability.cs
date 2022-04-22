using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2demo
{
    public class Ability 
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
                    Console.WriteLine("Invalid format. Please try again.");
                }
            }
            return n;
        }

        public static ProductProgram GetCombo(string message)
        {
            Console.WriteLine(message);

            string n = Convert.ToString(Console.ReadLine());

            int p = 0;

            while (p == 0)
            {
                p = GetInteger("Enter price: ");
                if (p == 0) Console.WriteLine("The price must not be less than or equal to zero. Pls enter again!!");
            }
            return new ProductProgram(n,p);
        }

    }
}
