using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_02;

namespace tddTestProject
{
    [TestClass]
    public class GuessGameEngineTests
    {
        [TestMethod]
        public void CheckIfGameStarted()
        {
            var target = getTarget();
            target.startGame();

            Assert.IsTrue(target.isStarted);
        }

        [TestMethod]
        public void CheckIfGameStartedTwiceThrowException()
        {
            var target = getTarget();

            try
            {
                target.startGame();
                target.startGame();

                Assert.Fail("fialed");
            }
            catch (AssertFailedException) { throw; }
            catch(Exception ex)
            {
                var result = ex.Message.Contains("Game has already started!");

                Assert.IsTrue(result);
            }
            
        }

        [TestMethod]
        public void IfNumberLessThanRandomNumberReturnAimHigher()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 1;

            string message = target.verifyGuess(userInput);

            Assert.AreEqual("Aim Higher!", message);
        }

        [TestMethod]
        public void IfNumberHigherThanRandomNumberReturnAimLower()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 21;

            string message = target.verifyGuess(userInput);

            Assert.AreEqual("Aim Lower!", message);
        }

        [TestMethod]
        public void IfNumberEqualToRandomNumberReturnSucess()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 10;

            string message = target.verifyGuess(userInput);
            var result = message.StartsWith("You've got it in");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckAttemptsAreCorrect()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 21;
            string message = target.verifyGuess(userInput);

            userInput = 10;
            message = target.verifyGuess(userInput);

            var result = message.StartsWith("You've got it in");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfGameHasEnded()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 21;
            string message = target.verifyGuess(userInput);

            userInput = 10;
            message = target.verifyGuess(userInput);

            Assert.IsTrue(target.isGameEnded);
        }

        [TestMethod]
        public void CheckIfGameHasNotEndedInitial()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 21;
            string message = target.verifyGuess(userInput);

            Assert.IsFalse(target.isGameEnded);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
         "A userId of null was inappropriately allowed.")]
        public void CheckStatusResetAfterRestart()
        {
            var target = getTarget();
            RandomGenerator randGen = new RandomGenerator();
            randGen.StartPoint = 10; randGen.EndPoint = 10;
            target.randomGenerator = randGen;
            var randomNumber = target.generateRandomNumber();

            var userInput = 21;
            string message = target.verifyGuess(userInput);

            userInput = 10;
            message = target.verifyGuess(userInput);

            target.restart();
            var result = false;

            if (target.Attempts == 0 && !target.isGameEnded && target.isStarted)
                result = true;

            Assert.IsTrue(result);
        }


        public GuessGameEngine getTarget()
        {
            return new GuessGameEngine();
        }
    }
}
