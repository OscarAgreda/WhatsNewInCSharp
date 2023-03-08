using System;

namespace StaticLocalFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Using a static local function to calculate the sum of two numbers

            // Declare two integer variables called a and b, and assign them the values 1 and 2
            int a = 1;
            int b = 2;

            // Call the SumNumbers method and print the result to the console
            Console.WriteLine($"Example 1: Sum of {a} and {b} is {SumNumbers(a, b)}");

            // Define a static local function called SumNumbers that takes no arguments and returns an integer
            static int SumNumbers(int a, int b)
            {
                // Within the SumNumbers function, we can access the variables a and b defined in the Main method
                return a +
                       b;
            }


            // Example 2: Using a static local function to implement a simple state machine

            // Declare an integer variable called state, and initialize it to 0
            int state = 0;

            // Call the ProcessData method twice with the arguments "hello" and "world", and print the state variable after each call
            Console.WriteLine($"Example 2: Processing 'hello', state is {ProcessData("hello", ref state)}");
            Console.WriteLine($"Example 2: Processing 'world', state is {ProcessData("world", ref state)}");

            // Define a static local function called ProcessData that takes a string argument and a ref integer argument, and returns an integer
            static int ProcessData(string input, ref int currentState)
            {
                switch (currentState)
                {
                    case 0:
                        // If the current state is 0, print the input to the console and transition to state 1
                        Console.WriteLine(input);
                        currentState = 1;
                        break;
                    case 1:
                        // If the current state is 1, print the input to the console and transition to state 0
                        Console.WriteLine(input);
                        currentState = 0;
                        break;
                }

                // Return the current state
                return currentState;
            }

            // Call the GenerateID method twice and print the result to the console
            Console.WriteLine($"Example 1: Unique ID 1 is {GenerateID()}");
            Console.WriteLine($"Example 1: Unique ID 2 is {GenerateID()}");


            // Example 3: Using a static local function to generate a unique ID
            // Define a static local function called GenerateID that takes no arguments and returns a string
            static string GenerateID()
            {
                // Generate a new unique ID using a combination of a random number and the current time in ticks
                int randomNumber = new Random().Next(10000);
                long ticks = DateTime.UtcNow.Ticks;

                return $"{randomNumber}-{ticks}";
            }



            // Example 4: Using a static local function to perform a binary search

            // Declare an integer array called numbers and initialize it to the values 1, 3, 5, 7, and 9
            int[] numbers = { 1, 3, 5, 7, 9 };

            // Call the BinarySearch method with the argument 5 and print the result to the console
            Console.WriteLine($"Example 2: Index of 5 is {BinarySearch(5, numbers)}");

            // Define a static local function called BinarySearch that takes an integer argument and returns an integer
            static int BinarySearch(int target, int[] numbers)
            {
                // Perform a binary search for the target value within the numbers array
                int left = 0;
                int right = numbers.Length - 1;

                while (left <= right)
                {
                    int middle = (left + right) / 2;

                    if (numbers[middle] == target)
                    {
                        return middle;
                    }
                    else if (numbers[middle] < target)
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }

                // If the target value is not found, return -1
                return -1;
            }
        }
    }
}
