using NUnit.Framework;
using GuessingGame_v2.BLL;

namespace GuessingGame_v2.Tests
{
    [TestFixture]
    public class GuessManagerTests
    {

        [Test]
        public void InvalidGuessTest()
        {
        GameManager gameInstance = new GameManager();
        gameInstance.Start();

        GuessResult actual = gameInstance.ProcessGuess(152);
        Assert.AreEqual(GuessResult.Invalid, actual);
        }

        [Test]
        public void HigherGuessResult()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(6);
            Assert.AreEqual(GuessResult.Higher, actual);
        }

        [Test]
        public void LowerGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(12);
            Assert.AreEqual(GuessResult.Lower, actual);
        }

        [Test]
        public void VictoryGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(7);
            Assert.AreEqual(GuessResult.Victory, actual);
        }

    }
}
