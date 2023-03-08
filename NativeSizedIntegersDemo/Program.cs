using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Using native-sized integers to improve performance
        int x = 10;
        nint nativeInt = new IntPtr(x).ToInt32();
        Console.WriteLine($"The value of nativeInt is: {nativeInt}");

        // Example 2: Using native-sized integers to interoperate with native code
        int[] intArray = new int[] { 1, 2, 3, 4, 5 };
        nint length = intArray.Length;
        Console.WriteLine($"The length of the intArray is: {length}");





    }





}