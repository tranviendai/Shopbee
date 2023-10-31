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
        const string PARTNERID01 = "5215212-mx18-4213-h6d1-420b466e4502";
        const string PARTNERID02 = "5dfgsg2-mx18-4213-h6d1-420b466e4502";
        const string PARTNERID03 = "9f15d62-mx18-4213-h6d1-fdsafdsafdsd";
        const string PARTNERID04 = "iosxiof-mx18-4213-h6d1-420b466e4502";
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
                PasswordHash = hasher.HashPassword(user, "123456"),
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                fullName = "Trần Viễn Đại",
                PhoneNumber = "0582072743",
                address = "Tắc Vân - Cà Mau",
                dateCreated = DateTime.Now,
            },
            new User
            {
                Id = PARTNERID01,
                image = "shobee-logo.png",
                UserName = "partner1@gmail.com",
                Email = "partner1@gmail.com",
                PasswordHash = hasher.HashPassword(user, "123456"),
                NormalizedEmail = "PARTNER1@GMAIL.COM",
                NormalizedUserName = "PARTNER1@GMAIL.COM",
                EmailConfirmed = true,
                fullName = "Đối Tác Một",
                PhoneNumber = "0582012351",
                address = "Bình Chánh - Hồ Chí Minh",
                dateCreated = DateTime.Now,
            },
            new User
            {
                Id = PARTNERID02,
                image = "shobee-logo.png",
                UserName = "partner2@gmail.com",
                Email = "partner2@gmail.com",
                PasswordHash = hasher.HashPassword(user, "123456"),
                NormalizedEmail = "PARTNER2@GMAIL.COM",
                NormalizedUserName = "PARTNER2@GMAIL.COM",
                EmailConfirmed = true,
                fullName = "Đối Tác Hai",
                PhoneNumber = "0582015681",
                address = "Trảng Bom - Đồng Nai",
                dateCreated = DateTime.Now,
            },
            new User
            {
                Id = PARTNERID03,
                image = "shobee-logo.png",
                UserName = "partner3@gmail.com",
                Email = "partner3@gmail.com",
                PasswordHash = hasher.HashPassword(user, "123456"),
                NormalizedEmail = "PARTNER3@GMAIL.COM",
                NormalizedUserName = "PARTNER3@GMAIL.COM",
                EmailConfirmed = true,
                fullName = "Đối Tác Ba",
                PhoneNumber = "0582014561",
                address = "Quận 1 - Hồ Chí Minh",
                dateCreated = DateTime.Now,
            },
            new User
            {
                Id = PARTNERID04,
                image = "shobee-logo.png",
                UserName = "partner4@gmail.com",
                Email = "partner4@gmail.com",
                PasswordHash = hasher.HashPassword(user, "123456"),
                NormalizedEmail = "PARTNER4@GMAIL.COM",
                NormalizedUserName = "PARTNER4@GMAIL.COM",
                EmailConfirmed = true,
                fullName = "Đối Tác Bốn",
                PhoneNumber = "0582753561",
                address = "Quận 10 - Hồ Chí Minh",
                dateCreated = DateTime.Now,
            }
            );
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
                entity.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = ADMIN_ROLE_GUID,
                        UserId = ADMIN_USER_GUID,
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = PARTNER_ROLE_GUID,
                        UserId = PARTNERID01,
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = PARTNER_ROLE_GUID,
                        UserId = PARTNERID02,
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = PARTNER_ROLE_GUID,
                        UserId = PARTNERID03,
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = PARTNER_ROLE_GUID,
                        UserId = PARTNERID04,
                    }
                );
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

            builder.Entity<Partner>(entity =>
            {
                entity.HasData(
                    new Partner
                    {
                        partnerId = PARTNERID01,
                        name = "Cửa Hàng A",
                        isActive= true,
                        image = "default_avt.png",
                        description= "Chưa Cập Nhật",
                        dateCreated= DateTime.Now,
                    },
                    new Partner
                    {
                        partnerId = PARTNERID02,
                        name = "Cửa Hàng B",
                        isActive = true,
                        image = "default_avt.png",
                        description = "Chưa Cập Nhật",
                        dateCreated = DateTime.Now,
                    },
                     new Partner
                     {
                         partnerId = PARTNERID03,
                         name = "Cửa Hàng C",
                         isActive = true,
                         image = "default_avt.png",
                         description = "Chưa Cập Nhật",
                         dateCreated = DateTime.Now,
                     },
                      new Partner
                      {
                          partnerId = PARTNERID04,
                          name = "Cửa Hàng D",
                          isActive = true,
                          image = "default_avt.png",
                          description = "Chưa Cập Nhật",
                          dateCreated = DateTime.Now,
                      }
                    );
            }
            );
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
                    },
                    new Category
                    {
                        Id = "camera",
                        name = "Camera",
                        icon = "camera.png"
                    },
                    new Category
                    {
                        Id = "phone",
                        name = "Phone",
                        icon = "phone.png"
                    },
                    new Category
                    {
                        Id = "watch",
                        name = "Watch",
                        icon = "watch.png"
                    },
                    new Category
                    {
                        Id = "computer",
                        name = "Computer",
                        icon = "computer.png"
                    }
                    );
            });
            builder.Entity<Product>(e =>
            {
                e.HasData(
                    new Product // Sản phẩm của Đối Tác Một
                    {
                        Id = "shirt1",
                        name = "Áo thun nam",
                        discount = 10,
                        price = 50000,
                        partnerID = PARTNERID01,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Áo thun nam là một loại trang phục phổ biến dành cho nam giới. Áo được làm từ chất liệu cotton mềm mại, thấm hút mồ hôi tốt, mang lại cảm giác thoải mái cho người mặc. Áo thun nam có nhiều kiểu dáng, màu sắc và họa tiết khác nhau, phù hợp với nhiều phong cách thời trang.",
                        categoryID = "shirt"
                    },
                    new Product
                    {
                        Id = "short1",
                        name = "Quần Short nam",
                        discount = 20,
                        price = 30000,
                        partnerID = PARTNERID01,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Quần short nam là một loại quần dáng ngắn, từ đầu gối trở lên, được thiết kế cho nam giới. Quần short nam thường được làm từ các chất liệu thoáng mát, thấm hút mồ hôi tốt như cotton, kaki, jean,... Quần short nam có nhiều kiểu dáng và mẫu mã khác nhau, phù hợp với nhiều phong cách thời trang.",
                        categoryID = "short"
                    },
                    new Product
                    {
                        Id = "shoes1",
                        name = "Giày thể thao nam",
                        discount = 30,
                        price = 120000,
                        partnerID = PARTNERID01,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Giày thể thao nam là loại giày được thiết kế chủ yếu để phục vụ cho các hoạt động thể thao, thể dục hoặc các hoạt động ngoài trời. Tuy nhiên, ngày nay, giày thể thao nam cũng được sử dụng phổ biến trong đời sống hàng ngày, bởi sự thoải mái, năng động và cá tính của nó.",
                        categoryID = "shoes"
                    },
                    new Product
                    {
                        Id = "camera1",
                        name = "Máy ảnh",
                        discount = 40,
                        price = 5000000,
                        partnerID = PARTNERID01,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Máy ảnh là một thiết bị dùng để ghi lại hình ảnh của thế giới xung quanh. Máy ảnh có thể được chia thành hai loại chính là máy ảnh phim và máy ảnh kỹ thuật số. Máy ảnh phim sử dụng phim ảnh để ghi lại hình ảnh. Phim ảnh là một loại vật liệu nhạy sáng, khi ánh sáng đi qua ống kính sẽ được ghi lại trên phim. Sau đó, phim ảnh cần được mang đi tráng rửa để cho ra một bức ảnh. Máy ảnh kỹ thuật số sử dụng cảm biến điện tử để ghi lại hình ảnh. Cảm biến điện tử sẽ chuyển đổi ánh sáng thành các tín hiệu điện, sau đó các tín hiệu điện này sẽ được lưu trữ dưới dạng file ảnh kỹ thuật số. Máy ảnh có thể được sử dụng để ghi lại những khoảnh khắc quan trọng trong cuộc sống, để lưu giữ những kỷ niệm đẹp, hoặc để thể hiện khả năng sáng tạo của người chụp.",
                        categoryID = "camera"
                    },
                    new Product // Sản phẩm của Đối Tác Hai
                    {
                        Id = "shirt2",
                        name = "Áo sơ mi nữ",
                        discount = 35,
                        price = 70000,
                        partnerID = PARTNERID02,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Áo sơ mi nữ là một loại trang phục có cổ, tay áo và hàng nút phía trước, dành cho phụ nữ. Áo sơ mi nữ có thể được làm từ nhiều loại vải khác nhau, bao gồm cotton, lanh, lụa, polyester, v.v. Áo sơ mi nữ thường có màu sắc trung tính như trắng, đen, xanh dương, v.v., nhưng cũng có thể có màu sắc sặc sỡ hơn.",
                        categoryID = "shirt"
                    },
                    new Product
                    {
                        Id = "trouser2",
                        name = "Quần dài nữ",
                        discount = 25,
                        price = 50000,
                        partnerID = PARTNERID02,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Quần dài nữ là một loại quần có chiều dài từ mắt cá chân trở lên, được thiết kế dành riêng cho phụ nữ. Quần dài nữ có nhiều kiểu dáng, chất liệu và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang và mục đích sử dụng.",
                        categoryID = "trouser"
                    },
                    new Product
                    {
                        Id = "sandal2",
                        name = "Giày sandal nữ",
                        discount = 15,
                        price = 100000,
                        partnerID = PARTNERID02,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Giày sandal nữ là một loại giày dép có quai dép đan chéo hoặc buộc xung quanh bàn chân và mắt cá chân. Giày sandal nữ có nhiều loại, từ sandal đế bệt đến sandal đế cao gót, từ sandal quai mảnh đến sandal quai bản to. Giày sandal nữ được làm từ nhiều chất liệu khác nhau, từ da, vải, nhựa đến cao su.",
                        categoryID = "sandal"
                    },
                    new Product
                    {
                        Id = "phone2",
                        name = "Điện thoại",
                        discount = 5,
                        price = 7500000,
                        partnerID = PARTNERID02,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Điện thoại thông minh (smartphone) là một loại thiết bị di động kết hợp điện thoại di động, máy tính cá nhân và các chức năng điện toán di động khác vào một thiết bị. Smartphone có thể thực hiện các chức năng cơ bản của điện thoại di động, chẳng hạn như thực hiện và nhận cuộc gọi, gửi và nhận tin nhắn văn bản, và truy cập Internet. Ngoài ra, smartphone còn có thể chạy các ứng dụng, chơi game, và thực hiện nhiều tác vụ khác.",
                        categoryID = "phone"
                    },
                    new Product // Sản phẩm của Đối Tác Ba
                    {
                        Id = "shirt3",
                        name = "Áo sơ mi nam",
                        discount = 55,
                        price = 60000,
                        partnerID = PARTNERID03,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Áo sơ mi nam là một loại áo được làm từ vải cotton, linen, hoặc polyester, có cổ áo, tay áo, và khuy áo. Áo sơ mi nam thường được mặc trong các dịp trang trọng, như đi làm, đi dự tiệc, hoặc đi gặp đối tác. Áo sơ mi nam có nhiều kiểu dáng và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang.",
                        categoryID = "shirt"
                    },
                    new Product
                    {
                        Id = "trouser3",
                        name = "Quần dài nam",
                        discount = 45,
                        price = 40000,
                        partnerID = PARTNERID03,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Quần dài nam là một loại trang phục bao phủ phần thân dưới của cơ thể, từ thắt lưng đến mắt cá chân. Quần dài nam có nhiều kiểu dáng, chất liệu và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang.",
                        categoryID = "trouser"
                    },
                    new Product
                    {
                        Id = "sandal3",
                        name = "Giày sandal nam",
                        discount = 35,
                        price = 110000,
                        partnerID = PARTNERID03,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Giày sandal nam là loại giày có quai ngang đan chéo giữa các ngón chân, có thể có quai hậu ở gót hoặc không. Giày sandal nam thường được làm từ chất liệu da, vải, hoặc nhựa. Giày sandal nam có ưu điểm là thoáng mát, dễ đi, và phù hợp với nhiều trang phục khác nhau.",
                        categoryID = "sandal"
                    },
                    new Product
                    {
                        Id = "watch3",
                        name = "Đồng hồ",
                        discount = 25,
                        price = 500000,
                        partnerID = PARTNERID03,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Đồng hồ đeo tay là một chiếc đồng hồ được thiết kế để đeo trên cổ tay. Nó được điều khiển bởi một bộ máy cơ học hoặc điện tử và hiển thị thời gian bằng các kim hoặc màn hình điện tử. Đồng hồ đeo tay là một vật dụng thiết yếu trong cuộc sống hiện đại, được sử dụng để theo dõi thời gian, quản lý công việc và thể hiện phong cách cá nhân.",
                        categoryID = "watch"
                    },
                    new Product // Sản phẩm của Đối Tác Bốn
                    {
                        Id = "shirt4",
                        name = "Áo thun nữ",
                        discount = 50,
                        price = 80000,
                        partnerID = PARTNERID04,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Áo thun nữ là một loại áo được làm từ chất liệu cotton, có kiểu dáng đơn giản, dễ mặc, dễ phối đồ. Áo thun nữ có thể được mặc trong nhiều dịp khác nhau, từ đi chơi, đi làm, đến tập thể thao.",
                        categoryID = "shirt"
                    },
                    new Product
                    {
                        Id = "short4",
                        name = "Quần Short nữ",
                        discount = 40,
                        price = 60000,
                        partnerID = PARTNERID04,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Quần short nữ là một loại quần ngắn, thường có chiều dài đến đầu gối hoặc trên đầu gối. Quần short nữ có thể được làm từ nhiều chất liệu khác nhau, như cotton, denim, kaki,... Quần short nữ thường được mặc trong những dịp thoải mái, như đi chơi, đi dạo,...",
                        categoryID = "short"
                    },
                    new Product
                    {
                        Id = "shoes4",
                        name = "Giày thể thao nữ",
                        discount = 30,
                        price = 130000,
                        partnerID = PARTNERID04,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Giày thể thao nữ là loại giày được thiết kế dành riêng cho nữ giới, thường được sử dụng để tập thể dục, thể thao, hay đơn giản là để đi lại hàng ngày. Giày thể thao nữ có đặc điểm chung là đế cao su mềm, có độ bám tốt, giúp người sử dụng di chuyển dễ dàng và thoải mái. Ngoài ra, giày thể thao nữ còn có phần thân giày được làm từ nhiều chất liệu khác nhau, như da, vải, hay nhựa, tùy theo sở thích và nhu cầu của người sử dụng.",
                        categoryID = "shoes"
                    },
                    new Product
                    {
                        Id = "computer4",
                        name = "Máy tính",
                        discount = 20,
                        price = 10000000,
                        partnerID = PARTNERID04,
                        isPublish = true,
                        postDate = DateTime.Now,
                        description = "Máy tính là một thiết bị điện tử có thể thực hiện các phép tính và xử lý thông tin theo một chương trình được viết sẵn. Máy tính có thể được sử dụng cho nhiều mục đích khác nhau, bao gồm tính toán, soạn thảo văn bản, chơi game, nghe nhạc, xem phim, v.v.",
                        categoryID = "computer"
                    }
                );
            });

            builder.Entity<ProductColor>(e =>
            {
                e.HasData(
                    new ProductColor // Màu sản phẩm của Đối Tác Một
                    {
                        Id = "whiteshirt1",
                        Name = "Trắng",
                        productId = "shirt1"
                    },
                    new ProductColor
                    {
                        Id = "blackshirt1",
                        Name = "Đen",
                        productId = "shirt1"
                    },
                    new ProductColor
                    {
                        Id = "redshort1",
                        Name = "Đỏ",
                        productId = "short1"
                    },
                    new ProductColor
                    {
                        Id = "blueshort1",
                        Name = "Xanh Dương",
                        productId = "short1"
                    },
                    new ProductColor
                    {
                        Id = "blackshoes1",
                        Name = "Đen",
                        productId = "shoes1"
                    },
                    new ProductColor
                    {
                        Id = "whiteshoes1",
                        Name = "Trắng",
                        productId = "shoes1"
                    },
                    new ProductColor
                    {
                        Id = "blackcamera1",
                        Name = "Đen",
                        productId = "camera1"
                    },
                    new ProductColor
                    {
                        Id = "whitecamera1",
                        Name = "Trắng",
                        productId = "camera1"
                    },
                    new ProductColor // Màu sản phẩm của Đối Tác Hai
                    {
                        Id = "yellowshirt2",
                        Name = "Vàng",
                        productId = "shirt2"
                    },
                    new ProductColor
                    {
                        Id = "greenshirt2",
                        Name = "Xanh Lá",
                        productId = "shirt2"
                    },
                    new ProductColor
                    {
                        Id = "whitetrouser2",
                        Name = "Trắng",
                        productId = "trouser2"
                    },
                    new ProductColor
                    {
                        Id = "pinktrouser2",
                        Name = "Hồng",
                        productId = "trouser2"
                    },
                    new ProductColor
                    {
                        Id = "bluesandal2",
                        Name = "Xanh Dương",
                        productId = "sandal2"
                    },
                    new ProductColor
                    {
                        Id = "greensandal2",
                        Name = "Xanh Lá",
                        productId = "sandal2"
                    },
                    new ProductColor
                    {
                        Id = "bluephone2",
                        Name = "Xanh Dương",
                        productId = "phone2"
                    },
                    new ProductColor
                    {
                        Id = "naturalphone2",
                        Name = "Tự Nhiên",
                        productId = "phone2"
                    },
                    new ProductColor // Màu sản phẩm của Đối Tác Ba
                    {
                        Id = "blackshirt3",
                        Name = "Đen",
                        productId = "shirt3"
                    },
                    new ProductColor
                    {
                        Id = "whiteshirt3",
                        Name = "Trắng",
                        productId = "shirt3"
                    },
                    new ProductColor
                    {
                        Id = "blacktrouser3",
                        Name = "Đen",
                        productId = "trouser3"
                    },
                    new ProductColor
                    {
                        Id = "whitetrouser3",
                        Name = "Trắng",
                        productId = "trouser3"
                    },
                    new ProductColor
                    {
                        Id = "brownsandal3",
                        Name = "Nâu",
                        productId = "sandal3"
                    },
                    new ProductColor
                    {
                        Id = "greensandal3",
                        Name = "Xanh Lá",
                        productId = "sandal3"
                    },
                    new ProductColor
                    {
                        Id = "pinkwatch3",
                        Name = "Hồng",
                        productId = "watch3"
                    },
                    new ProductColor
                    {
                        Id = "whitewatch3",
                        Name = "Trắng",
                        productId = "watch3"
                    },
                    new ProductColor // Màu sản phẩm của Đối Tác Bốn
                    {
                        Id = "greyshirt4",
                        Name = "Xám",
                        productId = "shirt4"
                    },
                    new ProductColor
                    {
                        Id = "pinkshirt4",
                        Name = "Hồng",
                        productId = "shirt4"
                    },
                    new ProductColor
                    {
                        Id = "blackshort4",
                        Name = "Đen",
                        productId = "short4"
                    },
                    new ProductColor
                    {
                        Id = "blueshort4",
                        Name = "Xanh Dương",
                        productId = "short4"
                    },
                    new ProductColor
                    {
                        Id = "purpleshoes4",
                        Name = "Tím",
                        productId = "shoes4"
                    },
                    new ProductColor
                    {
                        Id = "pinkshoes4",
                        Name = "Hồng",
                        productId = "shoes4"
                    },
                    new ProductColor
                    {
                        Id = "bluecomputer4",
                        Name = "Xanh Dương",
                        productId = "computer4"
                    },
                    new ProductColor
                    {
                        Id = "blackcomputer4",
                        Name = "Đen",
                        productId = "computer4"
                    }
                );
            });


            builder.Entity<ProductSize>(e =>
            {
                e.HasData(
                    new ProductSize // Kích thước sản phẩm của Đối Tác Một // White Shirt
                    {
                        Id = 1,
                        name = "S",
                        quantity = 50,
                        productColorId = "whiteshirt1"
                    },
                    new ProductSize
                    {
                        Id = 2,
                        name = "M",
                        quantity = 40,
                        productColorId = "whiteshirt1"
                    },
                    new ProductSize
                    {
                        Id = 3,
                        name = "L",
                        quantity = 30,
                        productColorId = "whiteshirt1"
                    },
                    new ProductSize
                    {
                        Id = 4,
                        name = "XL",
                        quantity = 20,
                        productColorId = "whiteshirt1"
                    },
                    new ProductSize // Black Shirt
                    {
                        Id = 5,
                        name = "S",
                        quantity = 20,
                        productColorId = "blackshirt1"
                    },
                    new ProductSize
                    {
                        Id = 6,
                        name = "M",
                        quantity = 30,
                        productColorId = "blackshirt1"
                    },
                    new ProductSize
                    {
                        Id = 7,
                        name = "L",
                        quantity = 40,
                        productColorId = "blackshirt1"
                    },
                    new ProductSize
                    {
                        Id = 8,
                        name = "XL",
                        quantity = 50,
                        productColorId = "blackshirt1"
                    },
                    new ProductSize // Red Short
                    {
                        Id = 9,
                        name = "S",
                        quantity = 20,
                        productColorId = "redshort1"
                    },
                    new ProductSize
                    {
                        Id = 10,
                        name = "M",
                        quantity = 30,
                        productColorId = "redshort1"
                    },
                    new ProductSize
                    {
                        Id = 11,
                        name = "L",
                        quantity = 40,
                        productColorId = "redshort1"
                    },
                    new ProductSize
                    {
                        Id = 12,
                        name = "XL",
                        quantity = 50,
                        productColorId = "redshort1"
                    },
                    new ProductSize // Blue Short
                    {
                        Id = 13,
                        name = "S",
                        quantity = 50,
                        productColorId = "blueshort1"
                    },
                    new ProductSize
                    {
                        Id = 14,
                        name = "M",
                        quantity = 40,
                        productColorId = "blueshort1"
                    },
                    new ProductSize
                    {
                        Id = 15,
                        name = "L",
                        quantity = 30,
                        productColorId = "blueshort1"
                    },
                    new ProductSize
                    {
                        Id = 16,
                        name = "XL",
                        quantity = 20,
                        productColorId = "blueshort1"
                    },
                    new ProductSize // Black Shoes
                    {
                        Id = 17,
                        name = "39",
                        quantity = 30,
                        productColorId = "blackshoes1"
                    },
                    new ProductSize
                    {
                        Id = 18,
                        name = "40",
                        quantity = 40,
                        productColorId = "blackshoes1"
                    },
                    new ProductSize
                    {
                        Id = 19,
                        name = "41",
                        quantity = 50,
                        productColorId = "blackshoes1"
                    },
                    new ProductSize
                    {
                        Id = 20,
                        name = "42",
                        quantity = 50,
                        productColorId = "blackshoes1"
                    },
                    new ProductSize
                    {
                        Id = 21,
                        name = "43",
                        quantity = 40,
                        productColorId = "blackshoes1"
                    },
                    new ProductSize
                    {
                        Id = 22,
                        name = "44",
                        quantity = 30,
                        productColorId = "blackshoes1"
                    },
                    new ProductSize // White Shoes
                    {
                        Id = 23,
                        name = "39",
                        quantity = 30,
                        productColorId = "whiteshoes1"
                    },
                    new ProductSize
                    {
                        Id = 24,
                        name = "40",
                        quantity = 40,
                        productColorId = "whiteshoes1"
                    },
                    new ProductSize
                    {
                        Id = 25,
                        name = "41",
                        quantity = 50,
                        productColorId = "whiteshoes1"
                    },
                    new ProductSize
                    {
                        Id = 26,
                        name = "42",
                        quantity = 50,
                        productColorId = "whiteshoes1"
                    },
                    new ProductSize
                    {
                        Id = 27,
                        name = "43",
                        quantity = 40,
                        productColorId = "whiteshoes1"
                    },
                    new ProductSize
                    {
                        Id = 28,
                        name = "44",
                        quantity = 30,
                        productColorId = "whiteshoes1"
                    },
                    new ProductSize // Kích thước sản phẩm của Đối Tác Hai // Yellow Shirt
                    {
                        Id = 29,
                        name = "S",
                        quantity = 50,
                        productColorId = "yellowshirt2"
                    },
                    new ProductSize
                    {
                        Id = 30,
                        name = "M",
                        quantity = 40,
                        productColorId = "yellowshirt2"
                    },
                    new ProductSize
                    {
                        Id = 31,
                        name = "L",
                        quantity = 30,
                        productColorId = "yellowshirt2"
                    },
                    new ProductSize
                    {
                        Id = 32,
                        name = "XL",
                        quantity = 20,
                        productColorId = "yellowshirt2"
                    },
                    new ProductSize // Green Shirt
                    {
                        Id = 33,
                        name = "S",
                        quantity = 20,
                        productColorId = "greenshirt2"
                    },
                    new ProductSize
                    {
                        Id = 34,
                        name = "M",
                        quantity = 30,
                        productColorId = "greenshirt2"
                    },
                    new ProductSize
                    {
                        Id = 35,
                        name = "L",
                        quantity = 40,
                        productColorId = "greenshirt2"
                    },
                    new ProductSize
                    {
                        Id = 36,
                        name = "XL",
                        quantity = 50,
                        productColorId = "greenshirt2"
                    },
                    new ProductSize // White Trouser
                    {
                        Id = 37,
                        name = "S",
                        quantity = 20,
                        productColorId = "whitetrouser2"
                    },
                    new ProductSize
                    {
                        Id = 38,
                        name = "M",
                        quantity = 30,
                        productColorId = "whitetrouser2"
                    },
                    new ProductSize
                    {
                        Id = 39,
                        name = "L",
                        quantity = 40,
                        productColorId = "whitetrouser2"
                    },
                    new ProductSize
                    {
                        Id = 40,
                        name = "XL",
                        quantity = 50,
                        productColorId = "whitetrouser2"
                    },
                    new ProductSize // Pink Trouser
                    {
                        Id = 41,
                        name = "S",
                        quantity = 50,
                        productColorId = "pinktrouser2"
                    },
                    new ProductSize
                    {
                        Id = 42,
                        name = "M",
                        quantity = 40,
                        productColorId = "pinktrouser2"
                    },
                    new ProductSize
                    {
                        Id = 43,
                        name = "L",
                        quantity = 30,
                        productColorId = "pinktrouser2"
                    },
                    new ProductSize
                    {
                        Id = 44,
                        name = "XL",
                        quantity = 20,
                        productColorId = "pinktrouser2"
                    },
                    new ProductSize // Blue Sandal
                    {
                        Id = 45,
                        name = "39",
                        quantity = 30,
                        productColorId = "bluesandal2"
                    },
                    new ProductSize
                    {
                        Id = 46,
                        name = "40",
                        quantity = 40,
                        productColorId = "bluesandal2"
                    },
                    new ProductSize
                    {
                        Id = 47,
                        name = "41",
                        quantity = 50,
                        productColorId = "bluesandal2"
                    },
                    new ProductSize
                    {
                        Id = 48,
                        name = "42",
                        quantity = 50,
                        productColorId = "bluesandal2"
                    },
                    new ProductSize
                    {
                        Id = 49,
                        name = "43",
                        quantity = 40,
                        productColorId = "bluesandal2"
                    },
                    new ProductSize
                    {
                        Id = 50,
                        name = "44",
                        quantity = 30,
                        productColorId = "bluesandal2"
                    },
                    new ProductSize // Green Sandal
                    {
                        Id = 51,
                        name = "39",
                        quantity = 30,
                        productColorId = "greensandal2"
                    },
                    new ProductSize
                    {
                        Id = 52,
                        name = "40",
                        quantity = 40,
                        productColorId = "greensandal2"
                    },
                    new ProductSize
                    {
                        Id = 53,
                        name = "41",
                        quantity = 50,
                        productColorId = "greensandal2"
                    },
                    new ProductSize
                    {
                        Id = 54,
                        name = "42",
                        quantity = 50,
                        productColorId = "greensandal2"
                    },
                    new ProductSize
                    {
                        Id = 55,
                        name = "43",
                        quantity = 40,
                        productColorId = "greensandal2"
                    },
                    new ProductSize
                    {
                        Id = 56,
                        name = "44",
                        quantity = 30,
                        productColorId = "greensandal2"
                    },
                    new ProductSize // Kích thước sản phẩm của Đối Tác Ba // Black Shirt
                    {
                        Id = 57,
                        name = "S",
                        quantity = 50,
                        productColorId = "blackshirt3"
                    },
                    new ProductSize
                    {
                        Id = 58,
                        name = "M",
                        quantity = 40,
                        productColorId = "blackshirt3"
                    },
                    new ProductSize
                    {
                        Id = 59,
                        name = "L",
                        quantity = 30,
                        productColorId = "blackshirt3"
                    },
                    new ProductSize
                    {
                        Id = 60,
                        name = "XL",
                        quantity = 20,
                        productColorId = "blackshirt3"
                    },
                    new ProductSize // White Shirt
                    {
                        Id = 61,
                        name = "S",
                        quantity = 20,
                        productColorId = "whiteshirt3"
                    },
                    new ProductSize
                    {
                        Id = 62,
                        name = "M",
                        quantity = 30,
                        productColorId = "whiteshirt3"
                    },
                    new ProductSize
                    {
                        Id = 63,
                        name = "L",
                        quantity = 40,
                        productColorId = "whiteshirt3"
                    },
                    new ProductSize
                    {
                        Id = 64,
                        name = "XL",
                        quantity = 50,
                        productColorId = "whiteshirt3"
                    },
                    new ProductSize // Black Trouser
                    {
                        Id = 65,
                        name = "S",
                        quantity = 20,
                        productColorId = "blacktrouser3"
                    },
                    new ProductSize
                    {
                        Id = 66,
                        name = "M",
                        quantity = 30,
                        productColorId = "blacktrouser3"
                    },
                    new ProductSize
                    {
                        Id = 67,
                        name = "L",
                        quantity = 40,
                        productColorId = "blacktrouser3"
                    },
                    new ProductSize
                    {
                        Id = 68,
                        name = "XL",
                        quantity = 50,
                        productColorId = "blacktrouser3"
                    },
                    new ProductSize // White Trouser
                    {
                        Id = 69,
                        name = "S",
                        quantity = 50,
                        productColorId = "whitetrouser3"
                    },
                    new ProductSize
                    {
                        Id = 70,
                        name = "M",
                        quantity = 40,
                        productColorId = "whitetrouser3"
                    },
                    new ProductSize
                    {
                        Id = 71,
                        name = "L",
                        quantity = 30,
                        productColorId = "whitetrouser3"
                    },
                    new ProductSize
                    {
                        Id = 72,
                        name = "XL",
                        quantity = 20,
                        productColorId = "whitetrouser3"
                    },
                    new ProductSize // Brown Sandal
                    {
                        Id = 73,
                        name = "39",
                        quantity = 30,
                        productColorId = "brownsandal3"
                    },
                    new ProductSize
                    {
                        Id = 74,
                        name = "40",
                        quantity = 40,
                        productColorId = "brownsandal3"
                    },
                    new ProductSize
                    {
                        Id = 75,
                        name = "41",
                        quantity = 50,
                        productColorId = "brownsandal3"
                    },
                    new ProductSize
                    {
                        Id = 76,
                        name = "42",
                        quantity = 50,
                        productColorId = "brownsandal3"
                    },
                    new ProductSize
                    {
                        Id = 77,
                        name = "43",
                        quantity = 40,
                        productColorId = "brownsandal3"
                    },
                    new ProductSize
                    {
                        Id = 78,
                        name = "44",
                        quantity = 30,
                        productColorId = "brownsandal3"
                    },
                    new ProductSize // Green Sandal
                    {
                        Id = 79,
                        name = "39",
                        quantity = 30,
                        productColorId = "greensandal3"
                    },
                    new ProductSize
                    {
                        Id = 80,
                        name = "40",
                        quantity = 40,
                        productColorId = "greensandal3"
                    },
                    new ProductSize
                    {
                        Id = 81,
                        name = "41",
                        quantity = 50,
                        productColorId = "greensandal3"
                    },
                    new ProductSize
                    {
                        Id = 82,
                        name = "42",
                        quantity = 50,
                        productColorId = "greensandal3"
                    },
                    new ProductSize
                    {
                        Id = 83,
                        name = "43",
                        quantity = 40,
                        productColorId = "greensandal3"
                    },
                    new ProductSize
                    {
                        Id = 84,
                        name = "44",
                        quantity = 30,
                        productColorId = "greensandal3"
                    },
                    new ProductSize // Kích thước sản phẩm của Đối Tác Bốn // Grey Shirt
                    {
                        Id = 85,
                        name = "S",
                        quantity = 50,
                        productColorId = "greyshirt4"
                    },
                    new ProductSize
                    {
                        Id = 86,
                        name = "M",
                        quantity = 40,
                        productColorId = "greyshirt4"
                    },
                    new ProductSize
                    {
                        Id = 87,
                        name = "L",
                        quantity = 30,
                        productColorId = "greyshirt4"
                    },
                    new ProductSize
                    {
                        Id = 88,
                        name = "XL",
                        quantity = 20,
                        productColorId = "greyshirt4"
                    },
                    new ProductSize // Pink Shirt
                    {
                        Id = 89,
                        name = "S",
                        quantity = 20,
                        productColorId = "pinkshirt4"
                    },
                    new ProductSize
                    {
                        Id = 90,
                        name = "M",
                        quantity = 30,
                        productColorId = "pinkshirt4"
                    },
                    new ProductSize
                    {
                        Id = 91,
                        name = "L",
                        quantity = 40,
                        productColorId = "pinkshirt4"
                    },
                    new ProductSize
                    {
                        Id = 92,
                        name = "XL",
                        quantity = 50,
                        productColorId = "pinkshirt4"
                    },
                    new ProductSize // Black Short
                    {
                        Id = 93,
                        name = "S",
                        quantity = 20,
                        productColorId = "blackshort4"
                    },
                    new ProductSize
                    {
                        Id = 94,
                        name = "M",
                        quantity = 30,
                        productColorId = "blackshort4"
                    },
                    new ProductSize
                    {
                        Id = 95,
                        name = "L",
                        quantity = 40,
                        productColorId = "blackshort4"
                    },
                    new ProductSize
                    {
                        Id = 96,
                        name = "XL",
                        quantity = 50,
                        productColorId = "blackshort4"
                    },
                    new ProductSize // Blue Short
                    {
                        Id = 97,
                        name = "S",
                        quantity = 50,
                        productColorId = "blueshort4"
                    },
                    new ProductSize
                    {
                        Id = 98,
                        name = "M",
                        quantity = 40,
                        productColorId = "blueshort4"
                    },
                    new ProductSize
                    {
                        Id = 99,
                        name = "L",
                        quantity = 30,
                        productColorId = "blueshort4"
                    },
                    new ProductSize
                    {
                        Id = 100,
                        name = "XL",
                        quantity = 20,
                        productColorId = "blueshort4"
                    },
                    new ProductSize // Purple Shoes
                    {
                        Id = 101,
                        name = "39",
                        quantity = 30,
                        productColorId = "purpleshoes4"
                    },
                    new ProductSize
                    {
                        Id = 102,
                        name = "40",
                        quantity = 40,
                        productColorId = "purpleshoes4"
                    },
                    new ProductSize
                    {
                        Id = 103,
                        name = "41",
                        quantity = 50,
                        productColorId = "purpleshoes4"
                    },
                    new ProductSize
                    {
                        Id = 104,
                        name = "42",
                        quantity = 50,
                        productColorId = "purpleshoes4"
                    },
                    new ProductSize
                    {
                        Id = 105,
                        name = "43",
                        quantity = 40,
                        productColorId = "purpleshoes4"
                    },
                    new ProductSize
                    {
                        Id = 106,
                        name = "44",
                        quantity = 30,
                        productColorId = "purpleshoes4"
                    },
                    new ProductSize // Pink Shoes
                    {
                        Id = 107,
                        name = "39",
                        quantity = 30,
                        productColorId = "pinkshoes4"
                    },
                    new ProductSize
                    {
                        Id = 108,
                        name = "40",
                        quantity = 40,
                        productColorId = "pinkshoes4"
                    },
                    new ProductSize
                    {
                        Id = 109,
                        name = "41",
                        quantity = 50,
                        productColorId = "pinkshoes4"
                    },
                    new ProductSize
                    {
                        Id = 110,
                        name = "42",
                        quantity = 50,
                        productColorId = "pinkshoes4"
                    },
                    new ProductSize
                    {
                        Id = 111,
                        name = "43",
                        quantity = 40,
                        productColorId = "pinkshoes4"
                    },
                    new ProductSize
                    {
                        Id = 112,
                        name = "44",
                        quantity = 30,
                        productColorId = "pinkshoes4"
                    },
                    new ProductSize
                    {
                        Id = 113,
                        name = "64GB",
                        quantity = 30,
                        productColorId = "blackcamera1"
                    },
                    new ProductSize
                    {
                        Id = 114,
                        name = "128GB",
                        quantity = 20,
                        productColorId = "blackcamera1"
                    },
                    new ProductSize
                    {
                        Id = 115,
                        name = "8RAM-128GB",
                        quantity = 10,
                        productColorId = "blackcomputer4"
                    },
                     new ProductSize
                     {
                         Id = 116,
                         name = "8RAM-128GB",
                         quantity = 30,
                         productColorId = "bluecomputer4"
                     },
                    new ProductSize
                    {
                        Id = 117,
                        name = "64GB",
                        quantity = 30,
                        productColorId = "bluephone2"
                    },
                     new ProductSize
                     {
                         Id = 118,
                         name = "128GB",
                         quantity = 30,
                         productColorId = "bluephone2"
                     },
                        new ProductSize
                        {
                            Id = 119,
                            name = "64GB",
                            quantity = 30,
                            productColorId = "naturalphone2"
                        },
                        new ProductSize
                        {
                            Id = 120,
                            name = "128GB",
                            quantity = 30,
                            productColorId = "naturalphone2"
                        },
                     new ProductSize
                     {
                         Id = 121,
                         name = "64GB",
                         quantity = 30,
                         productColorId = "whitecamera1"
                     },
                      new ProductSize
                      {
                          Id = 122,
                          name = "128GB",
                          quantity = 30,
                          productColorId = "whitecamera1"
                      },
                      new ProductSize
                      {
                          Id = 123,
                          name = "64GB",
                          quantity = 30,
                          productColorId = "whitewatch3"
                      },
                      new ProductSize
                      {
                          Id = 124,
                          name = "64GB",
                          quantity = 30,
                          productColorId = "pinkwatch3"
                      }
                );
            });

            builder.Entity<ProductImage>(e =>
            {
                e.HasData(
                    new Models.ProductImage // Hình ảnh sản phẩm của Đối Tác Một
                    {
                        Id = 1,
                        URL = "shirt1_white.jpg",
                        productId = "shirt1"
                    },
                    new Models.ProductImage
                    {
                        Id = 2,
                        URL = "shirt1_black.jpg",
                        productId = "shirt1"
                    },
                    new Models.ProductImage
                    {
                        Id = 3,
                        URL = "short1_blue.jpg",
                        productId = "short1"
                    },
                    new Models.ProductImage
                    {
                        Id = 4,
                        URL = "short1_red.jpg",
                        productId = "short1"
                    },
                    new Models.ProductImage
                    {
                        Id = 5,
                        URL = "shoes1_black.jpg",
                        productId = "shoes1"
                    },
                    new Models.ProductImage
                    {
                        Id = 6,
                        URL = "shoes1_white.jpg",
                        productId = "shoes1"
                    },
                    new Models.ProductImage
                    {
                        Id = 7,
                        URL = "camera1_black.jpg",
                        productId = "camera1"
                    },
                    new Models.ProductImage
                    {
                        Id = 8,
                        URL = "camera1_white.jpg",
                        productId = "camera1"
                    },
                    new Models.ProductImage // Hình ảnh sản phẩm của Đối Tác Hai
                    {
                        Id = 9,
                        URL = "shirt2_yellow.jpg",
                        productId = "shirt2"
                    },
                    new Models.ProductImage
                    {
                        Id = 10,
                        URL = "shirt2_green.jpg",
                        productId = "shirt2"
                    },
                    new Models.ProductImage
                    {
                        Id = 11,
                        URL = "trouser2_white.jpg",
                        productId = "trouser2"
                    },
                    new Models.ProductImage
                    {
                        Id = 12,
                        URL = "trouser2_pink.jpg",
                        productId = "trouser2"
                    },
                    new Models.ProductImage
                    {
                        Id = 13,
                        URL = "sandal2_blue.jpg",
                        productId = "sandal2"
                    },
                    new Models.ProductImage
                    {
                        Id = 14,
                        URL = "sandal2_green.jpg",
                        productId = "sandal2"
                    },
                    new Models.ProductImage
                    {
                        Id = 15,
                        URL = "phone2_blue.jpg",
                        productId = "phone2"
                    },
                    new Models.ProductImage
                    {
                        Id = 16,
                        URL = "phone2_natural.jpg",
                        productId = "phone2"
                    },
                    new Models.ProductImage // Hình ảnh sản phẩm của Đối Tác Ba
                    {
                        Id = 17,
                        URL = "shirt3_black.jpg",
                        productId = "shirt3"
                    },
                    new Models.ProductImage
                    {
                        Id = 18,
                        URL = "shirt3_white.jpg",
                        productId = "shirt3"
                    },
                    new Models.ProductImage
                    {
                        Id = 19,
                        URL = "trouser3_black.jpg",
                        productId = "trouser3"
                    },
                    new Models.ProductImage
                    {
                        Id = 20,
                        URL = "trouser3_white.jpg",
                        productId = "trouser3"
                    },
                    new Models.ProductImage
                    {
                        Id = 21,
                        URL = "sandal3_brown.jpg",
                        productId = "sandal3"
                    },
                    new Models.ProductImage
                    {
                        Id = 22,
                        URL = "sandal3_green.jpg",
                        productId = "sandal3"
                    },
                    new Models.ProductImage
                    {
                        Id = 23,
                        URL = "watch3_pink.jpg",
                        productId = "watch3"
                    },
                    new Models.ProductImage
                    {
                        Id = 24,
                        URL = "watch3_white.jpg",
                        productId = "watch3"
                    },
                    new Models.ProductImage // Hình ảnh sản phẩm của Đối Tác Bốn
                    {
                        Id = 25,
                        URL = "shirt4_grey.jpg",
                        productId = "shirt4"
                    },
                    new Models.ProductImage
                    {
                        Id = 26,
                        URL = "shirt4_pink.jpg",
                        productId = "shirt4"
                    },
                    new Models.ProductImage
                    {
                        Id = 27,
                        URL = "short4_black.jpg",
                        productId = "short4"
                    },
                    new Models.ProductImage
                    {
                        Id = 28,
                        URL = "short4_blue.jpg",
                        productId = "short4"
                    },
                    new Models.ProductImage
                    {
                        Id = 29,
                        URL = "shoes4_purple.jpg",
                        productId = "shoes4"
                    },
                    new Models.ProductImage
                    {
                        Id = 30,
                        URL = "shoes4_pink.jpg",
                        productId = "shoes4"
                    },
                    new Models.ProductImage
                    {
                        Id = 31,
                        URL = "computer4_blue.jpg",
                        productId = "computer4"
                    },
                    new Models.ProductImage
                    {
                        Id = 32,
                        URL = "computer4_black.jpg",
                        productId = "computer4"
                    }
                );
            });
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
        public DbSet<NewsModel> NewsModel { get; set; }
        public DbSet<ProductComment> ProductComment { get; set; }

    }
}