using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_lab
{
    internal class Person
    {
        protected string name;
        protected int id;
        protected int age;

        #region constructors
        public Person()
        {
            Console.WriteLine("Person Constructor");
            name = "No name found";
            id = -1;
            age = 0;
        }
        public Person(string _name)
        {
            name = _name;
            id = -1;
            age = 0;
        }
        public Person(string _name, int _id)
        {
            name = _name;
            id = _id;
            age = 0;
        }
        public Person(string _name, int _id, int _age)
        {
            name = _name;
            id = _id;
            age = _age;
        }
        #endregion

        #region setters and getters
        public void SetId(int _id) { id = _id; }
        public void SetName(string _name) { name = _name; }
        public void SetAge(int _age) { age = _age; }
        public int GetAge() { return age; }
        public string GetName() { return name; }
        public int GetId() { return id; }
        #endregion

        public string PrintPersonDetails()
        {
            return $"{id}: {name} {age}-years old";
        }
        // overriding
        public virtual void PrintData()
        {
            Console.WriteLine("Person Class");
        }
    }
}
