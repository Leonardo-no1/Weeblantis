using System.Collections.Generic;
using Weeblantis.Core.Models.User;

namespace Weeblantis.Core.Models.Order
{
    public class OrderDetailModel : BaseEntity
    {
        public double Total { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public List<OrderItemModel> OrderItems { get; set; }
    }
}
