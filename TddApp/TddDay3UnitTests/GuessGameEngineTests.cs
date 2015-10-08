using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddDay3App;

namespace TddDay3UnitTests
{
    [TestClass]
    public class GuessGameEngineTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckIfGameHasPlayerNameBeforeStarted()
        {
            var target = getTarget();
            
            target.playerName = "Bob";
            target.startGame();

            Assert.IsTrue(target.isStarted);
        }

        [TestMethod]
        public void CheckIfGameStarted()
        {
            var target = getTarget();
            target.startGame();

            Assert.IsTrue(target.isStarted);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
         "Game has already started!")]
        public void CheckIfGameStartedTwiceThrowException()
        {
            var target = getTarget();
            
            target.startGame();
            target.startGame();
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
