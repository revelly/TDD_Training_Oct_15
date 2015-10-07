using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_01;

namespace tddTestProject
{
    [TestClass]
    public class GameMathEngineTest
    {
        [TestMethod]
        public void is_game_started()
        {
            var target = getTarget();
            target.startGame();

            Assert.IsTrue(target.isStarted);
        }

        [TestMethod]
        public void has_set_start_point()
        {
            IRanger lowerClass = new LowerClass();
            var target = getTarget();
            target.ranger = lowerClass;

            target.ranger.setStartPoint(1);

            Assert.IsTrue(target.ranger.StartPoint > 0);
        }

        [TestMethod]
        public void has_set_end_point()
        {
            IRanger lowerClass = new LowerClass();
            var target = getTarget(); target.ranger = lowerClass;
            target.ranger.setEndPoint(100);

            Assert.IsTrue(target.ranger.EndPoint > 0);
        }


        [TestMethod]
        public void thow_exception_if_game_played_wihtout_start_point()
        {
            IRanger lowerClass = new LowerClass();
            var target = getTarget(); target.ranger = lowerClass;
            target.ranger.setStartPoint(1);
            try
            {
                target.play();
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void thow_exception_if_game_played_wihtout_end_point()
        {
            IRanger lowerClass = new LowerClass();
            var target = getTarget(); target.ranger = lowerClass;
            target.ranger.setStartPoint(1);
            //target.setEndPoint(10);

            try
            {
                target.play();
                Assert.IsTrue(false);
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void given_user_not_within_points_throw_exception()
        {
            IRanger lowerClass = new LowerClass();
            var target = getTarget(); target.ranger = lowerClass;
            var startPoint = 1;
            var endPoint = 100;

            target.ranger.setStartPoint(startPoint);
            target.ranger.setEndPoint(endPoint);

            var playNumber = 300;
            try
            {
                target.isWithinPoints(playNumber);

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void WhenInputDivisibleBy3ReturnHot()
        {
            var target = getTarget();
            var userInput = 3;

            var result = target.compute(userInput);

            Assert.AreEqual(result, "Hot");
        }

        [TestMethod]
        public void WhenInputDivisibleBy5ReturnHotter()
        {
            var target = getTarget();
            var userInput = 5;

            var result = target.compute(userInput);

            Assert.AreEqual(result, "Hotter");
        }

        [TestMethod]
        public void WhenInputNotDivisibleBy35ReturnNumber()
        {
            var target = getTarget();
            var userInput = 7;

            var result = (int)target.compute(userInput);

            Assert.AreEqual(result, userInput);
        }

        public GameMathEngine getTarget()
        {
            return new GameMathEngine();
        }
    }
}
