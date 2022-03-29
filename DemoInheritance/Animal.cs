using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Animal
    {
        private string kind;
        private int age;

        public string Kind
        {
            get { return kind; }
            set
            {
                kind = value;
            }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Kind of animal: " + kind);
            System.Console.WriteLine("Age of animal: " + age);
            System.Console.WriteLine("--------==========----------");
        }
        public Animal()
        {
            kind = "Unknown";
            age = 1;
            System.Console.WriteLine("Default contructor");
        }
        public Animal(string kind, int age)
        {
            Kind = kind;
            Age = age;
            System.Console.WriteLine("Parameter contructor");

        }
    }
}