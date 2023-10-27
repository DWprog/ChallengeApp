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

            var employee = new Employee("Adam", "Kowalski",'M', 35);

            while (true)
            {
                Console.Write("Podaj kolejną ocenę pracownika: ");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine();
                    break;
                }

                try
                {
                    employee.AddGrade(input);

                }
                catch (Exception e)
                {

                    Console.WriteLine($"Exception catched: {e.Message}");
                }
            }


            var statistics = employee.GetStatistics();
            employee.ShowStatistics(statistics);
        }
    }
}
