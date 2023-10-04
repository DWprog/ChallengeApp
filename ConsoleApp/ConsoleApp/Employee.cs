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
        private List<int> score = new List<int>();

        public Employee(string name, string surname,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void ScoreAdd(int number)
        {
            this.score.Add(number);
        }
        public int ScoreSum
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void ShowData()
        {
            Console.WriteLine($"Imię: {Name}");
            Console.WriteLine($"Nazwisko: {Surname}");
            Console.WriteLine($"Wiek: {Age}");
            Console.WriteLine($"Suma punktów: {ScoreSum}");
        }
    }
}
