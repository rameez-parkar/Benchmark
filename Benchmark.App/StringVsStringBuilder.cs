using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using System.Text;

namespace Benchmark.App
{
    [MemoryDiagnoser]
    public class StringVsStringBuilder
    {
        [Benchmark]
        public void String()
        {
            string hello = "Hello";
            for(int i=0; i<10000; i++)
            {
                hello += " World!";
            }
        }

        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder hello = new StringBuilder("Hello");
            for(int i=0; i<10000; i++)
            {
                hello.Append(" World!");
            }
        }
    }
}
