using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPrototype
{
    public abstract class Form
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Content { get; set; }

        public abstract Form CreateTemplate();
        public Form()
        {
            From = "....";
            To = "....";
            Header = "Cong Hoa Xa Hoi Chu Nghia Viet Nam";
            Footer = "Ha Noi, ngay ... thang ... nam ... \n Nguoi viet don";
            Content = ".....................";
        }

        public virtual void print()
        {
            Console.WriteLine(Header);
            Console.WriteLine("From: " + From);
            Console.WriteLine("To: " + To);
            Console.WriteLine(Content);
            Console.WriteLine(Footer);
        }
    }
}
