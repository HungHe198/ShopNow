using System;
using System.Collections.Generic;

namespace ShopNow.Models
{
    public partial class CartProduct
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public double? Quantity { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }

        public virtual Cart Cart { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
