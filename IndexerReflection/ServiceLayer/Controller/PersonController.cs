using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Controller
{
    public class PersonController
    {
        private readonly IPerson _service;
        public PersonController()
        {
            _service = new PersonService();
        }

        public void GetPersonSalary()
        {
            var result = _service.GetAllPersons(m => m.Salary > 1000);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
