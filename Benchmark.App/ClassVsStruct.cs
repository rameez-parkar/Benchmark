using BenchmarkDotNet.Attributes;

namespace Benchmark.App
{
    [MemoryDiagnoser]
    public class ClassVsStruct
    {
        [Benchmark]
        public void Class()
        {
            Class objC = new Class();
            for (int i = 0; i < 1000; i++)
            {
                objC.FullName("ABC", "XYZ");
            }
        }

        [Benchmark]
        public void Struct()
        {
            Struct objS;
            for (int i = 0; i < 1000; i++)
            {
                objS.FirstName = "ABC";
                objS.LastName = "XYZ";
            }
        }
    }

    public class Class
    {
        public string FirstName;
        public string LastName;
        public void FullName(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

    public struct Struct
    {
        public string FirstName;
        public string LastName;
    }
}
