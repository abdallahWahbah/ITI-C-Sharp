using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance
{
    internal class Circle: Shape
    {
        public Circle() { }
        public Circle(int _dim) : base(_dim) { }

        public override void SetDim1(int _dim1)
        {
            base.SetDim1(_dim1);
            base.SetDim2(_dim1);
        }
        public override void SetDim2(int _dim2)
        {
            //base.SetDim1(_dim2);
            //base.SetDim2(_dim2);
            SetDim1(_dim2); // the same as above
        }
        public override float CalcArea()
        {
            return (float) (Math.PI * Math.Pow(GetDim1(), 2));
        }
    }
}
