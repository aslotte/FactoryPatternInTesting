using Domain.Models;

namespace TestFramework.Factories
{
    public class PersonFactory : BaseFactory<Person>
    {
        public PersonFactory WithId(int id)
        {
            entity.Id = id;
            return this;
        }

        public PersonFactory WithFirstName(string firstName)
        {
            entity.FirstName = firstName;
            return this; 
        }
        public PersonFactory WithLastName(string lastName)
        {
            entity.LastName = lastName;
            return this;
        }

        public PersonFactory WithPhoneNumber(int phoneNumber)
        {
            entity.PhoneNumber = phoneNumber;
            return this;
        }

        public PersonFactory WithDefault()
        {
            entity.Id = 1;
            entity.FirstName = "John";
            entity.LastName = "Doe";
            entity.PhoneNumber = 2021234567;

            return this;
        }
    }
}
