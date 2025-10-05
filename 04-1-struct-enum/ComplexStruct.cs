using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_22_Lab
{
    struct ComplexStruct // the same structure as class
    {
        // struct conclusion: value type, less data than class, no inheritance, parameterless call after overloading

        // struct is the same as class, but used when data is small and when you don't need inheritance
        // advantage >> (value type): variable and data stored in the stack
        // if you equalized 2 struct objects, if you changed one, it won't affect the other one

        // in class, if you overloaded the constructor and tried to access the parameterless one without implementation >>> error
        // in struct, it's okay

        // you need to initialize all properties in the struct object before using it (like printing), whether in the constructor or by assiging values >> c.real = 10;


        private int real;
        private int imaginary;

        public ComplexStruct()
        {
            real = imaginary = 0;
        }
        public ComplexStruct(int _real, int _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }

        public void SetReal(int _real) { real = _real; }
        public int GetReal() { return real; }
        public void SetImaginary(int _imaginary) { imaginary = _imaginary; }
        public int GetImaginary() { return imaginary; }

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
