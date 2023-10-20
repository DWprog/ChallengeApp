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
            var statistics1 = employee.GetStatisticsWithForEach();
            var statistics2 = employee.GetStatisticsWithFor();
            var statistics3 = employee.GetStatisticsWithDoWhile();
            var statistics4 = employee.GetStatisticsWithWhile();

            Console.Write("Grades are: ");
            foreach (var grade in employee.grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine("\n");

            employee.ShowStatistics(statistics, "Original");
            employee.ShowStatistics(statistics1, "ForEach");
            employee.ShowStatistics(statistics2, "For");
            employee.ShowStatistics(statistics3, "Do While");
            employee.ShowStatistics(statistics4, "While");
        }
    }
}
