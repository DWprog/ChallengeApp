using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; set; }
        private List<double> grades = new List<double>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (double.TryParse(grade, out double result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not double");
            }
        }

        public void AddGrade(float grade)
        {
            this.AddGrade((double)grade);
        }








        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = this.grades.Average();
            statistics.Max = this.grades.Max();
            statistics.Min = this.grades.Min();
            statistics.Sum = this.grades.Sum();

            return statistics;
        }



        public void ShowStatistics(Statistics statistics, string no)
        {
            Console.WriteLine($"{no}");
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Sum: {statistics.Sum}\n");
        }
    }
}
