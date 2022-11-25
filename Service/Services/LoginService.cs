using Domain.Models;
using Service.Exceptions.NotFoundException;
using Service.Service.Interfaces;


namespace Service.Service
{
    public class LoginService : ILoginService
    {
        public string Login(string email, string password)
        {
            Login user = new Login
            {
                Email = email,
                Password = password
            };

            if (user.Email.Contains("@"))
            {
                return "Access is successful.";
            }
            else
            {
                throw new LoginException("Email doesn't have @ sign."); 
            }
        }
    }
}
