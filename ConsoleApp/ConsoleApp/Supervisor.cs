using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Supervisor : IEmployee
    {
        private List<double> grades = new List<double>();
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;

                default:
                    if (double.TryParse(grade, out double result))
                    {
                        this.AddGrade(result);
                    }
                    else if (char.TryParse(grade, out char resultChar))
                    {
                        this.AddGrade(resultChar);
                    }
                    else
                    {
                        throw new Exception("String is not double");
                    }
                    break;
            }
        }

        public void AddGrade(float grade)
        {
            this.AddGrade((double)grade);
        }

        public void AddGrade(char grade)
        {
            switch (char.ToLower(grade))
            {
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'e':
                    this.AddGrade(20);
                    break;

                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = this.grades.Average();
            statistics.Max = this.grades.Max();
            statistics.Min = this.grades.Min();
            statistics.Sum = this.grades.Sum();

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
        public void ShowStatistics(Statistics statistics, string no = "")
        {
            Console.WriteLine("Grades are:");
            foreach (var grade in this.grades)
            {
                Console.WriteLine($"{grade}");
            }
            Console.WriteLine();

            Console.WriteLine($"{no}");
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Sum: {statistics.Sum}");
            Console.WriteLine($"Average letter: {statistics.AverageLetter}");
            Console.WriteLine();
        }
    }
}
