using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Adam", "Kamizelich", 32);
            employee.AddGrade(4);
            employee.AddGrade(7.5);
            employee.AddGrade(2.15);

            var statistics = employee.GetStatistics();
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine($"Min: {statistics.Min}");




        }
    }
}
