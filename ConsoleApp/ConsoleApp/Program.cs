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

            var employee = new Employee("Adam", "Kowalski", 35);

            while (true)
            {
                Console.Write("Podaj kolejną ocenę pracownika: ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine();
                    break;
                }
                employee.AddGrade(input);
            }


            var statistics = employee.GetStatistics();
            employee.ShowStatistics(statistics);
        }
    }
}
