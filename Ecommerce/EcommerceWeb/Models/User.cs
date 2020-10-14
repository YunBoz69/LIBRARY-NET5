using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class User
    {
        public int UserId { get; set; }

        [DisplayName("Your first name")]
        public string FirstName { get; set; }

        [DisplayName("Your last name")]
        public string LastName { get; set; }

        [DisplayName("Your birth date")]

        public Boolean IsAdmin { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<Address> ListAddresses { get; set; }

    }
}
