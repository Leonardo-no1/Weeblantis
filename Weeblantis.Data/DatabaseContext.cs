using Microsoft.EntityFrameworkCore;
using Weeblantis.Core.Models.Cart;
using Weeblantis.Core.Models.Order;
using Weeblantis.Core.Models.Payment;
using Weeblantis.Core.Models.Product;
using Weeblantis.Core.Models.User;

namespace Weeblantis.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {
        }

        #region User
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserAddressModel> UserAddresses { get; set; }
        public DbSet<UserPaymentModel> UserPayments { get; set; }
        #endregion

        #region Product
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<ProductCategoryModel> ProductCategories { get; set; }
        public DbSet<ProductInventoryModel> ProductInventories { get; set; }
        public DbSet<DiscountModel> Discounts { get; set; }
        #endregion

        #region Payment
        public DbSet<PaymentDetailModel> PaymentDetails { get; set; }
        #endregion

        #region Order
        public DbSet<OrderDetailModel> OrderDetails { get; set; }
        public DbSet<OrderItemModel> OrderItems { get; set; }
        #endregion

        #region Cart
        public DbSet<CartItemModel> CartItems { get; set; }
        public DbSet<ShoppingSessionModel> ShoppingSessions { get; set; }
        #endregion

    }
}
