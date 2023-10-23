using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectStats()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddGrade(5);
            employee.AddGrade(100);
            employee.AddGrade(150);
            employee.AddGrade(99);
            
            //act
            var statistics=employee.GetStatistics();
            
            //assert
            Assert.AreEqual(5, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(68, statistics.Average);
            Assert.AreEqual(204, statistics.Sum);
        }

        [Test]
        public void WhenEmployeeCollectNegativeGrades_ShouldReturnCorrectStats()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddGrade(7.13);
            employee.AddGrade(3.54);
            employee.AddGrade(8.26);
            employee.AddGrade(-5.42);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3.54, statistics.Min);
            Assert.AreEqual(8.26, statistics.Max);
            Assert.AreEqual(6.31, statistics.Average);
            Assert.AreEqual(18.93, statistics.Sum);
        }

        [Test]
        public void WhenEmployeeCollectSmallLetterStringGrades_ShouldCorrectStats()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddGrade("a");
            employee.AddGrade("b");
            employee.AddGrade("c");
            employee.AddGrade("d");
            employee.AddGrade("e");

            
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Average);
            Assert.AreEqual(300, statistics.Sum);
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenEmployeeCollectBigLetterStringGrades_ShouldCorrectStats()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddGrade("A");
            employee.AddGrade("B");
            employee.AddGrade("C");
            employee.AddGrade("D");
            employee.AddGrade("E");

            
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Average);
            Assert.AreEqual(300, statistics.Sum);
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenEmployeeCollectSmallLetterCharGrades_ShouldCorrectStats()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');
            employee.AddGrade('d');
            employee.AddGrade('e');


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Average);
            Assert.AreEqual(300, statistics.Sum);
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void WhenEmployeeCollectBigLetterCharGrades_ShouldCorrectStats()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(60, statistics.Average);
            Assert.AreEqual(300, statistics.Sum);
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}