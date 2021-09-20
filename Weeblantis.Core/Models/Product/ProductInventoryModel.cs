using System;
using System.Collections.Generic;
using System.Text;

namespace Weeblantis.Core.Models.Product
{
    public class ProductInventoryModel : BaseEntity
    {
        public int Quantity { get; set; }
        public ProductModel Product { get; set; }

    }
}
