using System;
using System.Collections.Generic;

namespace ShopNow.DAL.Models
{
    public partial class Facility
    {
        public Facility()
        {
            Employees = new HashSet<Employee>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public byte? Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
