using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankAccount
    {
        private static int count = 0;
        private int id;
        private string pin;
        private double balance;
        public int Id
        {
            get { return id; }
        }

        public string Pin
        {
            get { return pin; }
            set
            {
                value = pin;
            }
        }
        public double Balance
        {
            get { return balance; }
            // set
            // {
            //     if (value < 0 || value > 100000000) System.Console.WriteLine("Invalid Balance!!!");
            //     else value = balance;
            // }
        }
        public BankAccount()
        {
            id = count++;
            pin = "GCH190";
            balance = 0.0;
        }
        public BankAccount(string pin, double balance)
        {
            id = count++;
            this.pin = pin;
            this.balance = 0;
            Deposit(balance);
            // this.balance = balance;
        }
        public void WithDraw(double amount)
        {
            // System.Console.WriteLine("How much money that you want to withdraw? - ");
            if (balance < amount)
            {
                System.Console.WriteLine("This account doesn't have enough money to pay!!!");
            }
            else if (amount <= 0)
            {
                System.Console.WriteLine("Invalid amount!!!");
            }
            else
            {
                balance = balance - amount;
            }
        }
        public void Deposit(double amount)
        {
            if (balance > 100000000 || balance + amount > 100000000 || amount <= 0)
                System.Console.WriteLine("This account has maximum balance!!!");
            else balance = balance + amount;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Bank ID: " + id);
            System.Console.WriteLine("Balance: " + balance);
        }
    }
}