using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionEx
{
    public class DemoFraction : MenuProgram
    {
        private Fraction f1;
        private Fraction f2;


        public DemoFraction()
        {
            f1 = new Fraction();
            f2 = new Fraction();
        }
        private void EnterFraction()
        {
            try
            {
                System.Console.WriteLine("Enter Fraction 1");
                int num = Utils.GetInteger("Enter Numerator of Fraction 1: ");
                int dem = Utils.GetIntegerDifZero("Enter Demoninator of Fraction 1: ");
                f1 = new Fraction(num, dem);

                System.Console.WriteLine("Enter Fraction 2");
                int a = Utils.GetInteger("Enter Numerator of Fraction 2: ");
                int b = Utils.GetIntegerDifZero("Enter Demoninator of Fraction 2: ");
                f2 = new Fraction(a, b);
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("The demoninator must not be zero" + e.Message);
            }
        }
        public override void PrintMenu()
        {
            System.Console.WriteLine("------====== Fraction Calculation ======------");
            System.Console.WriteLine("1. Add Fration");
            System.Console.WriteLine("2. Do Sum.");
            System.Console.WriteLine("3. Do Sub.");
            System.Console.WriteLine("4. Do Mul.");
            System.Console.WriteLine("5. Do Div.");
            System.Console.WriteLine("0. Exit.");
        }
        public override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: EnterFraction(); break;
                case 2: DemoSum(); break;
                case 3: DemoSub(); break;
                case 4: DemoMul(); break;
                case 5: DemoDiv(); break;
                case 0: System.Console.WriteLine("You've out of the system!!!"); break;
                default: System.Console.WriteLine("Invalid choice!!!"); break;
            }
        }
        private void DemoSum()
        {
            System.Console.Write("The result of Sum Caculator: ");
            System.Console.WriteLine(f1.Add(f2));
        }
        private void DemoSub()
        {
            System.Console.Write("The result of Sub Caculator: ");
            System.Console.WriteLine(f1.Sub(f2));
        }
        private void DemoMul()
        {
            System.Console.Write("The result of Mul Caculator: ");
            System.Console.WriteLine(f1.Mul(f2));
        }
        private void DemoDiv()
        {
            System.Console.Write("The result of Div Caculator: ");
            System.Console.WriteLine(f1.Div(f2));
        }
    }
}