using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace EnhancedLinePragmaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Simple demonstration of Enhanced #line pragma
            SimpleDemo();

            // Example 2: Demonstration of using Enhanced #line pragma in a real-life scenario
            EnterpriseDemo();
        }

        // Example 1: Simple demonstration of Enhanced #line pragma
        static void SimpleDemo()
        {
#line 100 "foo.cs"
            Console.WriteLine(
                $"Current file: {Environment.StackTrace.Substring(Environment.StackTrace.LastIndexOf("at ") + 3)}");

#line default
            Console.WriteLine(
                $"Current file: {Environment.StackTrace.Substring(Environment.StackTrace.LastIndexOf("at ") + 3)}");
        }

        // Example 2: Demonstration of using Enhanced #line pragma in a real-life scenario
        static void EnterpriseDemo()
        {
            // Example: Generate source code dynamically and specify file name and line number using Enhanced #line pragma
            string sourceCode = @"
                using System;

                namespace DynamicCodeDemo
                {
                    class DynamicClass
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine(""Hello, world!"");
                        }
                    }
                }
            ";

#line 1 "DynamicClass.cs"
            Console.WriteLine($"Generating source code at {DateTime.Now}");

#line 3 "DynamicClass.cs"
            Console.WriteLine($"Compiling source code...");

            // Example: Compile the source code dynamically and execute the generated assembly

        }
    }
}