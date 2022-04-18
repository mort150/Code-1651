using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class AttendanceMachine
    {
        public void Swipe()
        {
            Console.WriteLine("Pls swipe the card ... ");
            Console.ReadLine();
            System.Console.WriteLine("Reading card ...");
            Console.ReadLine();
            System.Console.WriteLine("Card read succesfully ...");
            Console.ReadLine();
            System.Console.WriteLine("Welcome employee ... Have a great day!!!");
        }
    }
}