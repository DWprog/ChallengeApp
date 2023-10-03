using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int sex; //1=mężczyzna, 0=kobieta
            int age;
            
            int ageLimit = 30;
            int ageAdult = 18;

            name = "Dorota";
            sex = 0;
            age = 37;

            if (sex==1) //mężczyzna
            {
                if (age<ageAdult)
                {
                    Console.WriteLine("Niepełnoletni mężczyzna");
                }

                else if (age<ageLimit)
                {
                    Console.WriteLine($"Mężczyzna poniżej {ageLimit} lat");
                }
                else
                {
                    Console.WriteLine($"{name}, lat {age}");
                }
            }

            if (sex == 0) //kobieta
            {
                if (age < ageAdult)
                {
                    Console.WriteLine("Niepełnoletnia kobieta");
                }

                else if (age < ageLimit)
                {
                    Console.WriteLine($"Kobieta poniżej {ageLimit} lat");
                }
                else
                {
                    Console.WriteLine($"{name}, lat {age}");
                }
            }
        }
    }
}
