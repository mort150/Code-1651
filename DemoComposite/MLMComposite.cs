using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class MLMComposite : MLMComponent
    {
        public List<MLMComponent> references = new List<MLMComponent>();
        public MLMComposite(string name) : base(name)
        {

        }
        public override double Salary()
        {
            double total = Products * INTEREST;
            foreach (MLMComponent re in references)
            {
                total += COMMISSION * re.Salary();
            }
            return total;
        }
        public void AddReferences(MLMComponent re)
        {
            references.Add(re);
        }
        public void RemoveReferences(MLMComponent re)
        {
            references.Remove(re);
        }

    }
}