using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddDay3App;

namespace TddDay3UnitTests
{
    [TestClass]
    public class StorageModelTests
    {
        GuessGameEngine gameEngine;

        [TestInitialize]
        public void prepareGame()
        {
            gameEngine = new GuessGameEngine();

            RandomGenerator randGen=new RandomGenerator();
            randGen.StartPoint=55;
            randGen.EndPoint=55;

            gameEngine.randomGenerator = randGen;

            gameEngine.startGame();

            gameEngine.verifyGuess(10);
            gameEngine.verifyGuess(30);
            gameEngine.verifyGuess(50);
            
        }

        [TestMethod]
        public void TestWhetherGameIsSavedAfterEnded()
        {
            //play final step here
            gameEngine.verifyGuess(55);

            StorageModel storageModel = new StorageModel();
            FakeStorageConnector fakeConnector = new FakeStorageConnector();
            storageModel.StorageConnector = fakeConnector;

            bool result = storageModel.saveGame(gameEngine.playerName, gameEngine.RandomNumber, gameEngine.Attempts);

            Assert.IsTrue(result);
        }
    }
}
