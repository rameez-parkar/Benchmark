using System;
using BenchmarkDotNet.Running;
using System.Linq;

namespace Benchmark.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var ffe = BenchmarkRunner.Run<ForVsForEach>();
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
            var la = BenchmarkRunner.Run<ListVsArray>();
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
            var ssb = BenchmarkRunner.Run<StringVsStringBuilder>();
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
            var cs = BenchmarkRunner.Run<ClassVsStruct>();
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
            var tt = BenchmarkRunner.Run<ThreadVsTask>();
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}
