using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public User User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FirstAddress { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public bool IsBill { get; set; }

        public bool IsDelivery { get; set; }


    }
}
