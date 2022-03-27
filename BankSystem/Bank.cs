using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Bank
    {
        private string name;
        private List<BankAccount> listBAs = new List<BankAccount>();
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid name!!!");
                else value = name;
            }
        }
        public Bank(string name)
        {
            Name = name;
        }
        public void AddAccount(BankAccount acc)
        {
            listBAs.Add(acc);
        }
        public BankAccount FindAccount(int id)
        {
            foreach (BankAccount b in listBAs)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }
            return null;
        }
        public void WithDraw(int id, string pin, double amount)
        {
            BankAccount acc = FindAccount(id);
            if (acc == null) System.Console.WriteLine("Account not found!!");
            else if (acc.Pin != pin) System.Console.WriteLine("Incorrect PIN!!!");
            else acc.WithDraw(amount);
        }
        public void Deposit(int id, string pin, double amount)
        {
            BankAccount acc = FindAccount(id);
            if (acc == null) System.Console.WriteLine("Account not found!!");
            else if (acc.Pin != pin) System.Console.WriteLine("Incorrect PIN!!!");
            else acc.Deposit(amount);
        }
        public void ShowAccount(int id)
        {
            foreach (BankAccount b in listBAs) b.ShowInfo();
        }
    }
}