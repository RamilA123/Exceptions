using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Exceptions.NotFoundException
{
    public class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {

        }
    }
}
