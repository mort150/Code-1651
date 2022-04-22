using System;

namespace June102021
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nproducts = 100;
            int [] prices = new int[nproducts];
            int count = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter product price: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    if (price <= 0 || count == 100) break;
                    prices[count++] = price;

                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input price!!! Try again!!!");
                }
            }

            Console.WriteLine("Total " + count + " products");

            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += prices[i];
            }
            if (count > 0)
            {
                double avg = (double) sum / count;
                Console.WriteLine("Sum prices: " + sum);
                Console.WriteLine("Average price: " + avg);
            }
            else
            {
                Console.WriteLine("No products!!!");
            }
            

            
        }
    }
}
