using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSingleton
{
    public class Document
    {
        public int Pages { get; set; }
        public string Name { get; set; }
        public Document()
        {
            Pages = 500;
            Name = "Document.docx";
        }
        public Document(string name, int pages)
        {
            Pages = pages;
            Name = name;
        }
    }
}