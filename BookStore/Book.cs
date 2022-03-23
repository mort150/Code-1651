using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        private string title;
        private int page;
        private double price;

        public string Title
        {
            get { return title; }
            set
            {
                if (value == "")
                {
                    System.Console.WriteLine("Invalid title!!!");
                }
                else
                {
                    title = value;
                }
            }
        }
        public int Page
        {
            get { return page; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Invalid title!!!");
                }
                else
                {
                    page = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Invalid price!!!");
                }
                else
                {
                    price = value;
                }
            }
        }
        public Book()
        {
            title = "Book 01";
            page = 10;
            price = 1.0;
        }
        public Book(string title, int page, double price)
        {
            Title = title;
            Page = page;
            Price = price;
        }
        public void InfoBook()
        {
            System.Console.WriteLine("Name of Book: " + title);
            System.Console.WriteLine("Page of Book: " + page);
            System.Console.WriteLine("Price of Book: " + price);
        }
    }
}