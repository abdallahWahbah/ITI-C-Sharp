namespace _8_Virtual_new_override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            B b1 = new B();
            C c1 = new C();

            A a2 = new C();
            B b2 = new C(); 

            // virtual - override - override
            a1.AVirtual_BOverride_COverride(); // A
            b1.AVirtual_BOverride_COverride(); // B
            c1.AVirtual_BOverride_COverride(); // C
            a2.AVirtual_BOverride_COverride(); // C
            b2.AVirtual_BOverride_COverride(); // C

            Console.WriteLine("----------------------");

            // virtual - new virtual - override
            a1.AVirtual_BNewVirtual_COverride(); // A
            b1.AVirtual_BNewVirtual_COverride(); // B
            c1.AVirtual_BNewVirtual_COverride(); // C
            a2.AVirtual_BNewVirtual_COverride(); // A
            b2.AVirtual_BNewVirtual_COverride(); // C

            Console.WriteLine("----------------------");

            // virtual - new virtual - new virtual
            a1.AVirtual_BNewVirtual_CNewVirtual(); // A
            b1.AVirtual_BNewVirtual_CNewVirtual(); // B
            c1.AVirtual_BNewVirtual_CNewVirtual(); // C
            a2.AVirtual_BNewVirtual_CNewVirtual(); // A
            b2.AVirtual_BNewVirtual_CNewVirtual(); // B

        }
    }
}
