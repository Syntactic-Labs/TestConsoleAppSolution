using System;

namespace TestConsoleApp
{
    class Program
    {
        /*
         * True False Tables
         *    and
         * x | y | x&&y
         * =   =   ====
         * T   T    T
         * T   F    F
         * F   T    F
         * F   F    F
         *    or
         * x | y | x||y
         * T   T    T
         * T   F    T
         * F   T    T
         * F   F    F
         *    not
         * x | !x
         * T | F
         * F | T
        */ 
        static void Main(string[] args)
        {
            Console.WriteLine("Pancakes!!!!!");
            var CostOfBootcamp = 15500.0;
            var NumberOfDays = 65;
            var CostPerDay = CostOfBootcamp / NumberOfDays;
            var PreMessage = "I am paying $";
            var PostMessage = " per day for boot camp!";
            var Message = $"{PreMessage}{CostPerDay}{PostMessage}";
            Console.WriteLine($"{Message}");
            //shows message in output ctrl+W,O to see output
            System.Diagnostics.Debug.WriteLine($"{Message}");
        }
    }
}
