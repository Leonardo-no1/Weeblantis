    using System;
using System.Collections.Generic;
using System.Text;
using Weeblantis.Core.Models.Product;

namespace Weeblantis.Core.Models.Order
{
    public class OrderItemModel:BaseEntity
    {
        public int OrderDetailId { get; set; }
        public OrderDetailModel OrderDetail { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}
