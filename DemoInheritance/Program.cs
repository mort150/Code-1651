using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal a = new Animal("Tiger", 2);
            // System.Console.WriteLine("Enter the kind: ");
            // string kind = Console.ReadLine();
            // System.Console.WriteLine("Enter the age: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Animal b = new Animal(kind, age);

            // a.ShowInfo();
            // b.ShowInfo();

            Pet cat = new Pet();
            cat.ShowInfo();

            cat = new Pet("Cat", 6, "Thanh");
            cat.PetInfo();

            Pet dog = new Pet("Dog", 4 , "John");
            dog.PetInfo();
        }
    }
}
