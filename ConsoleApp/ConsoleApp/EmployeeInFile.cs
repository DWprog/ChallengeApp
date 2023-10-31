using System;
using System.IO;

namespace ConsoleApp
{
    public class EmployeeInFile : EmployeeBase
    {
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
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
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
        }

        public override void AddGrade(float grade)
        {
            this.AddGrade((double)grade);
        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((double)grade);
        }

        public override void AddGrade(char grade)
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

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                result.Average = 0;
                result.Max = int.MinValue;
                result.Min = int.MaxValue;
                result.Sum = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    int count = 0;
                    while (line != null)
                    {
                        var number = double.Parse(line);
                        if (number > result.Max)
                        {
                            result.Max = number;
                        }
                        if (number < result.Min)
                        {
                            result.Min = number;
                        }
                        result.Sum += number;
                        count++;
                        line = reader.ReadLine();
                    }
                    if (count > 0)
                    {
                        result.Average = result.Sum / count;
                    }
                }

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
                throw new Exception($"File {fileName} does not exist");
            }

            return result;
        }
    }
}
