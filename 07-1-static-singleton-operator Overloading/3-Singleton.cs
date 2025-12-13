using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_
{
    public class Singleton
    {
        int x = 1;
        static Singleton obj = null; // to force it later (in CreateObj) to return the first obj created (don't create new)

        Singleton(int _x) 
        {
            // private constructor: can't create object (can't use it outside the class)
            // used to prevent creating new object
            x = _x;
        }
        public static Singleton CreateObj(int _x)
        {
            if(obj == null)
                obj = new Singleton (_x);
            return obj;
        }
        public override string ToString()
        {
            return $"x={x}";
        }
    }





    // Singleton pattern limited to 10 objects (not just one object)
    public class Singleton10Obj
    {
        int x = 1;
        static Singleton10Obj[] objects = new Singleton10Obj[10];
        static int count = 0;

        Singleton10Obj(int _x)
        {
            x = _x;
        }
        public static Singleton10Obj CreateObj(int _x)
        {
            if (count < 10)
            {
                objects[count] = new Singleton10Obj(_x);
                return objects[count++];
            }
            else
            {
                throw new Exception("You can create only 10 objects from this class.");
            }
        }
        public override string ToString()
        {
            return $"x={x}";
        }
    }
}
