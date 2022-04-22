using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class MLMCompany
    {
        public List<MLMComponent> employees = new List<MLMComponent>();
        public void AddEmployees(MLMComponent emp)
        {
            employees.Add(emp);
        }

        public void PaySalaries()
        {
            // double earns = 0;
            foreach (MLMComponent emp in employees)
            {
                double salary = emp.Salary() * (1 - MLMComponent.COMMISSION);
                System.Console.WriteLine("{0} earns {1}", emp.Name, salary);
            }

            MLMComponent founder = employees[0];
            double comEarns = founder.Salary() + MLMComponent.COMMISSION;
            System.Console.WriteLine("Company earns {0}", comEarns);
        }
    }
}