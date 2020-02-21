
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PhoneBookTestApp.Data.Entities
{
    public class Person 
    {
        public Person(string firstName, string lastName, string phoneNumber = "", string streetAddress = "", string suburb = "", string state = "")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.StreetAddress = streetAddress;
            this.Suburb = suburb;
            this.State = state;
        }
        
        public int PersonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string StreetAddress { get; set; }

        public string Suburb { get; set; }
        [MaxLength(2, ErrorMessage = "Please provide at most 2 characters.")]
        public string State { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {StreetAddress}, {Suburb}, {StreetAddress}";
        }
    }

}