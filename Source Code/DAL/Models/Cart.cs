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
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
    }
}
