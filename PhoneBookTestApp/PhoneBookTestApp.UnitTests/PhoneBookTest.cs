using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBookTestApp.Data;
using Moq;
using PhoneBookTestApp.Data.Entities;
using PhoneBookTestApp.Service;


namespace PhoneBookTestAppTests
{
    // ReSharper disable InconsistentNaming

    [TestClass()]
    public class PhoneBookTest
    {
        private Mock<PhoneBookContext> _context;
        
        [TestInitialize]
        public void SetupContext()
        {
            var persons = new List<Person>()
            {
                new Person("John", "Doe", "(123) 123-4567"),
                new Person("Jane", "Dowe", "(311) 123-4567"),

            }.AsQueryable();

            var phoneBookMock = new Mock<DbSet<Person>>();
            phoneBookMock.As<IQueryable<Person>>().Setup(p => p.Provider).Returns(persons.Provider);
            phoneBookMock.As<IQueryable<Person>>().Setup(p => p.Expression).Returns(persons.Expression);
            phoneBookMock.As<IQueryable<Person>>().Setup(p => p.ElementType).Returns(persons.ElementType);
            phoneBookMock.As<IQueryable<Person>>().Setup(p => p.GetEnumerator()).Returns(persons.GetEnumerator());

            this._context = new Mock<PhoneBookContext>();
            _context.Setup(x => x.Persons).Returns(phoneBookMock.Object);
        }

        [TestCleanup]
        public void TearDownContext()
        {
            this._context = new Mock<PhoneBookContext>();
        }

    [TestMethod]
        public void addPerson()
        {
            var service = new PhoneBook(_context.Object);
            var person = new Person("Mickey", "Mouse");

            _context.Setup(mock => mock.SaveChanges()).Returns(1);
            _context.Setup(mock => mock.Persons.Add(person));

            service.AddPerson(person);

            _context.Verify(mock => mock.Persons.Add(person));
            _context.Verify(mock => mock.SaveChanges());
        }

        [TestMethod]
        public void findPerson_ReturnsInstanceOfPerson()
        {
            var service = new PhoneBook(_context.Object);
            var found = service.Find(p => p.LastName == "Doe");
            Assert.IsInstanceOfType(found, typeof(List<Person>), $"Expected instance of type List<Person>, but got instance of type {found.GetType()}");
        }

        [TestMethod]
        public void findPerson_ReturnsListOfOnePerson()
        {
            var service = new PhoneBook(_context.Object);
            var found = service.Find(p => p.LastName == "Doe").Count();
            Assert.IsTrue(found == 1, $"Expected single instance of Person>, but got {found}");
        }

        [TestMethod]
        public void findPerson_ReturnsCorrectPerson()
        {
            var service = new PhoneBook(_context.Object);
            var found = service.Find(p => p.LastName == "Doe");
            Assert.AreEqual("John", found.SingleOrDefault().FirstName, $"Expected John Doe to be returned but got {found.SingleOrDefault().FirstName}");
        }
    }

    // ReSharper restore InconsistentNaming 
}