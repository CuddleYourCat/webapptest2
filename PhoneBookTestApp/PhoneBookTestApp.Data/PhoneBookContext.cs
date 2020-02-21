using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneBookTestApp.Data.Entities;

namespace PhoneBookTestApp.Data
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source = PhoneBook.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().HasData(
                new
                {
                    PersonId = 1,
                    FirstName = "Chris",
                    LastName = "Johnson",
                    PhoneNumber = "(321) 231-7876",
                    HouseNumber = 452,
                    StreetName = "Freeman Drive",
                    Suburb = "Algonac",
                    State = "MI"
                },
                new
                {
                    PersonId = 2,
                    FirstName = "Dave",
                    LastName = "Williams",
                    PhoneNumber = "(231) 502-1236",
                    HouseNumber = 285,
                    StreetName = "Huron Street",
                    Suburb = "Port Austin",
                    State = "MI"
                });

        }
    }
}
