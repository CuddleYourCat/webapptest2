using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookTestApp.Data.Entities;

namespace PhoneBookTestApp.Service
{
    public class PhoneBookPrinter : IPrinterService<PhoneBook>
    {
        public void Print(PhoneBook phoneBook)
        {
            phoneBook.FindAll().ToList().ForEach(x =>
                Console.WriteLine(x.ToString()));
        }
    }

    public interface IPrinterService<T>
    {
        void Print(T item);
    }
}
