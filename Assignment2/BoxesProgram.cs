using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class BoxesProgram : MenuProgram
    {
        private BoxComposite compositebox;
        private ShowBox showbox = new ShowBox();
        public List<BoxComponent> singleboxes = new List<BoxComponent>();
        public List<BoxComposite> compositeboxes = new List<BoxComposite>();
        protected override void PrintMenu()
        {
            System.Console.WriteLine("\n--------- Menu program --------");
            System.Console.WriteLine("1. Add Single Box");
            System.Console.WriteLine("2. Add Conposite Box");
            System.Console.WriteLine("3. Add boxes into Composite Box");
            System.Console.WriteLine("4. Show Cost");
            System.Console.WriteLine("0. Exit");

        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddLeaf(); break;
                case 2: AddComposite(); break;
                case 3: AddBoxes(); break;
                case 4: ShowAll(); break;
                case 0: System.Console.WriteLine("You've been out of the program!!!"); break;
                default: System.Console.WriteLine("Invalid choice!!!"); break;
            }
        }
        public void AddLeaf()
        {
            System.Console.Write("Enter the name of this single Box: ");
            string name = Console.ReadLine();

            BoxLeaf singlebox = new BoxLeaf(name);
            singlebox.SetAmount();
            System.Console.WriteLine(singlebox);
            singleboxes.Add(singlebox);
            showbox.AddBoxes(singlebox);
        }
        public void AddComposite()
        {
            System.Console.Write("Enter the name of this Composite Box: ");
            string name = Console.ReadLine();

            compositebox = new BoxComposite(name);
            compositebox.SetAmount();
            System.Console.WriteLine(compositebox);
            compositeboxes.Add(compositebox);
            showbox.AddBoxes(compositebox);
        }
        public void AddBoxes()
        {
            bool flag = true;
            bool sign = true;

            System.Console.WriteLine("All Composite Box exist: ");
            if (compositeboxes.Count == 0)
            {
                System.Console.WriteLine("------- Do not have Composite Box yet!!! --------");
                System.Console.WriteLine("------- Pls Go to add Composite Box!!! --------");
            }
            else
            {
                foreach (BoxComposite combox in compositeboxes)
                {
                    System.Console.WriteLine(combox.Name);
                    System.Console.WriteLine("--------*********--------");
                }
                while (flag)
                {
                    System.Console.WriteLine("Which Composite box that you want to add more single box into? ");
                    string compobox = Console.ReadLine();
                    foreach (BoxComposite combox in compositeboxes)
                    {
                        if (compobox == combox.Name)
                        {
                            System.Console.WriteLine("Found the Composite Box that you need! Go to Add more single box into ...");
                            this.compositebox = combox;
                            flag = false;
                        }
                    }
                    if (flag == true)
                    {
                        System.Console.WriteLine("\nNot found the Composite Box that you want!!!");
                        System.Console.WriteLine("-----------------------");
                    }
                }
                while (sign)
                {
                    System.Console.WriteLine("\nAll singleboxes exist:");
                    foreach (BoxComponent sibox in singleboxes)
                    {
                        System.Console.WriteLine("----------------");
                        System.Console.WriteLine(sibox.Name);
                    }
                    System.Console.WriteLine("----------------");
                    System.Console.WriteLine("\nWhich box that you want to add into {0}?", compositebox.Name);
                    string box = Console.ReadLine();
                    foreach (BoxComponent bo in singleboxes)
                    {
                        if (box == bo.Name)
                        {
                            System.Console.WriteLine("\nAdd Successfully!!!");
                            compositebox.AddRelateBoxes(bo);
                            sign = false;
                        }
                    }
                    if (sign == true)
                    {
                        System.Console.WriteLine("\nNot found box!!!");
                        System.Console.WriteLine("-----------------------");
                    }
                }
            }
        }
        public void ShowAll()
        {
            foreach (BoxComposite combox in compositeboxes)
            {
                combox.ShowElementBox();
            }
            showbox.ShowCost();
        }
    }
}