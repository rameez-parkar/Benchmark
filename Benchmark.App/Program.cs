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
            var la = BenchmarkRunner.Run<ListVsArray>();
            var ssb = BenchmarkRunner.Run<StringVsStringBuilder>();
            var tt = BenchmarkRunner.Run<ThreadVsTask>();
            var cs = BenchmarkRunner.Run<ClassVsStruct>();
        }
    }
}
