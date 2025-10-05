namespace _02_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lecture #008: OOP introduction
            // const member is a shared value that can't be modified after initialization
            // static member is a shared value that can be modified after initialization
            // const and static variables are stored in heap in place called (high frequency heap) which is faster to access but small in size

            // instance method is called by object
            // static method is called by TypeName
            #endregion

            #region Lecture #009: argument (vs) parameter, pass by value (vs) pass by ref, out, Expression body method
            // argument vs parameter >> argument is passed when calling a function, parameter is in the definition of the function


            ////// Pass by value vs pass by ref:
            //// pass by value means you are making a copy in memory of the actual parameter value that is passed in:
            //// when changing the parameter ( in the function definition), it doesn't affect the original value type
            //// pass by ref: when you modify the value of the variable in the function, it changes the original variable


            //// "out" example outside OOP
            //var numString = "1234L";
            //int numInteger;
            //if(int.TryParse(numString, out numInteger)) // if the text can be parsed into int, store the value in numInteger
            //{
            //    Console.WriteLine($"You could parse the number: {numInteger}");
            //}
            //else
            //{
            //    Console.WriteLine("Failed parsing");
            //}
            #endregion
        }
    }
}
