using Service.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Controllers
{
    public class LoginController
    {
       public static void GetLogin()
        {
            try
            {
                Console.WriteLine("Enter an email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter a password: ");
                string password = Console.ReadLine();
                LoginService loginservice = new LoginService();
                var result = loginservice.Login(email, password);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
