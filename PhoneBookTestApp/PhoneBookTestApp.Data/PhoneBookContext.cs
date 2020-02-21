using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneBookTestApp.Data.Entities;

namespace PhoneBookTestApp.Data
{
    public class PhoneBookContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source ={Directory.GetCurrentDirectory()}/MyDatabase.db;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().HasData(
                new
                {
                    PersonId = 1,
                    FirstName = "Chris",
                    LastName = "Johnson",
                    PhoneNumber = "(321) 231-7876",
                    StreetAddress = "452 Freeman Drive",
                    Suburb = "Algonac",
                    State = "MI"
                },
                new
                {
                    PersonId = 2,
                    FirstName = "Dave",
                    LastName = "Williams",
                    PhoneNumber = "(231) 502-1236",
                    StreetAddress = "285 Huron Street",
                    Suburb = "Port Austin",
                    State = "MI"
                });

        }
    }
}
