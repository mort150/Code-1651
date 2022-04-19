using System;

namespace DemoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printer p1 = Printer.GetSpooler();
            // Printer p2 = Printer.GetSpooler();
            // Printer p3 = Printer.GetSpooler();

            Computer c1 = new Computer("HP");
            Computer c2 = new Computer("Mac");
            Computer c3 = new Computer("Server");

            Document d1 = new Document("Assignment1.docx", 30);
            Document d2 = new Document("Presentation.pptx", 50);
            Document d3 = new Document("MyNovel.docx", 1050);
            Document d4 = new Document();

            c1.Print(d1);
            System.Console.WriteLine();
            c1.Print(d2);
            System.Console.WriteLine();
            c2.Print(d4);
            System.Console.WriteLine();
            c3.Print(d3);
            System.Console.WriteLine();
                
            System.Console.Write("Enter the number of pages to add: ");
            int pages = int.Parse(System.Console.ReadLine());
            Printer spooler = Printer.GetSpooler();
            spooler.AddPages(pages);

            c3.Print(d3);
        }
    }
}
