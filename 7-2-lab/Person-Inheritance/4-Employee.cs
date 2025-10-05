using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_lab
{
    internal class Employee: Person
    {
        public Employee() { Console.WriteLine("Employee Constructor"); }
        public Employee(string _name): base(_name) { }
        public Employee(string _name, int _id) : base(_name, _id) { }
        public Employee(string _name, int _id, int _age) : base(_name, _id, _age) { }

        // overriding
        public override void PrintData()
        {
            Console.WriteLine("Employee Class");
        }
    }
}
