using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pancakes!!!!!");
            var CostOfBootcamp = 15500.0;
            var NumberOfDays = 65;
            var CostPerDay = CostOfBootcamp / NumberOfDays;
            Console.WriteLine($"I am paying ${CostPerDay} per day for boot camp!");
        }
    }
}
