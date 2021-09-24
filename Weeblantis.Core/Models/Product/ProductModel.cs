using Weeblantis.Core.Models.Cart;
using Weeblantis.Core.Models.Order;

namespace Weeblantis.Core.Models.Product
{
    public class ProductModel : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public int ProductInventory { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategoryModel ProductCategory { get; set; }
        public int? DiscountId { get; set; }
        public DiscountModel Discount { get; set; }
        public string ImageBase64 { get; set; }
        public CartItemModel CartItem { get; set; }
        public OrderItemModel OrderItem { get; set; }
    }
}
