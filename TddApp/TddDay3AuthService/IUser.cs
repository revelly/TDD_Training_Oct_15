using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddDay3AuthService
{
    public interface IUser
    {
        string Password { get; set; }
        string UserName { get; set; }
    }
}
