using System;

namespace Basics
{
    internal class Program
    {
        static int[] generateArrayOfNumbers()
        {
            Console.Write("Write the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (var i = 0; i < length; i++)
            {
                Console.Write($"Write number #{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
        public static void Main(string[] args)
        {
            /////////////////////////////////////////
            /// keys, functions, bubble sort, longest distance 
            /////////////////////////////////////////
            
            #region is prime number (using function) // number can be divided on its value or "1" only
            bool isPrime(int number)
            {
                if (number <= 1)
                    return false;
                for(int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
            Console.Write("Enter number to check if it is prime or not: ");
            int primeCheckNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(primeCheckNumber) ? "Prime" : "Not Prime");
            #endregion

            #region arrows
            Console.WriteLine("Use left, right, up and downs arrows. Also use Escape to exit");
            ConsoleKey key;
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Right");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Key");
                        break;
                }
            } while (key != ConsoleKey.Escape);
            #endregion

            #region 1dArray: bubble sort (input, print, sum, min, max, search for index, sort)
            int[] numbers = generateArrayOfNumbers();

            // print array items
            Console.Write("Arrays items: ");
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
            }
            Console.WriteLine();

            // sum
            var arraySum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                arraySum += numbers[i];
            }
            Console.WriteLine($"Sum: {arraySum.ToString()}");

            // min, max
            var minNumber = numbers[0];
            var maxNumber = numbers[0];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                    minNumber = numbers[i];
                if (maxNumber < numbers[i])
                    maxNumber = numbers[i];
            }
            Console.WriteLine($"Min is: {minNumber}, Max is: {maxNumber}");

            // search for the index by a value
            static int getIndex(int number, int[] numbers)
            {
                for (var i = 0; i < numbers.Length; i++)
                {
                    if (number == numbers[i])
                    {
                        return i;
                    }
                }
                return -1;
            }
            Console.Write("Enter value to get its index: ");
            int itemValue = int.Parse(Console.ReadLine());
            int index = getIndex(itemValue, numbers);
            Console.WriteLine(index == -1 ? "Doesn't Exists" : $"Index of {itemValue} is {index}");

            // bubble sort // https://deen3evddmddt.cloudfront.net/uploads/content-images/how-bubble-sort-works.webp
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int swappingItem = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = swappingItem;
                    }
                }
            }
            Console.Write("Array after sorting: ");
            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            #endregion

            #region factorial using function
            int getFactorial(int number)
            {
                int sum = 1;
                for (var i = number; i > 0; i--)
                {
                    sum *= i;
                }
                return sum;
            }
            Console.Write("Write a number to get its factorial: ");
            int factorialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {factorialNumber} is: {getFactorial(factorialNumber)}");
            #endregion

            #region exponent function
            double getExponent(int x, int y)
            {
                return Math.Pow(x, y);
            }

            Console.Write("Write number1: ");
            int exponent1 = int.Parse(Console.ReadLine());
            Console.Write("Write number2: ");
            int exponent2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{exponent1} ^ {exponent2} = {getExponent(exponent1, exponent2)}");
            #endregion

            #region number of prime numbers
            Console.WriteLine("Number of Prime numbers program");
            int getNumberOfPrimeNumber(int[] arr)
            {
                var numOfPrimeNumbers = 0;
                for (var i = 0; i < arr.Length; i++)
                {
                    bool isPrimeNumber = isPrime(arr[i]);
                    if (isPrimeNumber)
                        numOfPrimeNumbers++;
                }
                return numOfPrimeNumbers;
            }
            Console.WriteLine($"number of prime numbers in [3, 5, 6, 7, 8] is: {getNumberOfPrimeNumber([3, 5, 6, 7, 8])}");
            #endregion

            #region Longest distance between 2 equal numbers
            int getLongestDistance(int[] arr)
            {
                int maxDistance = 0;
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    for (var j = arr.Length - 1; j > i; j--)
                    {
                        if (arr[j] == arr[i])
                        {
                            int distance = j - i;
                            if (distance > maxDistance)
                                maxDistance = distance;
                            break; // No need to check earlier j’s for this i
                        }
                    }
                }
                return maxDistance;
            }

            int[] longestDistanceArray = generateArrayOfNumbers();
            int longestDistance = getLongestDistance(longestDistanceArray);
            Console.WriteLine(longestDistance);

            #endregion
        }

    }
}