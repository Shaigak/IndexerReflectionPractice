using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    internal class AccountService : IAccountService
    {
        public string Register(string username, string email, string password)
        {

            try
            {
                var result = GetAllEmails();
                if (result.Contains(email))
                {
                    throw new RegisterExceptions(ResponseMessages.InvalidRegisterMessage);
                }
                return "Register Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
        private List<string> GetAllEmails()
        {
            return new List<string>() { "pervin12@Mail.ru", "ali@mail.ru", "aqsin@Mail.ru" };
        }
    }
}
