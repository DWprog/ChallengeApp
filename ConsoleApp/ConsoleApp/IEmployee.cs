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

        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(char grade);

        //event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}
