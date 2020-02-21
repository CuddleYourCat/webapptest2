using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PhoneBookTestApp.Data.Entities;

namespace PhoneBookTestApp.Service
{
    public interface IPersonService
    {
        void AddPerson(Person person);
        IEnumerable<Person> FindAll();
        Person GetPerson(int id);
        IEnumerable<Person> Find(Expression<Func<Person, bool>> searchCriteria);
    }
}