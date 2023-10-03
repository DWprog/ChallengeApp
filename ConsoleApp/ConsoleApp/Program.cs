using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 1234567892334445555;
            string numInStr = number.ToString();
            char[] letters = numInStr.ToCharArray();

            List<char> digits = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int counter;

            Console.WriteLine($"Liczba {number} ma następującą ilość cyfr:");

            foreach (var digit in digits)
            {
                counter = 0;
                foreach (var letter in letters)
                {
                    if(digit==letter)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{digit} => {counter}");
            }
            
            
        }
    }
}
