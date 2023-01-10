using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Controller
{
    public class AccountController
    {
        private readonly IAccountService _service;
            public AccountController()
        {
                _service = new AccountService();
        }

        public void Register()
        {
            Console.WriteLine("Add your username");
            string username=Console.ReadLine();

            Console.WriteLine("Add your Email");
            string email = Console.ReadLine();

            Console.WriteLine("Add your Password");
            string password = Console.ReadLine();

            var result = _service.Register(username,email,password);

            Console.WriteLine(result);
        }
    }
}
