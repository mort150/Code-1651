using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class Printer
    {
        private int pages;
        private static Printer spooler;
        private Printer()
        {
            pages = 1000;
        }
        public void Print(Document doc)
        {
            System.Console.WriteLine("Printing document: {0}", doc.Name);
            System.Console.WriteLine("Curernt pages of Printer: {0}", pages);
            System.Console.WriteLine("Number of pages to print:{0} ", doc.Pages);
            if (pages < doc.Pages)
            {
                doc.Pages -= pages;
                pages = 0;
                System.Console.WriteLine("Not enough pages. Add more (at least {0}) pages!!!", doc.Pages);
            }
            else
            {
                pages -= doc.Pages;
            }
            System.Console.WriteLine("Done!!!");
            System.Console.WriteLine("Pages left: {0}", pages);
        }
        public static Printer GetSpooler()
        {
            if (spooler == null)
            {
                System.Console.WriteLine("Connecting to a printer ... ");
                spooler = new Printer();
            }
            System.Console.WriteLine("Spooler connected!!!");
            return spooler;
        }
        public void AddPages(int pages)
        {
            this.pages += pages;
        }
    }
}