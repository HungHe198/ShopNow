using System;
using System.Collections.Generic;

namespace ShopNow.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public Guid Id { get; set; }
        public Guid? FacilityId { get; set; }
        public Guid? UserId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public byte? Status { get; set; }

        public virtual Facility? Facility { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
