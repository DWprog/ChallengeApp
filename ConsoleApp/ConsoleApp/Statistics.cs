using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Statistics
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public double Sum { get; private set; }
        public int Count { get; private set; }
        public double Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = double.MinValue;
            this.Min = double.MaxValue;
        }

        public void AddGrade(double grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(grade, this.Max);
            this.Min = Math.Min(grade, this.Min);

        }
    }
}
