using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Square("ABC", 4);
            // s.Print();
            List<IPrintable> printables = new List<IPrintable>();

            printables.Add(new Line("Line", 10));
            printables.Add(new Line("Line", 20));
            printables.Add(new Square("Square", 5));
            printables.Add(new Document("Hello Interface"));

            foreach(IPrintable i in printables) i.Print();
        }
    }
}
