using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionEx
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
        public int GetChoice()
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public abstract void PrintMenu();
        public abstract void DoTask(int choice);
    }
}