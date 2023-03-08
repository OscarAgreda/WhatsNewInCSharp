using System;

namespace LambdaImprovementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            //Example 1, Here, we have an array of numbers and we use a lambda expression with the Array.ForEach method to add up all the numbers in the array. We then print the total sum of the numbers.
            var numbers = new[] { 1, 2, 3, 4, 5 };
            int total = 0;

            Array.ForEach(numbers, x => total += x);

            Console.WriteLine($"The sum of the numbers {string.Join(", ", numbers)} is {total}.");



            // Example 2: Demonstrating the use of lambda expressions with tuples
            // In this case, we have a tuple containing two integers (x and y), and we define a lambda expression that multiplies these two integers together. We then call the lambda expression with the tuple and print the result of the multiplication.
            (int x, int y) = (5, 10);

            Func<(int, int), int> multiply = (point) => point.Item1 * point.Item2;

            Console.WriteLine($"The result of multiplying ({x}, {y}) is {multiply((x, y))}.");

            // Example 3: Demonstrating the use of lambda expressions with LINQ queries
            // In this case, we have an array of numbers and we use a lambda expression with the Where method to filter out all the even numbers in the array. We then print the even numbers.
            var numbers3 = new[] { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(x => x % 2 == 0);

            Console.WriteLine($"The even numbers in {string.Join(", ", numbers3)} are {string.Join(", ", evenNumbers)}.");

        }
    }
}