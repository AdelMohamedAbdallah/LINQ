using BenchmarkDotNet.Attributes;

namespace SeedData.BLL.Repositories
{
    [MemoryDiagnoser]
    public class TestBenchmark
    {
        [Benchmark]
        public void TestForeach()
        {
            foreach (var item in Enumerable.Range(0, 10))
            {
                Console.WriteLine(item);
            }
        }

        [Benchmark]
        public void TestFor()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
