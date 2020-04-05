using System;
using benchmark_methods;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var benchmark = new Benchmark(1000000);

            var result1 = benchmark.AddMethod(() => ReverseCharacters.WithoutFramework(_randomSentance), nameof(ReverseCharacters.WithoutFramework));
            var result2 = benchmark.AddMethod(() => ReverseCharacters.WithFramework(_randomSentance), nameof(ReverseCharacters.WithFramework));

            foreach (var currentResult in benchmark.Results)
            {
                Console.Write("Method: ");
                Console.WriteLine(currentResult.Name);
                Console.Write("Total Seconds: ");
                Console.WriteLine(currentResult.TimeElapsed.TotalSeconds);
                Console.WriteLine("--------");
            }

            Console.WriteLine("Benchmark done");
            Console.ReadLine();
        }

        private static readonly string _randomSentance = "She had said I’m tired of begging God to overthrow my son, " +
                "because all this business of living in the presidential palace is like having the lights on all the time, " +
                "sir, and she had said it with the same naturalness with which on one national holiday she had made her way " +
                "through the guard of honor with a basket of empty bottles and reached the presidential limousine that was " +
                "leading the parade of celebration in an uproar of ovations and martial music and storms of flowers and she shoved " +
                "the basket through the window and shouted to her son that since you’ll be passing right by take advantage and " +
                "return these bottles to the store on the corner, poor mother.";
    }
}
