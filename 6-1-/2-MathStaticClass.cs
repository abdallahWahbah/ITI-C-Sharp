using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_
{
    public static class MathStaticClass 
    {
        // static class >>> can't make object (no need for creating object, just add 2 numbers for example)
        // can't declare object member (only const in allowed)
        // can declare static members
        const int x = 20;
        public static int staticVariable = 10;
        public static int Add(int a, int b) 
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
