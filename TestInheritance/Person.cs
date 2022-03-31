using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class Person
    {
        protected string name;
        protected int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid name!!!");
                else name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 50) System.Console.WriteLine("Invalid age!!!");
                else age = value;
            }
        }
        public Person()
        {
            name = "Person";
            age = 18;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void ShowInfo()
        {
            System.Console.WriteLine("----====***====----");
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Age: " + age);
        }
    }
}