using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace TddDay3AuthService
{
    public class User : IUser
    {
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (value.Length > 8 && value.Length < 10)
                {
                    userName = value;
                }
                else throw new UserException("UserName length should be grear than 8 and less than 10");
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length > 8 && value.Length < 10)
                {
                    password = value;
                }
                else throw new UserException("Password should not be blank and length should be grear than 4 and less than 6");
            }
        }

        User addUserMethod()
        {
            throw new System.NotImplementedException();
        }

    }
}
