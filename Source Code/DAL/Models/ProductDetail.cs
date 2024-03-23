using System;
using System.Collections.Generic;

namespace ShopNow.Source.DAL.Models
{
    public partial class ProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Code { get; set; } = null!;
        public int Ram { get; set; }
        public double Display { get; set; }
        public string Chip { get; set; } = null!;
        public string? Camera { get; set; }
        public string? Memory { get; set; }
        public double Pin { get; set; }
        public string Color { get; set; } = null!;
        public string UrlImage { get; set; } = null!;
        public string? OperatingSystem { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
