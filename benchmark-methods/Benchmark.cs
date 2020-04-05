using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace benchmark_methods
{
    public partial class Benchmark
    {
        private readonly int _runNumberOfTimes;
        public List<BenchmarkTime> Results { get; set; }
        private readonly Stopwatch _timer;

        public Benchmark(int runEachMethod = 10)
        {
            if (runEachMethod <= 0) throw new ArgumentOutOfRangeException(nameof(runEachMethod), runEachMethod, "Cannot run 0 or less times");

            Results = new List<BenchmarkTime>();
            _runNumberOfTimes = runEachMethod;
            _timer = new Stopwatch();
        }

        public T1 AddMethod<T1>(Func<T1> funcToRun, string name)
        {
            _timer.Start();

            var result = funcToRun();


            for (int i = 1; i < _runNumberOfTimes; i++)
            {
                funcToRun();
            }

            _timer.Stop();


            Results.Add(new BenchmarkTime
            {
                Name = name,
                TimeElapsed = _timer.Elapsed 
            });

            _timer.Reset();
            //Do stuff before running function as normal
            return result;
        }
    }
}