using System.Security.Claims;

namespace _6_Inheritance
{
    internal class Program
    {
        static void WhichShapeToCalcArea(Shape shape)
        {
            Console.WriteLine(shape.CalcArea());
        }
        static void Main(string[] args)
        {
            ////////////////////////////////////////
            /// inheritance, Object, boxing-unboxing, implicit casting - explicit casting, nullable type - coalesce operator
            /// named parameters, params
            ////////////////////////////////////////
            
            Rectangle r1 = new Rectangle(3, 4);
            Triangle t1 = new Triangle(3, 4);
            Console.WriteLine(r1.CalcArea()); // 12
            Console.WriteLine(t1.CalcArea()); // 6
            WhichShapeToCalcArea(r1); // 12
            WhichShapeToCalcArea(t1); // 6
            Console.WriteLine(r1.ToString()); // Rectagnel Object: 3-4


            Square s1 = new Square(10);
            Console.WriteLine(s1.CalcArea()); // 100
            s1.SetDim1(50); // now dim1=dim=50 cause we made override (virtual in Shape)
            Console.WriteLine(s1.CalcArea()); // 2500

            Circle c1 = new Circle(10);
            c1.Print(); // 10-10
            c1.SetDim1(80);
            c1.Print();// 80-80


            // virtual new // new: stops the virtuality coming from the parent, virtual: to allow child to override
            // if it's new in Rect, you can't override in Square, so you need to make it virtual new






            // Object class is the parent of all classes
            int x = 10;
            Object o1 = 2;
            o1 = 2.4;
            o1 = "Abdallah";
            o1 = x; // Boxing (taking a copy from stack and put in in the heap) (from value type to reference type)
            int z = (int)o1; // UnBoxing (taking copy of the heap and put it in the stack) (from ref type to value type)





            // implicit & explicit casting
            int casting1 = 20; // 4 byte
            short casting2 = 1; // 2 byte
            casting1 = casting2; // implicit casting (storing small in big)
            casting2 = (short) casting1; // explicit casting (storing big in small)
            // data types from from small to big
            // byte >> short >> int >> long >> float >> double
            // another example
            long longVal = 9;
            float floatVal = 10;
            floatVal = longVal;
            longVal = (long) floatVal;





            // nullable type, coalesce operator
            // you can't say >>> int age = null
            int? age = null; // age now can hold number or "null" value
            int xExample = age.HasValue ? age.Value : 19;
            // or >>  //int xExample2 = age ?? 19;





            // named parameters
            int subNum1 = 10;
            int subNum2 = 20;
            Console.WriteLine(Sub(subNum1, subNum2)); // -10
            Console.WriteLine(Sub(a: subNum2, b: subNum1)); // 10





            // params (like rest in js)
            Console.WriteLine(AddUnlimitedNumbers(1, 2, 3, 4, 5)); // 15
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int AddUnlimitedNumbers(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
