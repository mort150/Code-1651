using System;
using System.Collections.Generic;
using System.Text;

namespace June82021
{
   public class FractionProgram : MenuProgram
    {
        public FractionProgram()
        {

        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: DemoSum(); break;
                case 2: DemoSub(); break;
                case 3: DemoMul(); break;
                case 4: DemoDiv(); break;
                case 0:
                    Console.WriteLine("You had been out of the program!!");
                    break;
                default: Console.WriteLine("Invalid choice!!!"); 
                    break;
            }
        }

        private void DemoSum()
        {
            Fraction f1 = MyUtils.GetFraction("Enter fraction f1: ");
            Fraction f2 = MyUtils.GetFraction("Enter fraction f2: ");
            Fraction sum = f1.Add(f2);
            
            Console.WriteLine(f1 + "+" + f2 + "=" + sum);
        }

        private void DemoSub()
        {
            Fraction f1 = MyUtils.GetFraction("Enter fraction f1: ");
            Fraction f2 = MyUtils.GetFraction("Enter fraction f2: ");
            Fraction sub = f1.Sub(f2);
            
            Console.WriteLine(f1 + "-" + f2 + "=" + sub);
        }
        private void DemoMul()
        {
            Fraction f1 = MyUtils.GetFraction("Enter fraction f1: ");
            Fraction f2 = MyUtils.GetFraction("Enter fraction f2: ");
            Fraction mul = f1.Mul(f2);
            
            Console.WriteLine(f1 + "x" + f2 + "=" + mul);
        }
        private void DemoDiv()
        {
            try
            {
                Fraction f1 = MyUtils.GetFraction("Enter fraction f1: ");
                Fraction f2 = MyUtils.GetFraction("Enter fraction f2: ");
                Fraction div = f1.Div(f2);
                Console.WriteLine(f1 + ":" + f2 + "=" + div);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            
        }
        protected override void PrintMenu()
        {
            Console.WriteLine("1. Demo addition 2 fractions");
            Console.WriteLine("2. Demo substraction");
            Console.WriteLine("3. Demo multplication");
            Console.WriteLine("4. Demo divivision");
            Console.WriteLine("0. Exit");
        }
    }
}
