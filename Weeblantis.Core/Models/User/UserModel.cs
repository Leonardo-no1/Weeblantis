using System.Collections.Generic;
using Weeblantis.Core.Models.Cart;
using Weeblantis.Core.Models.Order;

namespace Weeblantis.Core.Models.User
{
    public class UserModel : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public List<UserAddressModel> UserAddresses { get; set; }
        public List<UserPaymentModel> UserPayments { get; set; }
        public ShoppingSessionModel ShoppingSession { get; set; }
        public OrderDetailModel OrderDetail { get; set; }
    }

}
