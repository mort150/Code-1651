using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2demo
{
    public abstract class ProductProgram : MenuPro
    {
        protected string name;
        protected int price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (price <= 0) throw new FormatException("The price must not be less than or equal to zero. Pls enter again!!! ");
                else price = value;
            }
        }
        public ProductProgram()
        {
            name = "unknown";
            price = 1;
        }
        public ProductProgram(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Add(ProductProgram p);
        public abstract void Delete(ProductProgram p);
        public abstract int CalculateTotalPrice();
   
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: Buyone(); break;
                case 2: Buymore(); break;
                case 3: Total(); break;
                case 0: break;
                default: Console.WriteLine("Invalid choice!"); break;
            }           
        }
        private void Buyone()
        {
            throw new NotImplementedException();
        }
        private void Buymore()
        {
            throw new NotImplementedException();
        }
        private void Total()
        {
            throw new NotImplementedException();
        }

        protected override void PrintMenu()
        {
            Console.WriteLine("1. Buy a specific product.");
            Console.WriteLine("2. Buy a pack of many products");
            Console.WriteLine("3. Total price of products that just been bought.");
            Console.WriteLine("0. Exit");
        }
    }
}
