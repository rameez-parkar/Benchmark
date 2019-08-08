using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using System.Threading;
using System.Threading.Tasks;

namespace Benchmark.App
{
    [MemoryDiagnoser]
    public class ThreadVsTask
    {
        [Benchmark]
        public void Threads()
        {
            Thread t1 = new Thread(HelloWorld);
            Thread t2 = new Thread(HelloFriend);
            t1.Start();
            t2.Start();
        }
        public static void HelloWorld()
        {
            Thread.Sleep(3000);
            string hello = "Hello";
            for (int i = 0; i < 100; i++)
            {
                hello += " World!";
            }
        }
        public static void HelloFriend()
        {
            Thread.Sleep(3000);
            string hello = "Hello";
            for (int i = 0; i < 100; i++)
            {
                hello += " Friend!";
            }
        }

        [Benchmark]
        public void Tasks()
        {
            Task.Run(async () =>
            {
                var t1 = HelloFriendTask();
                var t2 = HelloWorldTask();
                await Task.WhenAll(t1, t2);
            }).GetAwaiter().GetResult();
        }

        public async static Task HelloFriendTask()
        {
            await Task.Delay(3000);
            string hello = "Hello";
            for (int i = 0; i < 10000; i++)
            {
                hello += " Friend!";
            }
        }
        public async static Task HelloWorldTask()
        {
            await Task.Delay(3000);
            string hello = "Hello";
            for(int i=0; i<10000; i++)
            {
                hello += " World!";
            }
        }
    }
}
