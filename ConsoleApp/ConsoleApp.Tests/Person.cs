using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests
{
    public class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            this.Name = name;
        }        
    }
}
