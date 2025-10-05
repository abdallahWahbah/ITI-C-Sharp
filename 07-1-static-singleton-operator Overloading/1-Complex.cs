using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_
{
    internal class Complex
    {
        int real;
        int imaginary;
        static int Count = 0; // static member (sharable between all objects)
        // in static function, you can't deal with instance (object) member like "real" or "imaginary"
        // in object function, you can deal with static member like "Count" 

        static Complex() 
        {
            // static constructor
            // called automatically only one time in the lifetime of the app (if you created 3 objs, it will be called only once before creating the first obj)
            // used for initialization the static members
            // why we use it instead of initializing static members during declaration ?? >> to collect all static members in one place
            Count = 0;
        }
        public Complex() 
        { 
            Count++; 
            real = imaginary = 0; 
        }
        public Complex(int _real)
        {
            Count++;
            real = _real;
            imaginary = 0;
        }
        public Complex(int _real, int _imaginary)
        {
            Count++; // in object function, you can deal with static member like "Count" 
            real = _real;
            imaginary = _imaginary;
        }

        public void SetReal(int _real) {  real = _real; }
        public void SetImaginary(int _imaginary) 
        { 
            imaginary = _imaginary; 
        }
        public static void IncreaseCount()  // static function
        { 
            Count++; // in static function, you can't deal with instance (object) member like "real" or "imaginary"
        }
        public int GetReal() { return real; }
        public int GetImaginary() { return imaginary; }
        public static int GetCount() => Count; // static function

        public override string ToString()
        {
            if (imaginary > 0)
            {
                return $"{real}+{imaginary}j";
            }
            else if (imaginary < 0)
                return $"{real}{imaginary}j";
            else
                return real.ToString() ;
        }
    }
}
