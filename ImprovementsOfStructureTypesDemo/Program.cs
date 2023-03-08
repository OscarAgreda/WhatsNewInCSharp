using System;
using System.Drawing;

namespace StructTypesDemo
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }



    public class Program
    {
        static void Main(string[] args)
        {

            // In this example, we define a struct type Point with two integer properties X and Y. We then create an array of Point structs and pass it to a generic method ReverseArray that reverses the order of the array. The where T : struct constraint in the method signature ensures that only struct types can be used as generic arguments.
            // Create an array of Point structs
            Point[] points = { new Point { X = 0, Y = 0 }, new Point { X = 1, Y = 1 }, new Point { X = 2, Y = 2 } };

            // Call a generic method that operates on struct types
            var reversedPoints = ReverseArray<Point>(points);

            // Print the reversed points
            foreach (var point in reversedPoints)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }





            // In the code example, we have a struct called Point which has two fields X and Y. When we pass a struct to a method, the default behavior is to pass it by value. This means that a copy of the struct is made and passed to the method, rather than passing the actual struct itself. This can be a performance concern when the struct is large, or when the struct is being passed to the method many times.
            // 
            // In C# 10, a new keyword in has been introduced which allows us to pass a struct by reference instead of by value. The in keyword indicates that the method should accept the struct as a read-only parameter. This means that the method cannot modify the struct in any way. The in keyword can be used with any struct type, and it can provide performance benefits in some scenarios by avoiding the need to make a copy of the struct.
            // 
            // In the code example, we define a method called PrintPoint which takes an in parameter of the Point struct. This method simply prints out the X and Y values of the Point. We then create a new Point struct called p with the values 3 and 4. We pass this struct to the PrintPoint method using the in keyword to indicate that we want to pass it by reference. By doing so, we avoid making a copy of the struct and passing it to the method, which can be more efficient in some cases.


            // Create a Point struct
            Point point2 = new Point { X = 0, Y = 0 };

            // Pass the struct to a method that takes an 'in' parameter
            PrintPoint(in point2);
        }

        // Generic method that reverses an array of structs
        static T[] ReverseArray<T>(T[] array) where T : struct
        {
            T[] reversedArray = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            return reversedArray;
        }


        // Method that takes an 'in' parameter of a struct type
        static void PrintPoint(in Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}