﻿using System;
using System.Collections.Generic;

namespace ShopNow.Models
{
    public partial class BillDetail
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? BillId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
