﻿// <auto-generated />
using System;
using JZenoApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JZenoApp.Migrations
{
    [DbContext(typeof(JZenoDbContext))]
    [Migration("20230923135713_Db")]
    partial class Db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JZenoApp.Models.Bill", b =>
                {
                    b.Property<string>("billID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("deliveryForm")
                        .HasColumnType("bit");

                    b.Property<bool?>("payment")
                        .HasColumnType("bit");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("voucherID")
                        .HasColumnType("int");

                    b.HasKey("billID");

                    b.HasIndex("UserId");

                    b.HasIndex("voucherID");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("JZenoApp.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = "shirt",
                            Icon = "shirt.png",
                            Name = "Shirt"
                        },
                        new
                        {
                            Id = "sandal",
                            Icon = "sandal.png",
                            Name = "Sandal"
                        },
                        new
                        {
                            Id = "shoes",
                            Icon = "shoes.png",
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = "short",
                            Icon = "shorts.png",
                            Name = "Short"
                        },
                        new
                        {
                            Id = "trouser",
                            Icon = "trousers.png",
                            Name = "Trouser"
                        });
                });

            modelBuilder.Entity("JZenoApp.Models.DetailOrder", b =>
                {
                    b.Property<int?>("odID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("odID"));

                    b.Property<string>("billID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("price")
                        .HasColumnType("float");

                    b.Property<string>("productID")
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.Property<double?>("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("odID");

                    b.HasIndex("billID");

                    b.HasIndex("productID");

                    b.ToTable("DetailOD");
                });

            modelBuilder.Entity("JZenoApp.Models.Partner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Partner");
                });

            modelBuilder.Entity("JZenoApp.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("categoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("discount")
                        .HasColumnType("int");

                    b.Property<bool?>("isPublish")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("partnerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("postDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("categoryID");

                    b.HasIndex("partnerID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductColor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.ToTable("ProductColor");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductImage", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("productId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductSize", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("colorId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("productColorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("productColorId");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("JZenoApp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                            AccessFailedCount = 0,
                            Address = "Tắc Vân - Cà Mau",
                            ConcurrencyStamp = "37ead080-501b-42c0-b72a-68e965900b8e",
                            DateCreated = new DateTime(2023, 9, 23, 20, 57, 12, 926, DateTimeKind.Local).AddTicks(4929),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Trần Viễn Đại",
                            Image = "default_avt.png",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEMgAXVATUKFUfdxm8gAEclCmezDEKs6WgY3IFGzC+g068mWi1v7RHKaS/NonBdYbxw==",
                            PhoneNumber = "0582072743",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c4ddd286-af86-4ba7-a252-123762c4a4cf",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("JZenoApp.Models.Voucher", b =>
                {
                    b.Property<int?>("voucherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("voucherID"));

                    b.Property<string>("name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal?>("price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("voucherID");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "07bf1560-b5ff-4702-a9f1-a64026e570cf",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "2ccdcef3-db18-46c7-b5ff-910be6ae4906",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "5h45cxf3-mx18-4acb-h6d1-420b466e4502",
                            Name = "Partner",
                            NormalizedName = "Partner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                            RoleId = "07bf1560-b5ff-4702-a9f1-a64026e570cf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("JZenoApp.Models.Bill", b =>
                {
                    b.HasOne("JZenoApp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("JZenoApp.Models.Voucher", "Voucher")
                        .WithMany("Bills")
                        .HasForeignKey("voucherID");

                    b.Navigation("User");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("JZenoApp.Models.DetailOrder", b =>
                {
                    b.HasOne("JZenoApp.Models.Bill", null)
                        .WithMany("detailsOrders")
                        .HasForeignKey("billID");

                    b.HasOne("JZenoApp.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID");

                    b.Navigation("product");
                });

            modelBuilder.Entity("JZenoApp.Models.Product", b =>
                {
                    b.HasOne("JZenoApp.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JZenoApp.Models.Partner", "Partner")
                        .WithMany("products")
                        .HasForeignKey("partnerID");

                    b.Navigation("Category");

                    b.Navigation("Partner");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductColor", b =>
                {
                    b.HasOne("JZenoApp.Models.Product", "product")
                        .WithMany("productColor")
                        .HasForeignKey("productId");

                    b.Navigation("product");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductImage", b =>
                {
                    b.HasOne("JZenoApp.Models.Product", "Product")
                        .WithMany("productImages")
                        .HasForeignKey("productId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductSize", b =>
                {
                    b.HasOne("JZenoApp.Models.ProductColor", "productColor")
                        .WithMany("productSize")
                        .HasForeignKey("productColorId");

                    b.Navigation("productColor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JZenoApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JZenoApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JZenoApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JZenoApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JZenoApp.Models.Bill", b =>
                {
                    b.Navigation("detailsOrders");
                });

            modelBuilder.Entity("JZenoApp.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("JZenoApp.Models.Partner", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("JZenoApp.Models.Product", b =>
                {
                    b.Navigation("productColor");

                    b.Navigation("productImages");
                });

            modelBuilder.Entity("JZenoApp.Models.ProductColor", b =>
                {
                    b.Navigation("productSize");
                });

            modelBuilder.Entity("JZenoApp.Models.Voucher", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
