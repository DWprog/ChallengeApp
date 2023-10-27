using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Person
    {
        protected string Name { get; private set; }
        protected string Surname { get; private set; }
        protected int Age { get; set; }
        protected char Sex { get; private set; }

        
        protected Person(string name, string surname, char sex,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }


    }
}
