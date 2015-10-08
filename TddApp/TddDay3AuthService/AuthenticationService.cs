using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddDay3AuthService
{
    public class AuthenticationService
    {

        public IUser User { get; set; }
        public IAuthServiceRepository authServiceRepository { get; set; }

        public bool createUser()
        {
            return authServiceRepository.createUser(User);
        }
    }
}
