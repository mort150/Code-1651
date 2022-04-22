using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee();
            Employee em2 = new Employee();
            Employee em3 = new Employee("Thanh", 1.5);

            em1.ShowInfo();
            em3.ShowInfo();
        }
    }
}
