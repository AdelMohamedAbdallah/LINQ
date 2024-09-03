using BenchmarkDotNet.Attributes;
using SeedData.DAL.Models;

namespace SeedData.BLL.Repositories
{
    public static class AccessData
    {
        [Benchmark]
        public static IEnumerable<Customer> AddCustomer(Customer newcustomer)
        {
            var Customers = GetData.GetCustomers();
            Customers.Add(newcustomer);
            foreach (var item in Customers)
            {
                yield return item;
            }
        }
        [Benchmark]
        public static IEnumerable<Customer> OrderCustomers(this IEnumerable<Customer> customers)
        {
            var resultorder = customers.OrderByDescending(x => x.age).Select(x => x).ToList();
            foreach (var item in resultorder)
            {
                yield return item;
            }
        }
        [Benchmark]
        public static void Print<T>(this IEnumerable<T> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

    }

}
