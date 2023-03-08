// Demo solution: AsyncMethodBuilder demo

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncMethodBuilderDemo
{
    class Program
    {
        // Example 1: Simple demonstration of AsyncMethodBuilder attribute

        [AsyncMethodBuilder(typeof(MyCustomBuilder))]
        static async Task<int> SimpleAsyncMethod()
        {
            await Task.Delay(1000);
            return 42;
        }

        class MyCustomBuilder
        {
            public static MyCustomBuilder Create() => new MyCustomBuilder();

            public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
            {
                stateMachine.MoveNext();
            }

            public void SetStateMachine(IAsyncStateMachine stateMachine) { }

            public void SetException(Exception exception) { }

            public void SetResult(int result) { }

            //public static Task<int> Task => Task.FromResult(0);
        }

        // Example 2: Complete demonstration of AsyncMethodBuilder attribute

        [AsyncMethodBuilder(typeof(MyCustomBuilder))]
        static async Task<string> CompleteAsyncMethod(string input)
        {
            Console.WriteLine("Starting CompleteAsyncMethod...");

            await Task.Delay(1000);

            Console.WriteLine("After first await in CompleteAsyncMethod...");

            await Task.Delay(2000);

            Console.WriteLine("After second await in CompleteAsyncMethod...");

            string output = input + " world!";
            return output;
        }

        static async Task Main()
        {
            // Example 1: Simple demonstration of AsyncMethodBuilder attribute

            int result1 = await SimpleAsyncMethod();
            Console.WriteLine($"SimpleAsyncMethod returned {result1}");

            // Example 2: Complete demonstration of AsyncMethodBuilder attribute

            string result2 = await CompleteAsyncMethod("Hello");
            Console.WriteLine($"CompleteAsyncMethod returned '{result2}'");
        }
    }
}
