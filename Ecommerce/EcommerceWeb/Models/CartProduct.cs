using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class CartProduct
    {
        public int CartProductId { get; set; }

        public virtual Cart cart { get; set; }

        public virtual Product product { get; set; }

        public int Quantity { get; set; }

    }
}
