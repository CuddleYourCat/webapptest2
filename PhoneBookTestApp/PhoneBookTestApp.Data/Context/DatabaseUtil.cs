using System;
using Microsoft.EntityFrameworkCore;
using PhoneBookTestApp.Data;

namespace PhoneBookTestApp
{
    public class DatabaseUtil
    {
        public static void initializeDatabase(PhoneBookContext context)
        {
            context.Database.Migrate();
        }

        public static void CleanUp(PhoneBookContext context)
        {
            foreach (var person in context.Persons)
            {
                context.Persons.Remove(person);
            }

            context.SaveChanges();
            context.Database.ExecuteSqlCommandAsync("EXEC sp_MSforeachtable 'DROP TABLE PERSONS");
        }
    }
}