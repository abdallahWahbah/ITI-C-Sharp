using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_lab
{
    class MathStaticMethods
    {
        public static float Add2Numbers(float a, float b) => a + b;
        public static float Subtract2Numbers(float a, float b) => a - b; 
        public static float Multiply2Numbers(float a, float b) => a * b;
        public static float Divide2Numbers(float a, float b) {
            if (b == 0)
            {
                throw new ArgumentException("Can't divide by 0");
            }
            return a / b;
        }
    }
}
