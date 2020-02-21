using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PhoneBookTestApp.Data;
using PhoneBookTestApp.Data.Entities;

namespace PhoneBookTestApp.Service
{
    public class PhoneBook : IPersonService
    {

        private PhoneBookContext _context;

        public PhoneBook(PhoneBookContext context) => _context = context;

        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        public IEnumerable<Person> FindAll()
        {
            return Find(noFilters => true);
        }

        public Person GetPerson(int id)
        {
            return _context.Persons.SingleOrDefault(x => x.PersonId == id);
        }

        public IEnumerable<Person> Find(Expression<Func<Person, bool>> searchCriteria)
        {
            return _context.Persons.Where(searchCriteria).ToList();
        }
    }
}
