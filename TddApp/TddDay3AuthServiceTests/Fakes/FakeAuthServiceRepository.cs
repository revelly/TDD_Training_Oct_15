using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TddDay3AuthService;

namespace TddDay3AuthServiceTests.Fakes
{
    public class FakeAuthServiceRepository : IAuthServiceRepository
    {
        public bool createUser(IUser User)
        {
            return true;
        }
    }
}
