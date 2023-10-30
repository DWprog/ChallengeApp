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

            var supervisor = new Supervisor("Tomasz", "Nowak");

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
                    supervisor.AddGrade(input);

                }
                catch (Exception e)
                {

                    Console.WriteLine($"Exception catched: {e.Message}");
                }
            }


            var statistics = supervisor.GetStatistics();
            supervisor.ShowStatistics(statistics);
        }
    }
}
