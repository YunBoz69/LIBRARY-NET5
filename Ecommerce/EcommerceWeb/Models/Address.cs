using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public User User { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Your first address")]
        public string FirstAddress { get; set; }

        [DisplayName("Your city")]
        public string City { get; set; }

        [DisplayName("Your postal code")]
        public string PostalCode { get; set; }

        public bool IsBill { get; set; }

        public bool IsDelivery { get; set; }


    }
}
