namespace _6_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////
            /// static variable, static function, static class, singleton pattern
            /////////////////////////////////////////////////
            Complex c1 = new Complex();
            Complex c2 = new Complex(8);
            Complex c3 = new Complex(1, 2);
            Console.WriteLine(Complex.GetCount()); // static function

            // static class
            Console.WriteLine(MathStaticClass.Add(2, 3));

            // singleton
            Singleton a1 = Singleton.CreateObj(10); 
            Singleton a2 = Singleton.CreateObj(20); // if you created multiple objs, only the first one will be concidered
            Console.WriteLine(a1.ToString()); // 10
            Console.WriteLine(a1.ToString()); // 10


            // property overloading
            ComplexPropertyOverloading c4 = new ComplexPropertyOverloading(10, 5);
            ComplexPropertyOverloading c5 = new ComplexPropertyOverloading(20, 10);
            ComplexPropertyOverloading c6 = new ComplexPropertyOverloading(30, 15);
            ComplexPropertyOverloading c16 = new ComplexPropertyOverloading(30, 15);

            ComplexPropertyOverloading c7;
            c7 = c4.Add(c5).Add(c6);
            Console.WriteLine(c7.ToString()); // 60+30j

            // using property overloading
            ComplexPropertyOverloading c8;
            c8 = c4 + c5 + c6;
            Console.WriteLine(c8.ToString()); // 60+30j
            Console.WriteLine((10 + c8).ToString()); // 70+30j
            Console.WriteLine((c8 + 10).ToString()); // 70+30j
            Console.WriteLine((c5 == c6).ToString()); // False
            Console.WriteLine((c6 == c16).ToString()); // True
            Console.WriteLine(c16++.ToString()); // 31+16j
            ComplexPropertyOverloading c17 = 5; // implicitly convert the int to Complex
            int c18Int = (int) c17; // explicitly convert the complex to int

        }
    }
}
