using System;
using System.Collections.Generic;

namespace ShopNow.DAL.Models
{
    public partial class BillDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid BillId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Bill Bill { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
