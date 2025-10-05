using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_22_Lab
{
    internal class ComplexNumber
    {
        private int real;
        private int imaginary;

        public ComplexNumber()
        {
            real = imaginary = 0;
        }
        public ComplexNumber(int _real, int _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }

        public void SetReal(int _real) { real = _real; }
        public int GetReal() { return real; }
        public void SetImaginary(int _imaginary) { imaginary = _imaginary; }
        public int GetImaginary() {  return imaginary; }

        public void addComplexNumber(int _real, int _imaginary)
        {
            real += _real;
            imaginary += _imaginary;
        }
        public string PrintNumber()
        {
            var sign = imaginary > 0 ? '+' : ' ';
            return $"The number is {real}{sign}{imaginary}j";
        }
    }
}
