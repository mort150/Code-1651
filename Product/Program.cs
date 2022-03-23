using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager m = new ProductManager();
            //print menu
            System.Console.WriteLine("---------Product Manager----------");
            System.Console.WriteLine("1. Add new product.");
            System.Console.WriteLine("2. Edit product.");
            System.Console.WriteLine("3. Delete product.");
            System.Console.WriteLine("4. Show all products.");
            System.Console.WriteLine("0. Out the program.");


            //ask user to enter a choice
            System.Console.WriteLine("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1: m.AddProduct(); break;
                case 2: m.EditProduct(); break;
                case 3: m.DeleteProduct(); break;
                case 4: m.ShowProducts(); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid choice!!!"); break;
            }
        }
    }
}
