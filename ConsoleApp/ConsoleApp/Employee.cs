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

        public Employee(string name, string surname,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
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
    }
}
