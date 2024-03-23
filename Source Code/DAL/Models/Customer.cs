using System;
using System.Collections.Generic;

namespace ShopNow.DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bills = new HashSet<Bill>();
        }

        public Guid Id { get; set; }
        public Guid CustomerTypeId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        public string Address { get; set; } = null!;
        public int? Point { get; set; }

        public virtual CustomerType CustomerType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
