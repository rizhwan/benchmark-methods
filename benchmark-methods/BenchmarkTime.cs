using System;

namespace benchmark_methods
{
    public partial class Benchmark
    {
        public class BenchmarkTime
        {
            public string Name { get; set; }
            public TimeSpan TimeElapsed { get; set; }
            public string TotalMilliseconds { get { return TimeElapsed.TotalMilliseconds.ToString(); } }
        }
    }
}