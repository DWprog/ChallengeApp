using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var user1 = new Employee("Marek", "Nowak", 25);
            var user2 = new Employee("Tomasz", "Ibisz", 39);
            var user3 = new Employee("Maria", "Kowalska", 51);

            List<Employee> employees = new List<Employee>();
            employees.Add(user1);
            employees.Add(user2);
            employees.Add(user3);
                        
            user1.ScoreAdd(2);
            user1.ScoreAdd(9);
            user1.ScoreAdd(1);
            user1.ScoreAdd(7);
            user1.ScoreAdd(4); //suma 23

            user2.ScoreAdd(7);
            user2.ScoreAdd(10);
            user2.ScoreAdd(2);
            user2.ScoreAdd(4);
            user2.ScoreAdd(6); //suma 29

            user3.ScoreAdd(8);
            user3.ScoreAdd(4);
            user3.ScoreAdd(3);
            user3.ScoreAdd(5);
            user3.ScoreAdd(1); //suma 21

            int maxScore = 0;

            foreach (var employee in employees)
            {
                if(employee.ScoreSum>maxScore)
                {
                    maxScore = employee.ScoreSum;
                }
            }

            foreach (var employee in employees)
            {
                if (employee.ScoreSum==maxScore)
                {
                    employee.ShowData();
                }
            }

        }
    }
}
