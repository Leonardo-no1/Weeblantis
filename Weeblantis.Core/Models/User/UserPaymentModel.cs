using System;

namespace Weeblantis.Core.Models.User
{
    public class UserPaymentModel : BaseEntity
    {
        public string PaymentType { get; set; }
        public string Bank { get; set; }
        public int AccountNo { get; set; }
        public DateTime Expiry { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }

    }

}
