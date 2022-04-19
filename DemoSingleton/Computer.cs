using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class Computer
    {
        public string Name { get; set; }
        public Computer(string name)
        {
            Name = name;
        }
        public void Print(Document doc)
        {
            System.Console.WriteLine("Computer {0} is printing document: {1}", Name, doc.Name);
            Printer spooler = Printer.GetSpooler();
            spooler.Print(doc);
        }
    }
}