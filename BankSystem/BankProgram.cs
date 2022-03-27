using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankProgram
    {
        private Bank bank;
        public BankProgram()
        {
            
            System.Console.WriteLine("Enter the bank'name: ");
            string name = Console.ReadLine();
            bank = new Bank(name);
        }

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
        private void PrintMenu()
        {
            System.Console.WriteLine(bank.Name + " Manager");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Withdraw");
            System.Console.WriteLine("3. Deposit");
            System.Console.WriteLine("4. Show Account");
        }
        private void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: AddAccount(); break;
                case 2: WithDraw(); break;
                case 3: Deposit(); break;
                case 4: ShowAccount(); break;
            }
        }
        private int GetChoice()
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        private void AddAccount()
        {
            System.Console.WriteLine("Enter account PIN: ");
            string pin = Console.ReadLine();
            System.Console.WriteLine("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            BankAccount acc = new BankAccount(pin, balance);
            bank.AddAccount(acc);
            acc.ShowInfo();
        }

        private void WithDraw()
        {
            System.Console.WriteLine("Enter account ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter account PIN: ");
            string pin = Console.ReadLine();
            System.Console.WriteLine("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            bank.WithDraw(id, pin, amount);
            bank.ShowAccount(id);
        }

        private void Deposit()
        {
            System.Console.WriteLine("Enter account ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter account PIN: ");
            string pin = Console.ReadLine();
            System.Console.WriteLine("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            bank.Deposit(id, pin, amount);
            bank.ShowAccount(id);
        }
        private void ShowAccount()
        {
            System.Console.WriteLine("Enter account ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bank.ShowAccount(id);
        }
    }
}