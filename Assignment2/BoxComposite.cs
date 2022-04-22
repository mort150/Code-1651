using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class BoxComposite : BoxComponent
    {
        private List<BoxComponent> relates; 
        public BoxComposite(string name) : base(name)
        {
            relates = new List<BoxComponent>();
        }
        public override double Cost()
        {
            double total = Items * PRICE;
            foreach (BoxComponent rel in relates)
            {
                total += rel.Cost();
            }
            return total += total * VAT;
        }
        public void AddRelateBoxes(BoxComponent rel)
        {
            relates.Add(rel);
        }
        public void RemoveRelateBoxes(BoxComponent  rel)
        {
            relates.Remove(rel);
        }
        public void ShowElementBox()
        {
            System.Console.WriteLine("{0} contains box(es): ", Name);
            foreach(BoxComponent box in relates)
            {
                System.Console.WriteLine(box.Name);
            }
        }
    }
}