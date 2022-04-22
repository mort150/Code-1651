using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public abstract class MLMComponent
    {
        protected int products;
        protected string name;
        public const double INTEREST = 50;
        public const double COMMISSION = 0.2;
        public int Products
        {
            get { return products; }
            set { products = value; }

        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Name!!!");
                else name = value;
            }
        }
        public MLMComponent(string name)
        {
            Name = name;
            Products = 1;
        }
        public abstract double Salary();
        public void Sale()
        {
            System.Console.WriteLine("Enter the number of sale product(s) that {0} sells: ", Name);
            Products = int.Parse(System.Console.ReadLine());
        }

    }
}