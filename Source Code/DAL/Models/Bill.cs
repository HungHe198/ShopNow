using System;
using System.Collections.Generic;

namespace ShopNow.DAL.Models
{
    public partial class Bill
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public byte Status { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
