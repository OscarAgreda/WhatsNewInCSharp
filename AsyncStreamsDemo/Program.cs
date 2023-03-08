namespace AsyncStreamsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static async Task Main(string[] args)
            {
                // await foreach is a C# language feature that allows asynchronous iteration over an IAsyncEnumerable.
                // When the await foreach statement is executed, it asynchronously retrieves the next element from the
                // sequence, and assigns it to the specified variable. If there are no more elements in the sequence,
                // the loop exits.
                await foreach (int number in GenerateSequenceAsync())
                {
                    Console.WriteLine(number);
                }
            }
            //IAsyncEnumerable<T> is an interface that represents an asynchronous sequence of elements of type T.
            //It is similar to IEnumerable<T>, but supports asynchronous iteration using the await foreach statement.
            static async IAsyncEnumerable<int> GenerateSequenceAsync()
            {
                // Generate a sequence of integers asynchronously using the IAsyncEnumerable interface
                for (int i = 0; i < 5; i++)
                {
                    // Simulate a delay (e.g. I/O operation) with Task.Delay
                    await Task.Delay(1000);

                    // yield return is a C# language feature that allows a method to return
                    // a sequence of values one at a time, without generating the entire sequence
                    // upfront. When the yield return statement is executed, the current state of
                    // the method is saved, and execution is suspended until the next value in the
                    // sequence is requested. This allows the method to generate the sequence incrementally,
                    // as the caller requests each value.
                    yield return i;
                }
            }
        }
    }
}