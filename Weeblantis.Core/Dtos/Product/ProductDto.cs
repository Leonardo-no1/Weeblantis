using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models;

namespace Weeblantis.Core.Dtos.Product
{
    public class ProductDto:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public int ProductInventory { get; set; }
        public int ProductCategoryId { get; set; }
        public int? DiscountId { get; set; }
        public string ImageBase64 { get; set; }
    }
}
