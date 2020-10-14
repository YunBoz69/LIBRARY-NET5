using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Boolean IsAdmin { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ICollection<Address> ListAddresses { get; set; }
    }
}
