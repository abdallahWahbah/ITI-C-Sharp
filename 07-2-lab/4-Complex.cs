using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_lab
{
    class Complex
    {
        int real;
        int imaginary;
        static int count = 0;

        static Complex()
        {
            count = 0;
        }
        public Complex()
        {
            count++;
            real = imaginary = 0;
        }
        public Complex(int _real)
        {
            count++;
            real = _real;
            imaginary = 0;
        }
        public Complex(int _real, int _imaginary)
        {
            count++; 
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
        public static void IncreaseCount()
        {
            count++;
        }
        public static int GetCount() => count;

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
        // example on Equals override that is inherited from object class, not related to this class
        // if you used Equals function, it will compare 2 objects in a reference comparison, so they will not equal each other cause each one is pointing at another place in the heap
        public override bool Equals(object obj)
        {
            //Complex c1 = (Complex)obj; // unsafe casting, cause i can pass int (int is an object >> error)
            //return (this.real == c1.real) && (this.imaginary == c1.imaginary);


            //// safe casting >> if Complex is not object, assign null to c1
            //Complex c1 = obj as Complex;
            //if (c1 == null)
            //    return false;
            //return (this.real == c1.real) && (this.imaginary == c1.imaginary);


            // easier way
            if(obj is Complex)
            {
                Complex c1 = (Complex)obj;
                return (this.real == c1.real) && (this.imaginary == c1.imaginary);
            }
            return false;
        }

        public static Complex operator +(Complex complex1, Complex complex2)
        {
            Complex result = new Complex();
            result.real = complex1.real + complex2.real;
            result.imaginary = complex1.imaginary + complex2.imaginary;
            return result;
        }
    }
}
