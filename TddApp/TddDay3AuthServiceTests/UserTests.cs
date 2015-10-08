using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddDay3AuthService;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TddDay3AuthServiceTests
{
    [TestClass]
    public class UserTests
    {
        User userTarget;
        [TestInitialize]
        public void getTarget()
        {
            userTarget = new User();
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void TestIfUserNameShouldBeGreaterThan8()
        {
            var user = new User();
            
            user.UserName = "bob";
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void TestIfUserAcceptsUserNameShouldBeLessThan10()
        {
            var user = new User();

            user.UserName = "bobisnameshouldbegreaterthan10";
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void TestIfPasswordShouldBeGreaterThan4()
        {
            var user = new User();

            user.Password = "bob";
        }

        [TestMethod]
        [ExpectedException(typeof(UserException))]
        public void TestIfPasswordShouldBeLessThan6()
        {
            var user = new User();

            user.Password = "bobisnameshouldbegreaterthan10";
        }
    }
}
