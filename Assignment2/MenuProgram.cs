using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class MenuProgram
    {
        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }
        protected int GetChoice()
        {
            // System.Console.WriteLine("Take your choice, pls: ");
            // int choice = Convert.ToInt32(Console.ReadLine());
            int choice = Utils.GetInteger("\nTake your choice, pls: ");
            return choice;
        }
        protected abstract void DoTask(int choice);

        protected abstract void PrintMenu();
    }
}