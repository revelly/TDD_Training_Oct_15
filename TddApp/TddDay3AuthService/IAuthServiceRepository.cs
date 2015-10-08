using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddDay3AuthService
{
    public interface IAuthServiceRepository
    {
        bool createUser(IUser User);
    }
}
