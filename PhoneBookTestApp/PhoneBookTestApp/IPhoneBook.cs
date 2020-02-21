using System.Collections.Generic;
using PhoneBookTestApp.Data;
using PhoneBookTestApp.Data.Entities;

namespace PhoneBookTestApp
{
    public interface IPhoneBook : IEnumerable<Person>
    {
        Person FindPerson(string firstName, string lastName);
        void AddPerson(Person newPerson);
    }
}