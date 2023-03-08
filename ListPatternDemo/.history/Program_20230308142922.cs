using System;
using System.Collections.Generic;

namespace ListPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple List Pattern
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            if (numbers is { Count: > 0 })
            {
                Console.WriteLine($"The list contains {numbers.Count} elements.");
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }

            // Example 2: Nested List Pattern
            int[] fibonacci = { 1, 2, 3, 5, 8 };

            bool result = false;

            // result is false, last number is not matching
            result = fibonacci is [1, 2, 3, 5, 9];

            // result is false, elements are not at same positions
            result = fibonacci is [8, 1, 2, 3, 5];

            // result is false, length is not matching
            result = fibonacci is [1, 2, 3, 5];

            // result is true, elements, positions and length is matching
            result = fibonacci is [1, 2, 3, 5, 8];



            // Example 3
            // In this example, we create a List of strings called animals with four elements. We then use a list pattern to check if the list contains a specific element, in this case, the string "dog". The pattern { Count: > 0, [1]: "dog" } matches any list that has a count greater than zero and has "dog" as its second element. If the pattern matches, we print a message saying that the list contains a dog; otherwise, we print a message saying that it does not.
            List<string> animals = new List<string> { "cat", "dog", "bird", "fish" };

            if (animals is { Count: > 0, [1]: "dog" })
            {
                Console.WriteLine("The list contains a dog!");
            }
            else
            {
                Console.WriteLine("The list does not contain a dog.");
            }

        }
    }
}