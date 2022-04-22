using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, k = 1, d = 1;
            try
            {
                Console.Write("Enter n: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("n = " + n);

                Console.Write("Enter k: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("k = " + k);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid numbr format!!!");
            }

            try
            {
                d = n / k;
                Console.WriteLine("d = " + d);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("k can not be zero!!!");
            }
            Console.ReadKey();
        }
    }
}
