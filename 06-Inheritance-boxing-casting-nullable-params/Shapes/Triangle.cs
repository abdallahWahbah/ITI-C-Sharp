using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance
{
    internal class Triangle: Shape
    {
        public Triangle() { }
        public Triangle(int _dim) : base(_dim) { }
        public Triangle(int _dim1, int _dim2) : base(_dim1, _dim2) { }

        public override float CalcArea()
        {
            return .5f * GetDim1() * GetDim2();
        }
    }
}
