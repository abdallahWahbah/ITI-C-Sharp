using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_
{
    internal class ComplexPropertyOverloading
    {
        int real;
        int imaginary;

        public ComplexPropertyOverloading()
        {
            real = imaginary = 0;
        }
        public ComplexPropertyOverloading(int _real)
        {
            real = _real;
            imaginary = 0;
        }
        public ComplexPropertyOverloading(int _real, int _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }

        public void SetReal(int _real) { real = _real; }
        public void SetImaginary(int _imaginary)
        {
            imaginary = _imaginary;
        }
        public int GetReal() { return real; }
        public int GetImaginary() { return imaginary; }

        public ComplexPropertyOverloading Add(ComplexPropertyOverloading c)
        {
            ComplexPropertyOverloading result = new ComplexPropertyOverloading();
            result.real = real + c.real;
            result.imaginary = imaginary + c.imaginary;
            return result;
        }
        // operator overloading
        public static ComplexPropertyOverloading operator +(ComplexPropertyOverloading complex1, ComplexPropertyOverloading complex2)
        {
            //return new ComplexPropertyOverloading(complex1.real + complex2.real, complex1.imaginary + complex2.imaginary);
            //or
            ComplexPropertyOverloading result = new ComplexPropertyOverloading();
            result.real = complex1.real + complex2.real;
            result.imaginary = complex1.imaginary + complex2.imaginary;
            return result;
        }
        // overload >>> int + complex
        public static ComplexPropertyOverloading operator +(int _real, ComplexPropertyOverloading complex)
        {
            return new ComplexPropertyOverloading(_real + complex.real, complex.imaginary);
        }
        // overload >>> complex + int
        public static ComplexPropertyOverloading operator +(ComplexPropertyOverloading complex, int _real)
        {
            return new ComplexPropertyOverloading(_real + complex.real, complex.imaginary);
        }
        // for logical operators, you must handle the process and its opposite like: (> <), (>= <=), (== !=)
        // "=="
        public static bool operator ==(ComplexPropertyOverloading complex1, ComplexPropertyOverloading complex2)
        {
            if (complex1.real == complex2.real && complex2.imaginary == complex1.imaginary) return true;
            else return false;
        }
        // "!="
        public static bool operator !=(ComplexPropertyOverloading complex1, ComplexPropertyOverloading complex2)
        {
            return !(complex1 == complex2); // you can call "==" operator
        }
        public static ComplexPropertyOverloading operator ++(ComplexPropertyOverloading complex1)
        {
            return new ComplexPropertyOverloading(complex1.real++, complex1.imaginary++);
        }
        // implicit >>> convert from int to Complex>>> Complex c = 5;
        public static implicit operator ComplexPropertyOverloading(int num)
        {
            return new ComplexPropertyOverloading(num, 0);
        }
        // explicit >>> convert from Complex to int (for example: return the real) 
        public static explicit operator int(ComplexPropertyOverloading c)
        {
            return c.real;
        }


        public override string ToString()
        {
            if (imaginary > 0)
            {
                return $"{real}+{imaginary}j";
            }
            else if (imaginary < 0)
                return $"{real}{imaginary}j";
            else
                return real.ToString();
        }
    }
}
