using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparisonLengthOfString()
        {
            //arrange
            var string1 = "One";
            var string2 = "Two";

            //act

            //assert
            Assert.AreEqual(string1.Length, string2.Length);
        }

        [Test]
        public void ComparisonOfString()
        {
            //arrange
            string string1 = "One";
            string string2 = "One";

            //act

            //assert
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void ComparisonOfInt()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Kowals", 32);
            var employee2 = GetEmployee("Adam", "Iksiński", 45);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void ComparisonEmployeeName()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Kowals", 32);
            var employee2 = GetEmployee("Adam", "Iksiński", 45);
            var employee3 = GetEmployee("Maciej", "Nowak", 18);


            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
            Assert.AreNotEqual(employee1.Name, employee3.Name);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

    }
}
