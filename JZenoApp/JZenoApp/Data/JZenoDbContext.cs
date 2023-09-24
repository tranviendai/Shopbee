using JZenoApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace JZenoApp.Data
{
    public class JZenoDbContext : IdentityDbContext<User>
    {
        const string ADMIN_USER_GUID = "a79e98b4-d8a6-4640-98eb-5b417ffb2661";
        const string ADMIN_ROLE_GUID = "07bf1560-b5ff-4702-a9f1-a64026e570cf";
        const string CUSTOMER_ROLE_GUID = "2ccdcef3-db18-46c7-b5ff-910be6ae4906";
        const string PARTNER_ROLE_GUID = "5h45cxf3-mx18-4acb-h6d1-420b466e4502";
        private User user;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
                entity.HasData(
                    new IdentityRole
                    {
                        Id = ADMIN_ROLE_GUID,
                        Name = "Admin",
                        NormalizedName = "Admin"
                    },
                    new IdentityRole
                    {
                        Id = CUSTOMER_ROLE_GUID,
                        Name = "Customer",
                        NormalizedName = "Customer"
                    },
                    new IdentityRole
                    {
                        Id = PARTNER_ROLE_GUID,
                        Name = "Partner",
                        NormalizedName = "Partner"
                    });
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
                entity.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = ADMIN_ROLE_GUID,
                        UserId = ADMIN_USER_GUID,
                    });
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
            var hasher = new PasswordHasher<User>();
            builder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasData(
            new User
            {
                Id = ADMIN_USER_GUID,
                image = "shobee-logo.png",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                PasswordHash = hasher.HashPassword(user, "Admin@123"),
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                fullName = "Trần Viễn Đại",
                PhoneNumber = "0582072743",
                address = "Tắc Vân - Cà Mau",
                dateCreated = DateTime.Now,
            });
            });
         
            //Category -- Data
            builder.Entity<Category>(entity =>
            {
                entity.HasData(
                    new Category
                    {
                        Id = "shirt",
                        name = "Shirt",
                        icon = "shirt.png"
                    },
                    new Category
                    {
                        Id = "sandal",
                        name = "Sandal",
                        icon = "sandal.png"
                    },
                    new Category
                    {
                        Id = "shoes",
                        name = "Shoes",
                        icon = "shoes.png"
                    },
                    new Category
                    {
                        Id = "short",
                        name = "Short",
                        icon = "shorts.png"
                    },
                    new Category
                    {
                        Id = "trouser",
                        name = "Trouser",
                        icon = "trousers.png"
                    }
                    );
            });
            /*
             *   builder.Entity<Partner>(e =>
              {
                  e.HasData(
                      new Partner
                      {
                          Id = ""
                      });
              });
              builder.Entity<Product>(e =>
              {
                  e.HasData(
                      new Product
                      {
                          Id = "JZeno",
                          Name = "Shoes Black",
                          Discount = 1,
                          Price = 25000,
                          Description = "....",
                          PostDate = DateTime.Now,
                          isPublish = false,
                          Size = "S",
                          categoryID = "shoes",
                          colorName = "Black",
                          partnerID = ""
                      });
              });
             */

        }
        public JZenoDbContext(DbContextOptions<JZenoDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<DetailOrder> DetailOD { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<NewsImages> NewsImage { get; set; }
        public DbSet<NewsModel> NewsModel { get; set; }
        public DbSet<ProductComment> ProductComment { get; set; }

    }
}