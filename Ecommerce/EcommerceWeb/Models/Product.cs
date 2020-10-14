using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [DisplayName("Product name")]
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }

        public int Stock { get; set; }
    }
}
