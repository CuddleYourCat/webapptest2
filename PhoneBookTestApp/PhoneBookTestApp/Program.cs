using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookTestApp.Data;
using PhoneBookTestApp.Data.Entities;
using PhoneBookTestApp.Service;

namespace PhoneBookTestApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var context = new PhoneBookContext();
            try
            {
                DatabaseUtil.initializeDatabase(context);
                /* TODO: create person objects and put them in the PhoneBook and database
                * John Smith, (248) 123-4567, 1234 Sand Hill Dr, Royal Oak, MI
                * Cynthia Smith, (824) 128-8758, 875 Main St, Ann Arbor, MI
                */
                var John = new Person("John", "Smith", "(248) 123 - 4567", "1234 Sand Hill Dr", "Royal Oak", "MI");
                var Cynthia = new Person("Cynthia", "Smith", "(824) 128 - 8758", "875 Main St", "Ann Arbor", "MI");

                var phoneBook = new PhoneBook(context);
                phoneBook.AddPerson(John);
                phoneBook.AddPerson(Cynthia);

                // TODO: print the phone book out to System.out
                new PhoneBookPrinter().Print(phoneBook);

                // TODO: find Cynthia Smith and print out just her entry
                var cynthiaRecord = phoneBook.Find(m => m.FirstName == "Cynthia" && m.LastName == "Smith")
                    .FirstOrDefault();
                Console.WriteLine();
                Console.WriteLine(cynthiaRecord?.ToString());

                // TODO: insert the new person objects into the database
                Console.ReadLine();
                DatabaseUtil.CleanUp(context);
            }
            finally
            {
                DatabaseUtil.CleanUp(context);
            }
        }
    }
}
