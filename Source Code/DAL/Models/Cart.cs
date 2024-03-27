using System;
using System.Collections.Generic;

namespace ShopNow.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartProducts = new HashSet<CartProduct>();
        }

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}
