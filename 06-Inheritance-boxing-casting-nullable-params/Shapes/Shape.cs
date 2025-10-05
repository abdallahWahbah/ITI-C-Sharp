using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance
{
    abstract class Shape
    {
        static int dim1;
        static int dim2;

        public Shape() { dim1 = dim1 = 1; }
        public Shape(int _dim) { dim1 = dim2 = _dim; }
        public Shape(int _dim1, int _dim2) { dim1 = _dim1; dim2 = _dim2; }

        public virtual void SetDim1(int _dim1) => dim1 = _dim1;  // virtual: so that we can override it in Square, Triangle classes
        public virtual void SetDim2(int _dim2) => dim2 = _dim2; 
        public int GetDim1() => dim1; 
        public int GetDim2() => dim2;
        public abstract float CalcArea(); // abstract method must be in an abstract class, and must be implemented in the child class

        public void Print()
        {
            Console.WriteLine($"{dim1}-{dim2}");
        }
        public override string ToString()
        {
            return "Shape";
        }
    }
}
