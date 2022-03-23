using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookManager
    {
        private List<Book> lbooks;
        public BookManager()
        {
            lbooks = new List<Book>();
        }
        public void AddBook()
        {
            System.Console.WriteLine("Enter the title of Book: ");
            string title = Console.ReadLine();
            System.Console.WriteLine("Enter the number of pages of this Book: ");
            int page = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the price of Book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Book b = new Book(title, page, price);
            lbooks.Add(b);
        }
        public void SellBook()
        {
            System.Console.WriteLine("Enter the title of Book: ");
            string title = Console.ReadLine();
            Book b = FindBook(title);
            if (b == null)
            {
                System.Console.WriteLine("Book not found!!!");
            }
            else
            {
                lbooks.Remove(b);
            }
        }
        public void EditBook()
        {
            System.Console.WriteLine("Enter the title of Book: ");
            string title = Console.ReadLine();
            Book b = FindBook(title);
            if (b == null)
            {
                System.Console.WriteLine("Book not found!!!");
            }
            else
            {
                System.Console.WriteLine("Enter the number of pages of this Book: ");
                int page = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter the price of Book: ");
                double price = Convert.ToDouble(Console.ReadLine());
                b.Page = page;
                b.Price = price;
            }
        }
        public void ShowAllBook()
        {
            for(int i =0; i < lbooks.Count; i++){
                lbooks[i].InfoBook();
            }
            // foreach (Book b in lbooks)
            // {
            //     b.InfoBook();
            // }
        }
        public Book FindBook(string name)
        {
            for (int i = 0; i < lbooks.Count; i++)
            {
                if (lbooks[i].Title == name)
                {
                    return lbooks[i];
                }
            }
            return null;
        }
    }
}