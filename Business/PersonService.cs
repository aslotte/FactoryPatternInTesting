using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class PersonService
    {
        public void UpdateId(Person person, int id)
        {
            person.Id = id;
        }

        public void UpdateFirstName(Person person, string firstName)
        {
            person.FirstName = firstName;
        }

        public void SavePerson(Person person)
        {
            if (person.Id < 0) throw new ArgumentException("Id is not valid");

            //repository.SavePerson(person);
        }
    }
}
