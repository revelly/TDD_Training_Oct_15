using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddDay3AuthService;

namespace TddDay3AuthServiceTests
{
    [TestClass]
    public class AuthenticationServiceTests
    {
        AuthenticationService authServiceTarget;

        [TestInitialize]
        public void getTarget()
        {
            authServiceTarget = new AuthenticationService();
        }

        [TestMethod]
        public void TestWhetherServiceCanCreateUser()
        {
            IUser user = new User();
            user.UserName = "ravi reve";
            user.Password = "ravirevel";

            authServiceTarget.User = user;

            //fake repo
            IAuthServiceRepository fakeRepo = new Fakes.FakeAuthServiceRepository();
            authServiceTarget.authServiceRepository = fakeRepo;

            bool result = authServiceTarget.createUser();

            Assert.IsTrue(result);
        }
    }
}
