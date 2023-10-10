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
            employee.AddGrade(4.7);
            employee.AddGrade(2.3);
            employee.AddGrade(6.9);
            
            //act
            var statistics=employee.GetStatistics();
            
            //assert
            Assert.AreEqual(2.3, statistics.Min);
            Assert.AreEqual(6.9, statistics.Max);
            Assert.AreEqual(4.725, statistics.Average);
            Assert.AreEqual(18.9, statistics.Sum);
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
            Assert.AreEqual(-5.42, statistics.Min);
            Assert.AreEqual(8.26, statistics.Max);
            Assert.AreEqual(3.3775, statistics.Average);
            Assert.AreEqual(13.51, statistics.Sum);
        }

      

    }
}