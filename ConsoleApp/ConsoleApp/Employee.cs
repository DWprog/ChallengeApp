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
        public List<double> grades = new List<double>();

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

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            int count = 0;
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var grade in this.grades)
            {
                if (grade > max)
                {
                    max = grade;
                }

                if (grade < min)
                {
                    min = grade;
                }

                sum += grade;
                count++;
            }
            statistics.Average = sum / count;
            statistics.Max = max;
            statistics.Min = min;
            statistics.Sum = sum;

            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            int count;
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;


            for (count = 0; count < this.grades.Count; count++)
            {
                if (this.grades[count] > max)
                {
                    max = this.grades[count];
                }

                if (this.grades[count] < min)
                {
                    min = this.grades[count];
                }

                sum += this.grades[count];
            }
            statistics.Average = sum / count;
            statistics.Max = max;
            statistics.Min = min;
            statistics.Sum = sum;

            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            int count = 0;

            do
            {
                if (this.grades[count] > max)
                {
                    max = this.grades[count];
                }

                if (this.grades[count] < min)
                {
                    min = this.grades[count];
                }

                sum += this.grades[count];
                count++;
            } while (count < this.grades.Count);

            statistics.Average = sum / count;
            statistics.Max = max;
            statistics.Min = min;
            statistics.Sum = sum;

            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            int count = 0;

            while (count < this.grades.Count)
            {
                if (this.grades[count] > max)
                {
                    max = this.grades[count];
                }

                if (this.grades[count] < min)
                {
                    min = this.grades[count];
                }

                sum += this.grades[count];
                count++;
            }
            statistics.Average = sum / count;
            statistics.Max = max;
            statistics.Min = min;
            statistics.Sum = sum;

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
