using System;

namespace PassByRef
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            ///////////////////////////////////////
            /// pass by val for value type
            /// pass by ref for value type
            /// pass by val for ref type
            /// pass by ref for ref type ???? 
            // constructor doesn't create a new object, it's a function called when an object is created (for initialization)
            // "this": when calling a function, "this" is passed implecitely to represent the object calling the function
            ///////////////////////////////////////

            int a = 10;
            ref int x = ref a; // they both reference the same address in the memory, changing any of them will affect the other

            int swapRefNum1 = 10, swapRefNum2 = 20;
            SwapByRef(ref swapRefNum1, ref swapRefNum2); // call by ref
            Console.WriteLine($"{swapRefNum1}, {swapRefNum2}"); // 20, 10

            // notice, if you called a func by value but passed a ref datatype like array,
            // when changing it in the function, it will affect the original array
            // (cause the function take a copy of the address to the data in the heap)
            int[] arr = [1, 2, 3, 4];
            CallByValueForRefDatatype(arr);
            Console.WriteLine(arr[0]); // 100000

        }
        static void SwapByRef(ref int x, ref int y) // pass by ref
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void CallByValueForRefDatatype(int[] arr2)
        {
            arr2[0] = 100000;
        }

    }
}