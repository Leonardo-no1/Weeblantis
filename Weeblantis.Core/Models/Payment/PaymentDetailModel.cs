using Weeblantis.Core.Models.Order;
using Weeblantis.Core.Models.User;

namespace Weeblantis.Core.Models.Payment
{
    public class PaymentDetailModel : BaseEntity
    {
        public int Amount { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public OrderDetailModel OrderDetail { get; set; }
    }
}
