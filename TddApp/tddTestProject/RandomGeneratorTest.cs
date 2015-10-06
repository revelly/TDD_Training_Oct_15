using Problem_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tddTestProject
{
    
    
    /// <summary>
    ///This is a test class for RandomGeneratorTest and is intended
    ///to contain all RandomGeneratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RandomGeneratorTest
    {
        [TestMethod]
        public void TestIfStartPointExists()
        {
            var target = getTarget();

            Assert.AreEqual(1, target.StartPoint);
        }

        [TestMethod]
        public void TestIfEndPointExists()
        {
            var target = getTarget();

            Assert.AreEqual(100, target.EndPoint);
        }

        [TestMethod]
        public void TestVerifyNumberWithinStartAndEndPoint()
        {
            var target = getTarget();
            int randomNumber = target.getRandomNumber();

            var result= (randomNumber > target.StartPoint ? (randomNumber < target.EndPoint ? true : false) : false);
            Assert.AreEqual(result, true);
        }

        public RandomGenerator getTarget()
        {
            return new RandomGenerator();
        }
    }
}
