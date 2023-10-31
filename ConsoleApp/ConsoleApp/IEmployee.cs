using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        public void AddGrade(double grade);

        public void AddGrade(string grade);

        public void AddGrade(float grade);
        public void AddGrade(int grade);

        public void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
