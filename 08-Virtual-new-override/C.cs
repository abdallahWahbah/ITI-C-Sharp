using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Virtual_new_override
{
    internal class C: B
    {
        public override void AVirtual_BOverride_COverride()
        {
            Console.WriteLine("C");
        }
        public override void AVirtual_BNewVirtual_COverride()
        {
            Console.WriteLine("C");
        }
        public new virtual void AVirtual_BNewVirtual_CNewVirtual()
        {
            Console.WriteLine("C");
        }
    }
}
