using System;
using System.Collections.Generic;
using System.Text;

namespace Weeblantis.Core.Models.Product
{
    public class DiscountModel:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double DiscountPercentage { get; set; }
        public bool Active { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
