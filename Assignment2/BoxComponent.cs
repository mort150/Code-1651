using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class BoxComponent
    {
        protected string name;
        protected int items;
        public const double PRICE = 10000;
        public const double VAT = 0.1;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    System.Console.WriteLine("Invalid name!!!");
                    name = "Default box";
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Items
        {
            get { return items; }
            set
            {
                if (value <= 0) System.Console.WriteLine("Invalid number of items!!!");
                else items = value;
            }
        }
        public BoxComponent()
        {
            name = "Empty Box";
            items = 0;
        }
        public BoxComponent(string name)
        {
            Name = name;
            Items = 1;
        }
        public abstract double Cost();
        public void SetAmount()
        {
            // System.Console.WriteLine("Enter the number of item(s) in {0}: ", Name);
            // Items = Convert.ToInt32(Console.ReadLine());
            Items = Utils.GetInteger("\nEnter the number of items in this " + Name + " : ");
        }
        public override string ToString()
        {
            return "\nName: " + Name + "-" + " Amount of items: " + Items;
        }
    }
}