using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using System.Collections.Generic;

namespace Benchmark.App
{
    [MemoryDiagnoser]
    public class ListVsArray
    {
        int[] values;
        public ListVsArray()
        {
            values = new int[] { 5, 42, 38, 21, 27, 39, 44, 21, 4, 23 };
        }

        [Benchmark]
        public void List()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                numbers.Add(values[i]);
            }
        }

        [Benchmark]
        public void Array()
        {
            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = values[i];
            }
        }
    }
}
