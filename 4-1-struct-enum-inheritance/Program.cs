using _3_22_Lab;

namespace _4_1_struct_enum_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region struct

            ComplexNumber c1 = new ComplexNumber(5, 3);
            ComplexNumber c2 = new ComplexNumber(7, 29);
            c1 = c2; // ref equality
            c1.SetImaginary(20);
            Console.WriteLine($"{c1.GetImaginary()}, {c2.GetImaginary()}"); // 20, 20

            //ComplexStruct c; // = >>>>>>>>>  ((new ComplexStruct();)) // not mandatory when using it cause it doesn't create object in the heap
            ComplexStruct c3 = new ComplexStruct(5, 3);
            ComplexStruct c4 = new ComplexStruct(7, 29);
            c3 = c4; // value equality
            c4.SetImaginary(20);
            Console.WriteLine($"{c3.GetImaginary()}, {c4.GetImaginary()}"); // 29, 20
            #endregion






            #region enum
            GenderEnum g1 = GenderEnum.Female; // Male has int value = 0, Female has int value = 1 (for storing in memory)
            Console.WriteLine(g1);
            g1 = GenderEnum.Male;
            Console.WriteLine(g1);
            g1 = (GenderEnum)1; // Female (not good for readability)
            Console.WriteLine(g1);


            ITIBranch b1 = ITIBranch.Smart;
            Console.WriteLine(b1); // Smart
            Console.WriteLine((int)b1); // 100
            b1 = (ITIBranch) Enum.Parse(typeof(ITIBranch), "Zagazig"); // casting
            //b1 = (ITIBranch)Enum.Parse(typeof(ITIBranch), Console.ReadLine()); // casting
            Console.WriteLine(b1); // Zagazig
            Console.WriteLine((int)b1); // 3000


            // Color enum example
            Color c = Color.Red | Color.Green; // bitwise or
            if((c & Color.Red) == Color.Red)  // if color contains red
                Console.WriteLine("contains red");
            #endregion

        }
    }
}
