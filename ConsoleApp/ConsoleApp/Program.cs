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
            employee.AddGrade("4");
            employee.AddGrade("7");
            employee.AddGrade("6,8");
            employee.AddGrade("10,5");
            employee.AddGrade(2.15);

            var statistics = employee.GetStatistics();

            employee.ShowStatistics(statistics, "Original");

        }
    }
}
