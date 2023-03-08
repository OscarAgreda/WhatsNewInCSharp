using System;

namespace MethodGroupConversionDemo
{
    // The Improved method group conversion to delegate feature makes it easier to convert method groups to delegates, which are used extensively in C# for event handlers, LINQ queries, and more. The feature allows you to use lambda expressions to create delegates instead of the older delegate syntax, which can be more verbose and harder to read.
    class Program
    {
        static void Main(string[] args)
        {
            // Sample 1: Improved method group conversion to delegate
            //demonstrates the syntax differences between the old and new method group conversion syntax. It creates two delegates that perform the same addition operation, but one is created using the old syntax with the delegate keyword, and the other is created using the new syntax with a lambda expression. Both delegates are called with different arguments, and the results are printed to the console.
            Console.WriteLine("Sample 1: Improved method group conversion to delegate");

            // Create a delegate using the old method group conversion syntax
            Func<int, int, int> oldDelegate = delegate (int x, int y) { return x + y; };

            // Create a delegate using the improved method group conversion syntax
            Func<int, int, int> newDelegate = (x, y) => x + y;

            // Call both delegates and print the result
            int result1 = oldDelegate(1, 2);
            int result2 = newDelegate(3, 4);
            Console.WriteLine($"Result 1: {result1}");
            Console.WriteLine($"Result 2: {result2}");

            Console.WriteLine();

            // Sample 2: Using improved method group conversion to subscribe to an event
            //demonstrates how the Improved method group conversion to delegate feature can be used to subscribe to an event. It creates a simple Counter class that counts up to a specified number and raises an event when the count is reached. It then subscribes to the CountReached event using the new method group conversion syntax with a lambda expression. Finally, it counts up to 5 and prints a message to the console each time the count is reached.
            Console.WriteLine("Sample 2: Using improved method group conversion to subscribe to an event");

            // Create an instance of the Counter class
            Counter counter = new Counter();

            // Subscribe to the CountReached event using the improved method group conversion syntax
            counter.CountReached += (sender, e) =>
            {
                Console.WriteLine($"Count reached {e.Count}");
            };

            // Count up to 5
            counter.CountTo(5);

            Console.ReadKey();
        }
    }

    // A simple class that counts up to a specified number and raises an event when the count is reached
    class Counter
    {
        public event EventHandler<CountEventArgs> CountReached;

        public void CountTo(int count)
        {
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                {
                    OnCountReached(i);
                }
            }
        }

        protected virtual void OnCountReached(int count)
        {
            CountReached?.Invoke(this, new CountEventArgs(count));
        }
    }

    // An event argument class for the CountReached event
    class CountEventArgs : EventArgs
    {
        public int Count { get; }

        public CountEventArgs(int count)
        {
            Count = count;
        }
    }
}
