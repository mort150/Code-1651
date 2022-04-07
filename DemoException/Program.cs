using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 1;
            try
            {
                // System.Console.Write("Enter a number n: ");
                // n = int.Parse(Console.ReadLine());
                // System.Console.Write("Enter a number m: ");
                // m = int.Parse(Console.ReadLine());

                n = Utils.GetInteger("Enter n: ");
                m = Utils.GetInteger("Enter m: ");

                int p = n / m;
                System.Console.WriteLine("Result: {0} / {1} = {2} ", n, m, p);

            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("Division Error: " + e.Message);
            }
            // Console.WriteLine("n = " + n);
            Console.WriteLine("Program ends!!!");
        }
    }
}
