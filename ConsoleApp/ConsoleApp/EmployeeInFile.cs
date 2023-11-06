using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                GradeAdded?.Invoke(this, new EventArgs());
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                var grades = new List<double>();

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = double.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }

                if (grades.Count != 0)
                {
                    result.Average = grades.Average();
                    result.Max = grades.Max();
                    result.Min = grades.Min();
                    result.Sum = grades.Sum();

                    switch (result.Average)
                    {
                        case var average when average >= 80:
                            result.AverageLetter = 'A';
                            break;
                        case var average when average >= 60:
                            result.AverageLetter = 'B';
                            break;
                        case var average when average >= 40:
                            result.AverageLetter = 'C';
                            break;
                        case var average when average >= 20:
                            result.AverageLetter = 'D';
                            break;
                        default:
                            result.AverageLetter = 'E';
                            break;
                    }
                }
                else
                {
                    throw new Exception($"The file {fileName} does not contain grades");
                }
            }
            else
            {
                throw new Exception($"The file {fileName} does not exist");
            }

            return result;
        }
    }
}
