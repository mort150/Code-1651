using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ShowBox
    {
        private List<BoxComponent> boxes = new List<BoxComponent>();
        public void AddBoxes(BoxComponent bes)
        {
            boxes.Add(bes);
        }
        public void ShowCost()
        {
            foreach (BoxComponent bes in boxes)
            {
                System.Console.WriteLine("\n{0} costs {1} VND!", bes.Name, bes.Cost());
            }
        }
    }
}