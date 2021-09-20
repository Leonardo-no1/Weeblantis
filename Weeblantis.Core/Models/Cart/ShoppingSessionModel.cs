using System.Collections.Generic;
using Weeblantis.Core.Models.User;
namespace Weeblantis.Core.Models.Cart
{
    public class ShoppingSessionModel : BaseEntity
    {
        public double Total { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public List<CartItemModel> CartItems { get; set; }
    }
}
