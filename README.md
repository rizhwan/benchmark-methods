# benchmark-methods
Test how long each method take to execute. Testas 100s or even million times.

## Minimum platform versions that supported
.NET Core 1.0  
.NET Framework 4.5  
Mono 4.6  

# How to use

All you have to do to start running is to use
```c#
var benchmark = new Benchmark(1000);

var result1 = benchmark.AddMethod(() => ReverseCharacters.WithoutFramework(_randomSentance), "Method one");
var result2 = benchmark.AddMethod(() => ReverseCharacters.WithFramework(_randomSentance), "Method two");
 ```
## Note
Even Though the library written for .NET Standard 1.0, the sample test written on .net core 3.0.
https://docs.microsoft.com/en-us/dotnet/standard/net-standard#net-implementation-support

# Changes