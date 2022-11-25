using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service.Interfaces
{
    public interface ILoginService
    {
        public string Login(string email, string password);
    }
}
