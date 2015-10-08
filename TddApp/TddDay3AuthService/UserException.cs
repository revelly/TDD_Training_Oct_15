using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddDay3AuthService
{
    public class UserException : Exception
    {
        public UserException(string message)
        : base(message) { }

    }
}
