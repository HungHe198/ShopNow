using ShopNow.Source.DAL.Models;
using System;
using System.Collections.Generic;

namespace ShopNow.Models
{
    public partial class Product
    {
        public Product()
        {
            CartProducts = new HashSet<CartProduct>();
            ImportHistories = new HashSet<ImportHistory>();
            ProductDetails = new HashSet<ProductDetail>();
        }

        public Guid Id { get; set; }
        public string? ProductName { get; set; }
        public Guid? DiscountId { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public double? Warranty { get; set; }
        public double? Display { get; set; }
        public int? Ram { get; set; }
        public int? Rom { get; set; }
        public DateTime? CreatedTime { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public byte? Status { get; set; }

        public virtual Discount? Discount { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual ICollection<ImportHistory> ImportHistories { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
