using System;

namespace Asignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart bag = new Cart("Bag", 100);
            SpecificProduct apple = new SpecificProduct("Apple", 256);
            SpecificProduct coconut = new SpecificProduct("Coconut", 500);
            apple.Add(coconut);
            Console.WriteLine();
            apple.CalculateTotalPrice();
            Console.WriteLine();
            bag.Add(apple);
            bag.Add(coconut);
            bag.Delete(apple);
            bag.CalculateTotalPrice();
            Console.WriteLine();


            Cart cart = new Cart("Cart", 0);
            SpecificProduct lemon = new SpecificProduct("Lemon", 100);
            SpecificProduct orange = new SpecificProduct("Orange", 250);
            cart.Add(lemon);
            cart.Add(orange);

            Cart box = new Cart("Box", 0);
            SpecificProduct candy = new SpecificProduct("Candy", 100);
            SpecificProduct icecream = new SpecificProduct("Ice Ceam", 500);
            box.Add(candy);
            box.Add(icecream);
            cart.Add(box);


            Console.WriteLine("Total price that you have to pay is " + cart.CalculateTotalPrice());


            Console.ReadKey();
        }
    }
}
