using System;
using Weeblantis.Core.Models.Product;

namespace Weeblantis.Core.Models.Cart
{
    public class CartItemModel : BaseEntity
    {
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int ShoppingSessionId { get; set; }
        public ShoppingSessionModel ShoppingSession { get; set; }
    }
}
