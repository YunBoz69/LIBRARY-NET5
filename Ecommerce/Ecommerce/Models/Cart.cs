using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        public ICollection<CartProduct> ListCartProducts { get; set; }

        // Json field pour garder les info facture
        // Foreign key pas bon dans ce si les valeurs changent (ex : adresse, etc.)
        public string OrderInfo { get; set; }
    }
}
