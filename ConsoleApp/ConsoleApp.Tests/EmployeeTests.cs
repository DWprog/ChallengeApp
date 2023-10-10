using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Adam", "Kowalski", 35);
            user.ScoreAdd(5);
            user.ScoreAdd(6);

            //act
            var result = user.ScoreSum;
            
            //assert
            Assert.AreEqual(11, user.ScoreSum);
        }

        [Test]
        public void WhenUserCollectNegativeScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Adam", "Kowalski", 35);
            user.ScoreAdd(5);
            user.ScoreAdd(7);
            user.ScoreAdd(2);
            user.ScoreAdd(-6);

            //act
            var result = user.ScoreSum;

            //assert
            Assert.AreEqual(8, user.ScoreSum);
        }
    }
}