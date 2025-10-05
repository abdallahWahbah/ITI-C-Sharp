using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_lab
{
    internal class Student: Person
    {
        int grade;

        public Student()
        {
            Console.WriteLine("Student Constructor");
            grade = 0;
        }
        public Student(string _name) : base(_name) { }
        public Student(string _name, int _id) : base(_name, _id) { }
        public Student(string _name, int _id, int _age) : base(_name, _id, _age) { }

        public void SetGrade(int _grade) { grade = _grade; }
        public int GetGrade() { return grade; }

        // overriding
        public override void PrintData()
        {
            Console.WriteLine("Student Class");
        }
    }
}
