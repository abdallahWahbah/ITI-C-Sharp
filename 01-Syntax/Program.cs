
// .Net Framework 4.8 >>> to build applications only for windows
// .Net Core 3.1 >> cross-platform, open source
// .Net 5 >> stable version (most currently used)

// ram (random access memory) is divided into 2 parts: stack, heap
// value types (int, float, bool, char, struct...) are stored in stack
// reference data types(array, string, objects, classes) are stored in 2 places >>>  identifier (variable name) stored in stack, its value (content) stored in heap
// heap: locations in memory heap  are located randomly (not above each other)
//// any value type has a limit, reference value doesn't

namespace _01_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lecture #003: variables (عبدالنبي)
            //// var >>>> you can't assign another type after assigning one type unlike javascript
            //var floatVar = 3f;
            //var doubleVar = 3d;
            //var longVar = 1L;
            //var unsignedLongVar = 1ul;
            //int oneMillion = 1_000_000;
            //var decimalResult = 200 / 3.0;
            ////decimalResult = "string text" // not allowed

            //// dynamic >> dynamic variable is not resolved at compile time (before execution), instead done at runtime
            //dynamic dynamicVariable = 9;
            //dynamicVariable = "Abdallah Wahbah";
            //dynamicVariable = 10.5;
            #endregion

            #region Lecture #004: boolean, comparison, logical operators, ternary operator
            //// comparison operators
            //Console.WriteLine(9 >= 10); // >, <, >=, <=, ==


            //// Logical operators >>>> &&(AND), ||(OR), ^(XOR)
            //// &&: AND operator returns true if all values are true
            //Console.WriteLine(true && true); // true
            //Console.WriteLine(true && false); // false
            //Console.WriteLine(false && true); // false
            //Console.WriteLine(false && false); // false

            //// ||: OR operator returns true if any value is true
            //Console.WriteLine(true && true); // true
            //Console.WriteLine(true || false); // true
            //Console.WriteLine(false || true); // true
            //Console.WriteLine(false || false); // false

            //// ^: XOR operator returns true if (number of true is odd) (if values are different >> true, else if values are the same >> false)
            //Console.WriteLine(true ^ true); // false
            //Console.WriteLine(true ^ false); // true
            //Console.WriteLine(false ^ true); // true
            //Console.WriteLine(false ^ false); // false


            //// logical operator using single operators like &, |
            //// the difference is >>>> double operators makes a short circuit
            //// for example (||) checks if the first value is true, it will not check for the next value and will return true
            //// but in single operator (|), it will check for both values
            //// of course double operator is used more frequent to limit resources and time

            //bool boolVal = true || check(); // it will not execute check()
            //bool boolVal2 = true | check(); // it will execute check()


            //// ternary operator
            //Console.WriteLine(1000 > 900 ? "YEEEEEEEEEEEEEEEEEES" : "NOOOOOOOOOOOO");
            #endregion

            #region Lecture #005: Arrays
            // array is a reference data type >>> variable is stored in stack, value in heap
            //// different ways for declaration
            //// one dimensional array
            //string[] names = new string[5];
            //names[0] = "Abdallah";
            //names[1] = "Mahmoud";
            //names[2] = "Wahbah";
            //Console.WriteLine(names[1]);

            //// when using {}, if you put 5 in [], you must write 5 elements
            //string[] names2 = new string[5] { "Abdallah", "Mahmoud", "Abdelbary", "Abdallah", "Wahbah", };

            //string[] names3 = { "Abdallah", "Mahmoud", "Wahbah" };
            //string[] names4 = ["Abdallah", "Mahmoud", "Wahbah"];

            //// multi dimensional array
            //int[,] soduko =
            //{
            //    { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            //    { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            //    { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            //    { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            //    { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            //    { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            //    { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            //    { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            //    { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            //};


            //// jagged array (array inside array): consider it as a multi dimensional array with high performance
            //var jaggedArr = new int[][]{
            //    new int[] {1, 2, 3},
            //    new int[] {4, 5},
            //    new int[] { 6 }
            //};

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 4, 5 };
            //jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            // 


            //// ranges
            //var friends = new string[] { "Abdallah", "Mahmoud", "Abdelbary", "Adballah", "Wahbah" };
            //var first2Friends = friends[..2]; // 2 is excluded {"Abdallah", "Mahmoud"}
            //var fromThirdFriend = friends[2..]; // exclude first 2 elements {"Abdelbary", "Adballah", "Wahbah"}
            //var from2To3 = friends[2..3]; // {"Abdelbary"}
            #endregion

            #region Lecture #006: null, if, switch, iterators (iterations)(while, do while, for, foreach), break, continue, goto
            //// null coalescing operator
            //string s1 = null;
            //s1 = s1 ?? "Abdallah"; // if s1 is null, assign "Abdallah" to it (like js)
            //Console.WriteLine(s1); // "Abdallah"
            //s1 = s1 ?? "Wahbah"; 
            //Console.WriteLine(s1); // "Abdallah" cause it has a value (not null)


            //// null conditional operator
            //string s2 = null;
            //var s2Upper = s2?.ToUpper();
            //Console.WriteLine("-----------" + s2Upper);


            //// if statement
            //var mark = 90;
            //if (mark > 85)
            //    Console.WriteLine("Excellent");
            //else if (mark < 85 && mark > 75)
            //    Console.WriteLine("Very Good");
            //else
            //    Console.WriteLine("Passed!");

            //// switch statement
            //var currency = "EGP";
            //switch (currency)
            //{
            //    case "EGP":
            //    case "SAR":
            //        Console.WriteLine("EGYPT OR SAUDI ARABIA");
            //        break;
            //    case "USD":
            //        Console.WriteLine("United States Of America");
            //        break;
            //    default: // if the currency doesn't match any of the cases
            //        Console.WriteLine("Not Exist");
            //        break;

            //}


            //// iterations (while, do while, for, foreach)
            //var counter = 0;
            //while(counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter < 20);

            //for (var i = 0;  i < 10; i++) // arr.Length (if you have an array)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach(char c in "Abdallah Wahbah")
            //{
            //    Console.Write(c + " ");
            //}

            //// break, continue
            ////example: print even numbers
            //for (var i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //        continue;
            //    else 
            //        Console.WriteLine(i);
            //    if (i == 9)
            //        break;
            //}

            //var x = 0;
            //gotoLabel:
            //if(x < 5)
            //{
            //    Console.Write(x);
            //    ++x;
            //    goto gotoLabel;
            //}
            #endregion

            #region Lecture #007: casting, Boxing and UnBoxing, TryParse(), out
            //// implicit(automatically) casting
            //int intNum1 = 10000;
            //long longNum1 = intNum1;  // int is shorter than long, so we can assign int to long

            //// explicit casting 
            //long longNum2 = 30000000;
            //if(longNum2 < Int32.MaxValue) // long is bigger than int, so we need to check first if that long num is within the int bounderies, then cast it
            //{
            //    int intNum2 = (int) longNum2;
            //}
            //// explicit casting another example
            //double doubleNum1 = 1021.56;
            //int intNum3 = (int) doubleNum1;


            //// boxing and unboxing
            //// boxing is to convert from 'value' data type to 'reference' data type (implicitly)
            //// unboxing is to cast from reference to value data type
            //int intNum4 = 10; // value type
            //Object obj; // reference type
            //obj = intNum4; // boxing (converting done implicitly) (from value to reference) (object in bigger than int, so no problem)
            //int intNum5 = (int) obj; // unboxing (from reference to value)


            //// converting from string to number
            //string stringValue = "99999";
            ////int parsedNumer = int.Parse(stringValue);
            ////Console.WriteLine(parsedNumer);
            //if(int.TryParse(stringValue, out int number)) // if you can parse the string to num, parse it and store it in 'number'
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number provided or doesn't fit integer");
            //}
            #endregion
        }
    }
}
