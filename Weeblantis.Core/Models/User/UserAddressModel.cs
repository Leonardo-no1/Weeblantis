using System;

namespace Weeblantis.Core.Models.User
{
    public class UserAddressModel : BaseEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }

    }

}
