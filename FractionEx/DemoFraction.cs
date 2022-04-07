using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionEx
{
    public class DemoFraction : MenuProgram
    {
        private int numerator;
        private int demoninator;
        public int Numerator
        {
            get { return numerato; }
            set
            {
                if (value < 0) throw new Exception("Invalid Numerator!!!");
                else numerator = value;
            }
        }
        public int Demoninator
        {
            get { return demoninator; }
            set
            {
                if (value = 0) throw new Exception("Invalid Demoninator!!!");
                else demoninator = value;
            }
        }
        public Fraction()
        {
            numerator = 1;
            demoninator = 1;
        }
        public Fraction(int a, int b)
        {
            Numerator = a;
            Demoninator = b;
        }
        public Fraction Add(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;

            int sum = (a * d + b * c) / (b * d);
            return sum;
        }
        public Fraction Sub(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;

            int sub = (a * d - b *c) / (b * d);
            return sub;
        }
        public Fraction Mul(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;

            int mul = (a * c) / (b * d);
            return mul;
        }
        public Fraction Div(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;

            int div = (a * d) / (b * c);
            return div;
        }
    }
}