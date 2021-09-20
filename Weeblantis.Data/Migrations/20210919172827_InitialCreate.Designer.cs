﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weeblantis.Data;

namespace Weeblantis.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210919172827_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Weeblantis.Core.Models.Cart.CartItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingSessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("ShoppingSessionId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Cart.ShoppingSessionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ShoppingSessions");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Order.OrderDetailModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentDetailId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaymentDetailId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Order.OrderItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderDetailId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Payment.PaymentDetailModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.DiscountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductInventoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductInventories");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInventoryId")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductInventoryId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.User.UserAddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.User.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.User.UserPaymentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountNo")
                        .HasColumnType("int");

                    b.Property<string>("Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserPayments");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Cart.CartItemModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.Product.ProductModel", "Product")
                        .WithOne("CartItem")
                        .HasForeignKey("Weeblantis.Core.Models.Cart.CartItemModel", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weeblantis.Core.Models.Cart.ShoppingSessionModel", "ShoppingSession")
                        .WithMany("CartItems")
                        .HasForeignKey("ShoppingSessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingSession");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Cart.ShoppingSessionModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.User.UserModel", "User")
                        .WithOne("ShoppingSession")
                        .HasForeignKey("Weeblantis.Core.Models.Cart.ShoppingSessionModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Order.OrderDetailModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.Payment.PaymentDetailModel", "PaymentDetail")
                        .WithOne("OrderDetail")
                        .HasForeignKey("Weeblantis.Core.Models.Order.OrderDetailModel", "PaymentDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weeblantis.Core.Models.User.UserModel", "User")
                        .WithOne("OrderDetail")
                        .HasForeignKey("Weeblantis.Core.Models.Order.OrderDetailModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Order.OrderItemModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.Order.OrderDetailModel", "OrderDetail")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weeblantis.Core.Models.Product.ProductModel", "Product")
                        .WithOne("OrderItem")
                        .HasForeignKey("Weeblantis.Core.Models.Order.OrderItemModel", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDetail");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.Product.DiscountModel", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weeblantis.Core.Models.Product.ProductCategoryModel", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weeblantis.Core.Models.Product.ProductInventoryModel", "ProductInventory")
                        .WithOne("Product")
                        .HasForeignKey("Weeblantis.Core.Models.Product.ProductModel", "ProductInventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("ProductCategory");

                    b.Navigation("ProductInventory");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.User.UserAddressModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.User.UserModel", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.User.UserPaymentModel", b =>
                {
                    b.HasOne("Weeblantis.Core.Models.User.UserModel", "User")
                        .WithMany("UserPayments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Cart.ShoppingSessionModel", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Order.OrderDetailModel", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Payment.PaymentDetailModel", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.DiscountModel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductCategoryModel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductInventoryModel", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.Product.ProductModel", b =>
                {
                    b.Navigation("CartItem");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("Weeblantis.Core.Models.User.UserModel", b =>
                {
                    b.Navigation("OrderDetail");

                    b.Navigation("ShoppingSession");

                    b.Navigation("UserAddresses");

                    b.Navigation("UserPayments");
                });
#pragma warning restore 612, 618
        }
    }
}
