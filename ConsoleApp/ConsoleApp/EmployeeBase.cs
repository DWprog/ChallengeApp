using System;

namespace ConsoleApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(double grade);

        public void AddGrade(string grade)
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

        public void AddGrade(float grade)
        {
            this.AddGrade((double)grade);
        }

        public void AddGrade(int grade)
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

        public abstract Statistics GetStatistics();
    }
}
