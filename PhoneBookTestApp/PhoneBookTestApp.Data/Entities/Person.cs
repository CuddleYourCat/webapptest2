
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PhoneBookTestApp.Data.Entities
{
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public int HouseNumber { get; set; }
        public string StreetName { get; set; }

        public string Suburb { get; set; }

        public string State { get; set; }

    }

}