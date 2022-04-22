using System;
using System.Collections.Generic;
using System.Text;

namespace June82021
{
    class Fraction
    {
        protected int numerator;
        protected int demoninator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value;  }
        }
        public int Demoninator
        {
            get { return demoninator; }
            set
            {
                if (value == 0) throw new DivideByZeroException("Demoninator now is zero!!!");
                else demoninator = value;  
            }
        }

        public Fraction()
        {
            numerator = 1;
            demoninator = 1;
        }
        public Fraction(int n, int d)
        {
            Numerator = n;
            Demoninator = d;
        }
        public override string ToString()
        {
            return numerator + "/" + demoninator;
        }

        public Fraction Add(Fraction f)
        {
            int num = Numerator * f.Demoninator + f.Numerator * Demoninator;
            int den = Demoninator * f.Demoninator;

            Fraction sum = new Fraction(num, den);
            return sum;
        }
        public Fraction Sub(Fraction f)
        {
            int num = Numerator * f.Demoninator - f.Numerator * Demoninator;
            int den = Demoninator * f.Demoninator;

            Fraction sub = new Fraction(num, den);
            return sub;
        }
        public Fraction Mul(Fraction f)
        {
            int num = Numerator * f.Numerator;
            int den = Demoninator * f.Demoninator;

            Fraction mul = new Fraction(num, den);
            return mul;
        }
        public Fraction Div(Fraction f)
        {
            int num = Numerator * f.Demoninator;
            int den = Demoninator * f.Numerator;

            Fraction div = new Fraction(num, den);
            return div;
        }
    }
}
