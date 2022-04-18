using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FractionEx
{
    public class Fraction
    {
        private int numerator;
        private int demoninator;
        public int Numerator
        {
            get { return numerator; }
            set
            {
                // if (value < 0) throw new Exception("Invalid Numerator!!!");
                // else 
                numerator = value;
            }
        }
        public int Demoninator
        {
            get { return demoninator; }
            set
            {
                if (value == 0) throw new Exception("Invalid Demoninator!!! The Demoninator must not be zero!!!");
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
            
            Fraction sum = new Fraction();
            sum.numerator = (a * d + b * c);
            sum.demoninator = (b * d);
            return sum;
        }
        public Fraction Sub(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;

            Fraction sub = new Fraction();
            sub.numerator = (a * d - b *c); 
            sub.demoninator = (b * d);
            return sub;
        }
        public Fraction Mul(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;

            Fraction mul = new Fraction();
            mul.numerator = (a * c); 
            mul.demoninator = (b * d);
            return mul;
        }
        public Fraction Div(Fraction f)
        {
            int a = numerator;
            int b = demoninator;
            int c = f.numerator;
            int d = f.demoninator;
            Fraction div = new Fraction();
            div.numerator = (a * d);
            div.demoninator = (b * c);
            return div;
        }
        public override string ToString()
        {
            return Numerator + "/" + Demoninator;
        }
    }
}