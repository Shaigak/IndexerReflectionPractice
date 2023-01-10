using DomainLayer.Models;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PersonService : IPerson
    {
        public List<Person> GetAllPersons(Predicate<Person> predicate)
        {
            var result = GetAllPersons().FindAll(predicate); 
            return result;
        }
        private List<Person> GetAllPersons()
        {
            List<Person> people = new List<Person>();
            Person persons1 = new Person()
            {
                Name = "Shaiq",
                Surname = "Kazimov",
                Address = "Sedmoy",
                Salary = 1000
            };
            Person persons2 = new Person()
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Address = "Neftciler",
                Salary = 1100
            };
            Person persons3 = new Person()
            {
                Name = "Nigar",
                Surname = "Kazimova",
                Address = "Sedmoy",
                Salary = 1150
            };
            Person persons4 = new Person()
            {
                Name = "Elekber",
                Surname = "Elekberli",
                Address = "Bayil",
                Salary = 1200
            };
            people.Add(persons1);
            people.Add(persons2);
            people.Add(persons3);
            people.Add(persons4);
            return people;

        }
    }
       
    
}
