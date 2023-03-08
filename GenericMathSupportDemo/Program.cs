using System;
using System.Numerics;

namespace GenericMathSupportDemo
{

    // The Generic math support feature is a new feature in C# 11 that provides a set of built-in mathematical operations that can be used with any numeric type. This can be useful in scenarios where you need to perform mathematical operations on generic types or user-defined types.
    // 
    // In example 1, we have a demonstration of adding complex numbers using the Generic math support feature. We create two complex numbers called a and b, and we add them together using the + operator. The + operator is one of the built-in mathematical operations that are provided by the Generic math support feature. We then print the result to the console.
    // 
    // In example 2, we have a demonstration of calculating the Euclidean distance between two points using the Generic math support feature. We use the built-in Math class to calculate the distance using the Pythagorean theorem. The Math class provides a set of built-in mathematical operations that are compatible with any numeric type, including the double type that we use in this example. We then print the result to the console.

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Add complex numbers using the Generic math support feature
            AddComplexNumbersDemo();

            // Example 2: Calculate Euclidean distance using the Generic math support feature
            CalculateEuclideanDistanceDemo();
        }

        // Example 1: Add complex numbers using the Generic math support feature
        static void AddComplexNumbersDemo()
        {
            // Example: Add two complex numbers using the + operator
            Complex a = new Complex(3, 4);
            Complex b = new Complex(1, 2);
            Complex c = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {c}");
        }

        // Example 2: Calculate Euclidean distance using the Generic math support feature
        static void CalculateEuclideanDistanceDemo()
        {
            // Example: Calculate the Euclidean distance between two points using the built-in Math class
            double x1 = 2;
            double y1 = 3;
            double x2 = 5;
            double y2 = 7;
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"The distance between ({x1}, {y1}) and ({x2}, {y2}) is {distance}");
        }
    }
}