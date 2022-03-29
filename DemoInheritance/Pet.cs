using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Pet : Animal
    {
        private string owner;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public Pet() : base("Pet", 2)
        {
            // Kind = "Pet";
            // Age = 2;
            owner = "Human";
            System.Console.WriteLine("Pet default");
        }
        public Pet(string kind, int age, string owner) : base(kind, age)
        {
            // Kind = kind;
            // Age = age;
            Owner = owner;
            // System.Console.WriteLine("Parameter Pet");
        }

        public void PetInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Pet owner: " + owner);
        }
    }
}