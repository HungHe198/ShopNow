﻿using System;
using System.Collections.Generic;

namespace ShopNow.Source.DAL.Models
{
    public partial class CartProduct
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public double Quantity { get; set; }

        public virtual Cart Cart { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
