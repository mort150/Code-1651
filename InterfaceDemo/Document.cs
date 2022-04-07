using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Document : IPrintable
    {
        public string Content { get; set; }
        public Document()
        {
            Content = "Empty";
        }
        public Document(string name)
        {
            Content = name;
        }
        public void Print()
        {
            System.Console.WriteLine(Content);
        }
    }
}