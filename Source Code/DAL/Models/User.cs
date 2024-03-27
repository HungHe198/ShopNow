﻿using System;
using System.Collections.Generic;

namespace ShopNow.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
        }

        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public byte? Status { get; set; }
        public Guid? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
