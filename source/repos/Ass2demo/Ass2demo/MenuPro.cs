using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2demo
{
    public abstract class MenuPro
    {
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) running = false;
            }
        }

        protected int GetChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        protected abstract void DoTask(int choice); 
        protected abstract void PrintMenu();        


    }
}
