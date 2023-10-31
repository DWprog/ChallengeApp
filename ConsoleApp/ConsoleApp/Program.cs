using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
            Console.WriteLine("===========================================");
            Console.WriteLine();

            var employee = new EmployeeInFile("Tomasz", "Nowak");

            //while (true)
            //{
            //    Console.Write("Podaj kolejną ocenę pracownika: ");
            //    var input = Console.ReadLine();
            //    if (input == "q")
            //    {
            //        Console.WriteLine();
            //        break;
            //    }

            //    try
            //    {
            //        employee.AddGrade(input);

            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine($"Exception catched: {e.Message}");
            //    }
            //}

            var statistics = employee.GetStatistics();

            Console.WriteLine($"Statistic of employee {employee.Name} {employee.Surname}");
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Sum: {statistics.Sum}");
            Console.WriteLine($"Average letter: {statistics.AverageLetter}");
            Console.WriteLine();
        }
    }
}
