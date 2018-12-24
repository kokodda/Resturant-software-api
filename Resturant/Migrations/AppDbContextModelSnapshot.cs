﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Resturant.Models;

namespace Resturant.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Resturant.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<string>("Claim");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Details");

                    b.Property<int>("UserId");

                    b.HasKey("ActivityId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("Resturant.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("EmployeeId");

                    b.Property<bool>("IsLoggedIn");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<DateTime>("LogOut");

                    b.Property<DateTime>("Login");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "807ba6c0-e845-4695-847e-92edca9d66db", AccessFailedCount = 0, ConcurrencyStamp = "99e3bd79-ec09-41c6-a94b-b9b0881e7b6f", Email = "harmonizerblinks@gmail.com", EmailConfirmed = true, IsLoggedIn = false, LockoutEnabled = false, LogOut = new DateTime(2018, 12, 24, 4, 35, 34, 845, DateTimeKind.Utc), Login = new DateTime(2018, 12, 24, 4, 35, 34, 845, DateTimeKind.Utc), MDate = new DateTime(2018, 12, 24, 4, 35, 34, 845, DateTimeKind.Utc), MUserId = "807ba6c0-e845-4695-847e-92edca9d66db", PasswordHash = "AQAAAAEAACcQAAAAEOrzhtqT+9ZuBKNmqNY/4xVf8ruHsdTHMfE8KCVsipUBA9CjcZMVjYRaR0Nzl8jgKQ==", PhoneNumber = "0238288675", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "Harmony", UserType = "Admin" },
                        new { Id = "807ba6c0-e845-4695-847e-92edca9d66dc", AccessFailedCount = 0, ConcurrencyStamp = "f470e9f0-9aee-4ec0-a391-7ff11b012dc4", Email = "info@acyst.tech", EmailConfirmed = true, IsLoggedIn = false, LockoutEnabled = false, LogOut = new DateTime(2018, 12, 24, 4, 35, 34, 845, DateTimeKind.Utc), Login = new DateTime(2018, 12, 24, 4, 35, 34, 845, DateTimeKind.Utc), MDate = new DateTime(2018, 12, 24, 4, 35, 34, 845, DateTimeKind.Utc), MUserId = "807ba6c0-e845-4695-847e-92edca9d66db", PasswordHash = "AQAAAAEAACcQAAAAEOrzhtqT+9ZuBKNmqNY/4xVf8ruHsdTHMfE8KCVsipUBA9CjcZMVjYRaR0Nzl8jgKQ==", PhoneNumber = "0238288675", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "Acyst", UserType = "Admin" }
                    );
                });

            modelBuilder.Entity("Resturant.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Postal")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Resturant.Models.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("LocationId");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Percent");

                    b.Property<string>("UserId");

                    b.HasKey("DiscountId");

                    b.HasIndex("LocationId");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Resturant.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Code");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("Nationality")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Resturant.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Discount");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<string>("UserId");

                    b.HasKey("FoodId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Resturant.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<decimal>("SalePrice");

                    b.Property<string>("UserId");

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Resturant.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("Discount");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Resturant.Models.Nominal", b =>
                {
                    b.Property<int>("NominalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BalanceType")
                        .IsRequired();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("GLType")
                        .IsRequired();

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("NominalId");

                    b.ToTable("Nominal");
                });

            modelBuilder.Entity("Resturant.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email");

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<int>("LocationId");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Method")
                        .IsRequired();

                    b.Property<string>("Mobile")
                        .IsRequired();

                    b.Property<string>("OrderNo");

                    b.Property<decimal>("Price");

                    b.Property<string>("Source");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<decimal>("Total");

                    b.Property<int>("TransactionId");

                    b.Property<string>("UserId");

                    b.Property<decimal>("Vat");

                    b.HasKey("OrderId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Resturant.Models.OrderList", b =>
                {
                    b.Property<int>("OrderListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<int>("FoodId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderListId");

                    b.HasIndex("FoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderList");
                });

            modelBuilder.Entity("Resturant.Models.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("ItemId");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("Reference");

                    b.Property<string>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("SalesId");

                    b.HasIndex("ItemId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Resturant.Models.Sequence", b =>
                {
                    b.Property<int>("SequenceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Counter");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Length");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Prefix")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("SequenceId");

                    b.ToTable("Sequence");
                });

            modelBuilder.Entity("Resturant.Models.Sms", b =>
                {
                    b.Property<int>("SmsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Message");

                    b.Property<string>("Mobile");

                    b.Property<int?>("OrderId");

                    b.Property<string>("Response");

                    b.Property<string>("UserId");

                    b.HasKey("SmsId");

                    b.ToTable("Sms");
                });

            modelBuilder.Entity("Resturant.Models.SmsApi", b =>
                {
                    b.Property<int>("SmsApiId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Default");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("SenderId")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("SmsApiId");

                    b.ToTable("SmsApi");
                });

            modelBuilder.Entity("Resturant.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("ItemId");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<int>("Quantity");

                    b.Property<string>("UserId");

                    b.HasKey("StockId");

                    b.HasIndex("ItemId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Resturant.Models.StockLog", b =>
                {
                    b.Property<int>("StockLogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("ItemId");

                    b.Property<int>("Quantity");

                    b.Property<int>("StockId");

                    b.Property<string>("UserId");

                    b.HasKey("StockLogId");

                    b.HasIndex("ItemId");

                    b.HasIndex("StockId");

                    b.ToTable("StockLog");
                });

            modelBuilder.Entity("Resturant.Models.Teller", b =>
                {
                    b.Property<int>("TellerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Id")
                        .IsRequired();

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<int>("NominalId");

                    b.Property<string>("UserId");

                    b.HasKey("TellerId");

                    b.HasIndex("Id");

                    b.HasIndex("NominalId");

                    b.ToTable("Teller");
                });

            modelBuilder.Entity("Resturant.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Method")
                        .IsRequired();

                    b.Property<int>("NominalId");

                    b.Property<string>("Reference")
                        .IsRequired();

                    b.Property<string>("Source")
                        .IsRequired();

                    b.Property<int?>("TellerId");

                    b.Property<string>("TransCode");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("TransactionId");

                    b.HasIndex("NominalId");

                    b.HasIndex("TellerId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Resturant.Models.Transit", b =>
                {
                    b.Property<int>("TransitId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime?>("MDate");

                    b.Property<string>("MUserId");

                    b.Property<string>("Method")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NominalId");

                    b.Property<string>("UserId");

                    b.HasKey("TransitId");

                    b.HasIndex("NominalId");

                    b.ToTable("Transit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Resturant.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Resturant.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Resturant.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Resturant.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.AppUser", b =>
                {
                    b.HasOne("Resturant.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Resturant.Models.Discount", b =>
                {
                    b.HasOne("Resturant.Models.Location", "Location")
                        .WithMany("Discounts")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.Order", b =>
                {
                    b.HasOne("Resturant.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Resturant.Models.Transaction", "Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.OrderList", b =>
                {
                    b.HasOne("Resturant.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Resturant.Models.Order", "Order")
                        .WithMany("Orderlist")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.Sales", b =>
                {
                    b.HasOne("Resturant.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.Stock", b =>
                {
                    b.HasOne("Resturant.Models.Item", "Item")
                        .WithMany("Stock")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.StockLog", b =>
                {
                    b.HasOne("Resturant.Models.Item", "Item")
                        .WithMany("Logs")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Resturant.Models.Stock", "Stock")
                        .WithMany("Logs")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.Teller", b =>
                {
                    b.HasOne("Resturant.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Resturant.Models.Nominal", "Nominal")
                        .WithMany()
                        .HasForeignKey("NominalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Resturant.Models.Transaction", b =>
                {
                    b.HasOne("Resturant.Models.Nominal", "Nominal")
                        .WithMany("Transactions")
                        .HasForeignKey("NominalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Resturant.Models.Teller", "Teller")
                        .WithMany("Transactions")
                        .HasForeignKey("TellerId");
                });

            modelBuilder.Entity("Resturant.Models.Transit", b =>
                {
                    b.HasOne("Resturant.Models.Nominal", "Nominal")
                        .WithMany()
                        .HasForeignKey("NominalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
