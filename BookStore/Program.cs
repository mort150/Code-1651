using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Hehe", 100, 50.3);
            b1.InfoBook();
            while (true)
            {
                BookManager bm = new BookManager();
                System.Console.WriteLine("-------- Book Manager --------");
                System.Console.WriteLine("1. Add new Book");
                System.Console.WriteLine("2. Edit Book");
                System.Console.WriteLine("3. Selled Book");
                System.Console.WriteLine("4. All Books");
                System.Console.WriteLine("0. Exit!!!");

                System.Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: bm.AddBook(); break;
                    case 2: bm.EditBook(); break;
                    case 3: bm.SellBook(); break;
                    case 4: bm.ShowAllBook(); break;
                    case 0: System.Console.WriteLine("You've been out of the program!!! See Ya!!!"); break;
                    default: System.Console.WriteLine("Invalid choice!!!"); break;
                }
            }
        }
    }
}
