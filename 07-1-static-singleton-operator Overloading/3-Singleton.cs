using System;
using System.Collections.Generic;
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





    // search about making class that makes only 10 objects
    public class Singleton10Obj
    {
        int x = 1;
        static Singleton10Obj[] obj = new Singleton10Obj[10]; // to force it later (in CreateObj) to return the first obj created (don't create new)

        Singleton10Obj(int _x)
        {
            // private constructor: can't create object (can't use it outside the class)
            // used to prevent creating new object
            x = _x;
        }
        public static Singleton10Obj CreateObj(int _x)
        {
            if (obj == null)
                obj[0] = new Singleton10Obj(_x);
            return obj[0];
        }
        public override string ToString()
        {
            return $"x={x}";
        }
    }
}
