using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance
{
    class Rectangle: Shape
    {
        public Rectangle() { }
        public Rectangle(int _dim) : base(_dim) { }
        public Rectangle(int _dim1, int _dim2) : base(_dim1, _dim2) { }

        public override float CalcArea()
        {
            return GetDim1() * GetDim2();
        }
        public override string ToString()
        {
            return $"Rectagnel Object: {GetDim1()}-{GetDim2()}";
        }
    }
    class Square : Rectangle
    {
        public Square() : base() { }
        public Square(int _dim) : base(_dim) { }

        public override void SetDim1(int _dim1)
        {
            base.SetDim1(_dim1);
            base.SetDim2(_dim1);
        }
        public override void SetDim2(int _dim2)
        {
            base.SetDim1(_dim2);
            base.SetDim2(_dim2);
        }
        public override string ToString()
        {
            return "Square";
        }
    }
}
