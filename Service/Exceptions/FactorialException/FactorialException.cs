using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Exceptions.FactorialException1
{
    public class FactorialException : Exception
    {
        public FactorialException(string message) : base (message)
        {

        }
    }
}
