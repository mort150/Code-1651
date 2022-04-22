using System;

namespace DemoComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            MLMLeaf marry = new MLMLeaf("Marry");
            marry.Sale();

            MLMComposite linda = new MLMComposite("Linda");
            linda.Sale();
            linda.AddReferences(marry);

            MLMLeaf kay = new MLMLeaf("Kay");
            kay.Sale();

            MLMComposite paul = new MLMComposite("Paul");
            paul.Sale();
            paul.AddReferences(linda);
            paul.AddReferences(kay);

            MLMLeaf musk = new MLMLeaf("Musk");
            marry.Sale();
            MLMLeaf steve = new MLMLeaf("Steve");
            marry.Sale();
            MLMComposite mike = new MLMComposite("Mike");
            paul.Sale();
            paul.AddReferences(musk);
            paul.AddReferences(steve);

            MLMLeaf anne = new MLMLeaf("Anne");
            marry.Sale();
            MLMComposite tom = new MLMComposite("Tom");
            paul.Sale();
            paul.AddReferences(anne);

            MLMComposite john = new MLMComposite("John");
            john.AddReferences(paul);
            john.AddReferences(mike);
            john.AddReferences(tom);

            MLMCompany armway = new MLMCompany();
            armway.AddEmployees(john);
            armway.AddEmployees(paul);
            armway.AddEmployees(mike);
            armway.AddEmployees(tom);
            armway.AddEmployees(linda);
            armway.AddEmployees(kay);
            armway.AddEmployees(musk);
            armway.AddEmployees(steve);
            armway.AddEmployees(anne);
            armway.AddEmployees(marry);

            armway.PaySalaries();
        }
    }
}
