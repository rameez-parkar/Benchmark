using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.App
{
    [MemoryDiagnoser]
    public class ForVsForEach
    {
        int[] values;
        public ForVsForEach()
        {
            values = new int[]{ 5, 42, 38, 21, 27, 39, 44, 21, 4, 23};
        }

        [Benchmark]
        public void For()
        {
            int sum = 0;
            for(int i=0; i<values.Length; i++)
            {
                sum += values[i];
            }
        }

        [Benchmark]
        public void ForEach()
        {
            int sum = 0;
            foreach(var value in values)
            {
                sum += value;
            }
        } 
    }
}
