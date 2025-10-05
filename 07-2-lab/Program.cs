using _4_3_lab;

namespace _7_2_lab
{
    internal class Program
    {
        static void WhichClassToCall(Person person)
        {
            person.PrintData();
        }
        static void ChangeValues(out double doubleValue, out int intValue) // out
        {
            doubleValue = 13.445415;
            intValue = 78;
        }
        static void Main(string[] args)
        {
            #region fraction
            Fraction f1 = new Fraction(15, 9); // 5/3
            Fraction f2 = new Fraction(44, 28); // 11/7
            Fraction f3 = f1 + f2;
            Fraction f4 = f1 - f2;
            Fraction f5 = f1 * f2;
            Fraction f6 = f1 / f2;
            Console.WriteLine(f3.Simplify());
            Console.WriteLine("--------------------------");
            #endregion

            #region person inheritance
            Person person1 = new Person("Abdallah", 10, 20);
            Student student1 = new Student("Mahmoud", 11, 30);
            Employee employee1 = new Employee("Wahbah", 12, 40);
            person1.PrintData(); // Person Class
            student1.PrintData(); // Student Class
            employee1.PrintData(); // Employee Class
            Console.WriteLine("--------------------------");
            WhichClassToCall(person1); // Person Class
            WhichClassToCall(student1); // Student Class
            WhichClassToCall(employee1); // Employee Class
            Console.WriteLine("--------------------------");
            #endregion

            #region complex class (static, property overloading)
            Console.WriteLine("------------------------");
            Complex complex1 = new Complex(10, 20);
            Complex complex2 = new Complex(30, 40);
            Console.WriteLine(Complex.GetCount()); // 2
            Console.WriteLine(complex1 + complex2); // 40+60j
            #endregion

            #region Duration class
            Duration d1 = new Duration(3, 70, 65); // 4:11:5
            Duration d2 = new Duration(3700); // 1:1:40
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());
            Console.WriteLine((d1 + d2).ToString()); // 5:12:45
            Console.WriteLine(60 + d1); // 4:12:5
            Console.WriteLine(d1 + 70); // 4:12:15
            Console.WriteLine(d1++); // 4:12:5
            Duration d3 = new Duration(1, 59, 10);
            Console.WriteLine(++d3); // 2:0:10
            #endregion

            #region Math class with static methods only
            Console.WriteLine(MathStaticMethods.Add2Numbers(20, 3)); // 17
            Console.WriteLine(MathStaticMethods.Subtract2Numbers(20, 3)); // 17
            Console.WriteLine(MathStaticMethods.Multiply2Numbers(20, 3)); // 60
            Console.WriteLine(MathStaticMethods.Divide2Numbers(20, 3)); // 6.6666665
            #endregion

            #region Out
            double doubleValeUsingOut = 19.2;
            int intValUsingOut = 1838;
            ChangeValues(out doubleValeUsingOut, out intValUsingOut);
            Console.WriteLine($"{doubleValeUsingOut}, {intValUsingOut}"); // 13.445415, 78

            // out using/TryParse
            string stringValue = "124";
            if(int.TryParse(stringValue, out int intVal))
                Console.WriteLine($"Value after parsing: {intVal}");
            else
                Console.WriteLine("Can't parse");
            #endregion

        }
    }
}
