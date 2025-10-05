using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_lab
{
    internal class Fraction
    {
        int numerator;
        int denominator;

        public Fraction(int _numerator, int _denominator)
        {
            if (_denominator < 0) { Console.WriteLine("You can't divide by 0"); }
            numerator = _numerator;
            denominator = _denominator;
        }
        public int GetNumerator() { return numerator; }
        public int GetDenominator() { return denominator; }
        private int CalculateGDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public string Simplify()
        {
            int gdc = CalculateGDC(numerator, denominator);
            numerator /= gdc;
            denominator /= gdc;

            return $"{numerator}/{denominator}";
        }

        // operator overloading
        public static Fraction operator+(Fraction a, Fraction b)
        {
            int _denom = a.denominator * b.denominator;
            int _numerLeft = (_denom / a.denominator) * a.numerator;
            int _numerRight = (_denom / b.denominator) * b.numerator;
            int _numer = _numerLeft + _numerRight;
            Fraction fractionTemp = new Fraction(_numer, _denom);

            return fractionTemp;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int _denom = a.denominator * b.denominator;
            int _numerLeft = (_denom / a.denominator) * a.numerator;
            int _numerRight = (_denom / b.denominator) * b.numerator;
            int _numer = _numerLeft -  _numerRight;
            Fraction fractionTemp = new Fraction(_numer, _denom);

            return fractionTemp;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int _numer = (a.numerator * b.numerator);
            int _denom = a.denominator * b.denominator;
            Fraction fractionTemp = new Fraction(_numer, _denom);
            return fractionTemp;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int _numer = (a.numerator * b.denominator);
            int _denom = a.denominator * b.numerator;
            Fraction fractionTemp = new Fraction(_numer, _denom);
            return fractionTemp;
        }
    }
}
