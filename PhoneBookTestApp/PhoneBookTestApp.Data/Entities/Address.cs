using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PhoneBookTestApp.Data.Entities
{
    public class Address
    {
        public int AddressId { get; set; }

        public int HouseNumber { get; set; }
        public string StreetName { get; set; }

        public string Suburb { get; set; }

        public string State { get; set; }

        public Person Resident { get; set; }
    }
}