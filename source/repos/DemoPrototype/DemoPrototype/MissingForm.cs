using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPrototype
{
    public class MissingForm : Form
    {
        public string Who { get; set; }
        public MissingForm()
        {
            Who = "......";
        }

        public override Form CreateTemplate()
        {
            MissingForm clone = new MissingForm();
            clone.From = From;
            clone.To = To;
            clone.Header = Header;
            clone.Footer = Footer;
            clone.Content = Content;
            clone.Who = Who;

            return clone;
        }
        public override void print()
        {
            Console.WriteLine(Header);
            Console.WriteLine("From: " + From);
            Console.WriteLine("To: " + To);
            Console.WriteLine("Reason: Missing " + Who);
            Console.WriteLine(Content);
            Console.WriteLine(Footer);
        }
    }
}
