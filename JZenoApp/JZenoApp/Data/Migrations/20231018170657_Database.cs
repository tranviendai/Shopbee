using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partner",
                columns: table => new
                {
                    partnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner", x => x.partnerId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    voucherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.voucherID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    discount = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    postDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isPublish = table.Column<bool>(type: "bit", nullable: true),
                    categoryID = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    _partnerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    partnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Partner_partnerId",
                        column: x => x.partnerId,
                        principalTable: "Partner",
                        principalColumn: "partnerId");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsModel_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    billID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    payment = table.Column<bool>(type: "bit", nullable: true),
                    deliveryForm = table.Column<bool>(type: "bit", nullable: true),
                    voucherID = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.billID);
                    table.ForeignKey(
                        name: "FK_Bill_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bill_Voucher_voucherID",
                        column: x => x.voucherID,
                        principalTable: "Voucher",
                        principalColumn: "voucherID");
                });

            migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    productId = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColor_Product_productId",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductComment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    evaluate = table.Column<int>(type: "int", nullable: true),
                    productId = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComment", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductComment_Product_productId",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productId = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_productId",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    quantity = table.Column<double>(type: "float", nullable: true),
                    productColorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSize_ProductColor_productColorId",
                        column: x => x.productColorId,
                        principalTable: "ProductColor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailOD",
                columns: table => new
                {
                    odID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    billID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    totalPrice = table.Column<double>(type: "float", nullable: true),
                    sizeName = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    colorName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    productId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailOD", x => x.odID);
                    table.ForeignKey(
                        name: "FK_DetailOD_Bill_billID",
                        column: x => x.billID,
                        principalTable: "Bill",
                        principalColumn: "billID");
                    table.ForeignKey(
                        name: "FK_DetailOD_ProductSize_productId",
                        column: x => x.productId,
                        principalTable: "ProductSize",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "icon", "name" },
                values: new object[,]
                {
                    { "sandal", "sandal.png", "Sandal" },
                    { "shirt", "shirt.png", "Shirt" },
                    { "shoes", "shoes.png", "Shoes" },
                    { "short", "shorts.png", "Short" },
                    { "trouser", "trousers.png", "Trouser" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07bf1560-b5ff-4702-a9f1-a64026e570cf", null, "Admin", "Admin" },
                    { "2ccdcef3-db18-46c7-b5ff-910be6ae4906", null, "Customer", "Customer" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", null, "Partner", "Partner" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "address", "dateCreated", "fullName", "image" },
                values: new object[,]
                {
                    { "5215212-mx18-4213-h6d1-420b466e4502", 0, "94e6b14b-adb4-47ca-9b70-04fc338f49dd", "partner1@gmail.com", true, false, null, "PARTNER1@GMAIL.COM", "PARTNER1@GMAIL.COM", "AQAAAAIAAYagAAAAEOjPxvGl7hj86pDgMGnzqBeZvMZpQVnzpO2Oc4zgxetuQDrgfkpkb4zKcK36EKjSlw==", "0582012351", false, "0474b23e-a51b-4511-8dde-3cfc873b649c", false, "partner1@gmail.com", "Bình Chánh - Hồ Chí Minh", new DateTime(2023, 10, 19, 0, 6, 57, 225, DateTimeKind.Local).AddTicks(7813), "Đối Tác Một", "shobee-logo.png" },
                    { "5dfgsg2-mx18-4213-h6d1-420b466e4502", 0, "23bc8022-cd7c-4eac-b7a8-3962c97e401f", "partner2@gmail.com", true, false, null, "PARTNER2@GMAIL.COM", "PARTNER2@GMAIL.COM", "AQAAAAIAAYagAAAAEB1Wkvd5wQ5H4fqTfKxYOCSRGsQSed1NIgk/AZXpzgZjVzSB297XR10dd5UQRyi1XA==", "0582015681", false, "94640bad-4fb5-4b9d-82d4-a21d66de1627", false, "partner2@gmail.com", "Trảng Bom - Đồng Nai", new DateTime(2023, 10, 19, 0, 6, 57, 320, DateTimeKind.Local).AddTicks(3298), "Đối Tác Hai", "shobee-logo.png" },
                    { "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", 0, "4a56309f-0939-46ef-8fc8-c3ce318a9b74", "partner3@gmail.com", true, false, null, "PARTNER3@GMAIL.COM", "PARTNER3@GMAIL.COM", "AQAAAAIAAYagAAAAEI20nz08XKTz+xtxxdMXyBr+ZeID74KPGdAsEZ8UQQlSzqK7xKTxokaHuW/w0Iz/Kg==", "0582014561", false, "3d5b73ed-245e-4f63-a02e-5965b0b27291", false, "partner3@gmail.com", "Quận 1 - Hồ Chí Minh", new DateTime(2023, 10, 19, 0, 6, 57, 414, DateTimeKind.Local).AddTicks(3285), "Đối Tác Ba", "shobee-logo.png" },
                    { "a79e98b4-d8a6-4640-98eb-5b417ffb2661", 0, "d5c96a3b-df9e-460d-a8e8-ef623c7df109", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPPskGy+iIkyLvPPQjK/rMmEzPEveaHnGzFYSH7nmVAH4xoe94kb8fuU1/gGMSmGrw==", "0582072743", false, "05b6f9ae-0157-4eab-91b8-231a766141f7", false, "admin@gmail.com", "Tắc Vân - Cà Mau", new DateTime(2023, 10, 19, 0, 6, 57, 125, DateTimeKind.Local).AddTicks(2123), "Trần Viễn Đại", "shobee-logo.png" },
                    { "iosxiof-mx18-4213-h6d1-420b466e4502", 0, "b9fb3f33-a5aa-4104-bdad-3b9d878860fa", "partner4@gmail.com", true, false, null, "PARTNER4@GMAIL.COM", "PARTNER4@GMAIL.COM", "AQAAAAIAAYagAAAAEPfCXllRxSui6Ckk+Vbri/8n3h7WCtgyMpjJryu4QuqOly7DLSQrpOJWD8qjJMThDw==", "0582753561", false, "26da27de-0dab-4aa5-bafb-2c47bbb2032d", false, "partner4@gmail.com", "Quận 10 - Hồ Chí Minh", new DateTime(2023, 10, 19, 0, 6, 57, 515, DateTimeKind.Local).AddTicks(8979), "Đối Tác Bốn", "shobee-logo.png" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "_partnerID", "categoryID", "description", "discount", "isPublish", "name", "partnerId", "postDate", "price" },
                values: new object[,]
                {
                    { "sandal2", "5dfgsg2-mx18-4213-h6d1-420b466e4502", "sandal", "Giày sandal nữ là một loại giày dép có quai dép đan chéo hoặc buộc xung quanh bàn chân và mắt cá chân. Giày sandal nữ có nhiều loại, từ sandal đế bệt đến sandal đế cao gót, từ sandal quai mảnh đến sandal quai bản to. Giày sandal nữ được làm từ nhiều chất liệu khác nhau, từ da, vải, nhựa đến cao su.", 15, true, "Giày sandal nữ", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3684), 100000.0 },
                    { "sandal3", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", "sandal", "Giày sandal nam là loại giày có quai ngang đan chéo giữa các ngón chân, có thể có quai hậu ở gót hoặc không. Giày sandal nam thường được làm từ chất liệu da, vải, hoặc nhựa. Giày sandal nam có ưu điểm là thoáng mát, dễ đi, và phù hợp với nhiều trang phục khác nhau.", 35, true, "Giày sandal nam", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3701), 110000.0 },
                    { "shirt1", "5215212-mx18-4213-h6d1-420b466e4502", "shirt", "Áo thun nam là một loại trang phục phổ biến dành cho nam giới. Áo được làm từ chất liệu cotton mềm mại, thấm hút mồ hôi tốt, mang lại cảm giác thoải mái cho người mặc. Áo thun nam có nhiều kiểu dáng, màu sắc và họa tiết khác nhau, phù hợp với nhiều phong cách thời trang.", 10, true, "Áo thun nam", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3650), 50000.0 },
                    { "shirt2", "5dfgsg2-mx18-4213-h6d1-420b466e4502", "shirt", "Áo sơ mi nữ là một loại trang phục có cổ, tay áo và hàng nút phía trước, dành cho phụ nữ. Áo sơ mi nữ có thể được làm từ nhiều loại vải khác nhau, bao gồm cotton, lanh, lụa, polyester, v.v. Áo sơ mi nữ thường có màu sắc trung tính như trắng, đen, xanh dương, v.v., nhưng cũng có thể có màu sắc sặc sỡ hơn.", 35, true, "Áo sơ mi nữ", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3678), 70000.0 },
                    { "shirt3", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", "shirt", "Áo sơ mi nam là một loại áo được làm từ vải cotton, linen, hoặc polyester, có cổ áo, tay áo, và khuy áo. Áo sơ mi nam thường được mặc trong các dịp trang trọng, như đi làm, đi dự tiệc, hoặc đi gặp đối tác. Áo sơ mi nam có nhiều kiểu dáng và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang.", 55, true, "Áo sơ mi nam", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3694), 60000.0 },
                    { "shirt4", "iosxiof-mx18-4213-h6d1-420b466e4502", "shirt", "Áo thun nữ là một loại áo được làm từ chất liệu cotton, có kiểu dáng đơn giản, dễ mặc, dễ phối đồ. Áo thun nữ có thể được mặc trong nhiều dịp khác nhau, từ đi chơi, đi làm, đến tập thể thao.", 50, true, "Áo thun nữ", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3710), 80000.0 },
                    { "shoes1", "5215212-mx18-4213-h6d1-420b466e4502", "shoes", "Giày thể thao nam là loại giày được thiết kế chủ yếu để phục vụ cho các hoạt động thể thao, thể dục hoặc các hoạt động ngoài trời. Tuy nhiên, ngày nay, giày thể thao nam cũng được sử dụng phổ biến trong đời sống hàng ngày, bởi sự thoải mái, năng động và cá tính của nó.", 30, true, "Giày thể thao nam", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3674), 120000.0 },
                    { "shoes4", "iosxiof-mx18-4213-h6d1-420b466e4502", "shoes", "Giày thể thao nữ là loại giày được thiết kế dành riêng cho nữ giới, thường được sử dụng để tập thể dục, thể thao, hay đơn giản là để đi lại hàng ngày. Giày thể thao nữ có đặc điểm chung là đế cao su mềm, có độ bám tốt, giúp người sử dụng di chuyển dễ dàng và thoải mái. Ngoài ra, giày thể thao nữ còn có phần thân giày được làm từ nhiều chất liệu khác nhau, như da, vải, hay nhựa, tùy theo sở thích và nhu cầu của người sử dụng.", 30, true, "Giày thể thao nữ", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3735), 130000.0 },
                    { "short1", "5215212-mx18-4213-h6d1-420b466e4502", "short", "Quần short nam là một loại quần dáng ngắn, từ đầu gối trở lên, được thiết kế cho nam giới. Quần short nam thường được làm từ các chất liệu thoáng mát, thấm hút mồ hôi tốt như cotton, kaki, jean,... Quần short nam có nhiều kiểu dáng và mẫu mã khác nhau, phù hợp với nhiều phong cách thời trang.", 20, true, "Quần Short nam", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3669), 30000.0 },
                    { "short4", "iosxiof-mx18-4213-h6d1-420b466e4502", "short", "Quần short nữ là một loại quần ngắn, thường có chiều dài đến đầu gối hoặc trên đầu gối. Quần short nữ có thể được làm từ nhiều chất liệu khác nhau, như cotton, denim, kaki,... Quần short nữ thường được mặc trong những dịp thoải mái, như đi chơi, đi dạo,...", 40, true, "Quần Short nữ", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3732), 60000.0 },
                    { "trouser2", "5dfgsg2-mx18-4213-h6d1-420b466e4502", "trouser", "Quần dài nữ là một loại quần có chiều dài từ mắt cá chân trở lên, được thiết kế dành riêng cho phụ nữ. Quần dài nữ có nhiều kiểu dáng, chất liệu và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang và mục đích sử dụng.", 25, true, "Quần dài nữ", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3681), 50000.0 },
                    { "trouser3", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", "trouser", "Quần dài nam là một loại trang phục bao phủ phần thân dưới của cơ thể, từ thắt lưng đến mắt cá chân. Quần dài nam có nhiều kiểu dáng, chất liệu và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang.", 45, true, "Quần dài nam", null, new DateTime(2023, 10, 19, 0, 6, 57, 516, DateTimeKind.Local).AddTicks(3697), 40000.0 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "5215212-mx18-4213-h6d1-420b466e4502" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "5dfgsg2-mx18-4213-h6d1-420b466e4502" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd" },
                    { "07bf1560-b5ff-4702-a9f1-a64026e570cf", "a79e98b4-d8a6-4640-98eb-5b417ffb2661" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "iosxiof-mx18-4213-h6d1-420b466e4502" }
                });

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "Id", "Name", "productId" },
                values: new object[,]
                {
                    { "blackshirt1", "Đen", "shirt1" },
                    { "blackshirt3", "Đen", "shirt3" },
                    { "blackshoes1", "Đen", "shoes1" },
                    { "blackshort4", "Đen", "short4" },
                    { "blacktrouser3", "Đen", "trouser3" },
                    { "bluesandal2", "Xanh Dương", "sandal2" },
                    { "blueshort1", "Xanh Dương", "short1" },
                    { "blueshort4", "Xanh Dương", "short4" },
                    { "brownsandal3", "Nâu", "sandal3" },
                    { "greensandal2", "Xanh Lá", "sandal2" },
                    { "greensandal3", "Xanh Lá", "sandal3" },
                    { "greenshirt2", "Xanh Lá", "shirt2" },
                    { "greyshirt4", "Xám", "shirt4" },
                    { "pinkshirt4", "Hồng", "shirt4" },
                    { "pinkshoes4", "Hồng", "shoes4" },
                    { "pinktrouser2", "Hồng", "trouser2" },
                    { "purpleshoes4", "Tím", "shoes4" },
                    { "redshort1", "Đỏ", "short1" },
                    { "whiteshirt1", "Trắng", "shirt1" },
                    { "whiteshirt3", "Trắng", "shirt3" },
                    { "whiteshoes1", "Trắng", "shoes1" },
                    { "whitetrouser2", "Trắng", "trouser2" },
                    { "whitetrouser3", "Trắng", "trouser3" },
                    { "yellowshirt2", "Vàng", "shirt2" }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "URL", "productId" },
                values: new object[,]
                {
                    { 1, "shirt1_white.jpg", "shirt1" },
                    { 2, "shirt1_black.jpg", "shirt1" },
                    { 3, "short1_blue.jpg", "short1" },
                    { 4, "short1_red.jpg", "short1" },
                    { 5, "shoes1_black.jpg", "shoes1" },
                    { 6, "shoes1_white.jpg", "shoes1" },
                    { 7, "shirt2_yellow.jpg", "shirt2" },
                    { 8, "shirt2_green.jpg", "shirt2" },
                    { 9, "trouser2_white.jpg", "trouser2" },
                    { 10, "trouser2_pink.jpg", "trouser2" },
                    { 11, "sandal2_blue.jpg", "sandal2" },
                    { 12, "sandal2_green.jpg", "sandal2" },
                    { 13, "shirt3_black.jpg", "shirt3" },
                    { 14, "shirt3_white.jpg", "shirt3" },
                    { 15, "trouser3_black.jpg", "trouser3" },
                    { 16, "trouser3_white.jpg", "trouser3" },
                    { 17, "sandal3_brown.jpg", "sandal3" },
                    { 18, "sandal3_green.jpg", "sandal3" },
                    { 19, "shirt4_grey.jpg", "shirt4" },
                    { 20, "shirt4_pink.jpg", "shirt4" },
                    { 21, "short4_black.jpg", "short4" },
                    { 22, "short4_blue.jpg", "short4" },
                    { 23, "shoes4_purple.jpg", "shoes4" },
                    { 24, "shoes4_pink.jpg", "shoes4" }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "name", "productColorId", "quantity" },
                values: new object[,]
                {
                    { 1, "S", "whiteshirt1", 50.0 },
                    { 2, "M", "whiteshirt1", 40.0 },
                    { 3, "L", "whiteshirt1", 30.0 },
                    { 4, "XL", "whiteshirt1", 20.0 },
                    { 5, "S", "blackshirt1", 20.0 },
                    { 6, "M", "blackshirt1", 30.0 },
                    { 7, "L", "blackshirt1", 40.0 },
                    { 8, "XL", "blackshirt1", 50.0 },
                    { 9, "S", "redshort1", 20.0 },
                    { 10, "M", "redshort1", 30.0 },
                    { 11, "L", "redshort1", 40.0 },
                    { 12, "XL", "redshort1", 50.0 },
                    { 13, "S", "blueshort1", 50.0 },
                    { 14, "M", "blueshort1", 40.0 },
                    { 15, "L", "blueshort1", 30.0 },
                    { 16, "XL", "blueshort1", 20.0 },
                    { 17, "39", "blackshoes1", 30.0 },
                    { 18, "40", "blackshoes1", 40.0 },
                    { 19, "41", "blackshoes1", 50.0 },
                    { 20, "42", "blackshoes1", 50.0 },
                    { 21, "43", "blackshoes1", 40.0 },
                    { 22, "44", "blackshoes1", 30.0 },
                    { 23, "39", "whiteshoes1", 30.0 },
                    { 24, "40", "whiteshoes1", 40.0 },
                    { 25, "41", "whiteshoes1", 50.0 },
                    { 26, "42", "whiteshoes1", 50.0 },
                    { 27, "43", "whiteshoes1", 40.0 },
                    { 28, "44", "whiteshoes1", 30.0 },
                    { 29, "S", "yellowshirt2", 50.0 },
                    { 30, "M", "yellowshirt2", 40.0 },
                    { 31, "L", "yellowshirt2", 30.0 },
                    { 32, "XL", "yellowshirt2", 20.0 },
                    { 33, "S", "greenshirt2", 20.0 },
                    { 34, "M", "greenshirt2", 30.0 },
                    { 35, "L", "greenshirt2", 40.0 },
                    { 36, "XL", "greenshirt2", 50.0 },
                    { 37, "S", "whitetrouser2", 20.0 },
                    { 38, "M", "whitetrouser2", 30.0 },
                    { 39, "L", "whitetrouser2", 40.0 },
                    { 40, "XL", "whitetrouser2", 50.0 },
                    { 41, "S", "pinktrouser2", 50.0 },
                    { 42, "M", "pinktrouser2", 40.0 },
                    { 43, "L", "pinktrouser2", 30.0 },
                    { 44, "XL", "pinktrouser2", 20.0 },
                    { 45, "39", "bluesandal2", 30.0 },
                    { 46, "40", "bluesandal2", 40.0 },
                    { 47, "41", "bluesandal2", 50.0 },
                    { 48, "42", "bluesandal2", 50.0 },
                    { 49, "43", "bluesandal2", 40.0 },
                    { 50, "44", "bluesandal2", 30.0 },
                    { 51, "39", "greensandal2", 30.0 },
                    { 52, "40", "greensandal2", 40.0 },
                    { 53, "41", "greensandal2", 50.0 },
                    { 54, "42", "greensandal2", 50.0 },
                    { 55, "43", "greensandal2", 40.0 },
                    { 56, "44", "greensandal2", 30.0 },
                    { 57, "S", "blackshirt3", 50.0 },
                    { 58, "M", "blackshirt3", 40.0 },
                    { 59, "L", "blackshirt3", 30.0 },
                    { 60, "XL", "blackshirt3", 20.0 },
                    { 61, "S", "whiteshirt3", 20.0 },
                    { 62, "M", "whiteshirt3", 30.0 },
                    { 63, "L", "whiteshirt3", 40.0 },
                    { 64, "XL", "whiteshirt3", 50.0 },
                    { 65, "S", "blacktrouser3", 20.0 },
                    { 66, "M", "blacktrouser3", 30.0 },
                    { 67, "L", "blacktrouser3", 40.0 },
                    { 68, "XL", "blacktrouser3", 50.0 },
                    { 69, "S", "whitetrouser3", 50.0 },
                    { 70, "M", "whitetrouser3", 40.0 },
                    { 71, "L", "whitetrouser3", 30.0 },
                    { 72, "XL", "whitetrouser3", 20.0 },
                    { 73, "39", "brownsandal3", 30.0 },
                    { 74, "40", "brownsandal3", 40.0 },
                    { 75, "41", "brownsandal3", 50.0 },
                    { 76, "42", "brownsandal3", 50.0 },
                    { 77, "43", "brownsandal3", 40.0 },
                    { 78, "44", "brownsandal3", 30.0 },
                    { 79, "39", "greensandal3", 30.0 },
                    { 80, "40", "greensandal3", 40.0 },
                    { 81, "41", "greensandal3", 50.0 },
                    { 82, "42", "greensandal3", 50.0 },
                    { 83, "43", "greensandal3", 40.0 },
                    { 84, "44", "greensandal3", 30.0 },
                    { 85, "S", "greyshirt4", 50.0 },
                    { 86, "M", "greyshirt4", 40.0 },
                    { 87, "L", "greyshirt4", 30.0 },
                    { 88, "XL", "greyshirt4", 20.0 },
                    { 89, "S", "pinkshirt4", 20.0 },
                    { 90, "M", "pinkshirt4", 30.0 },
                    { 91, "L", "pinkshirt4", 40.0 },
                    { 92, "XL", "pinkshirt4", 50.0 },
                    { 93, "S", "blackshort4", 20.0 },
                    { 94, "M", "blackshort4", 30.0 },
                    { 95, "L", "blackshort4", 40.0 },
                    { 96, "XL", "blackshort4", 50.0 },
                    { 97, "S", "blueshort4", 50.0 },
                    { 98, "M", "blueshort4", 40.0 },
                    { 99, "L", "blueshort4", 30.0 },
                    { 100, "XL", "blueshort4", 20.0 },
                    { 101, "39", "purpleshoes4", 30.0 },
                    { 102, "40", "purpleshoes4", 40.0 },
                    { 103, "41", "purpleshoes4", 50.0 },
                    { 104, "42", "purpleshoes4", 50.0 },
                    { 105, "43", "purpleshoes4", 40.0 },
                    { 106, "44", "purpleshoes4", 30.0 },
                    { 107, "39", "pinkshoes4", 30.0 },
                    { 108, "40", "pinkshoes4", 40.0 },
                    { 109, "41", "pinkshoes4", 50.0 },
                    { 110, "42", "pinkshoes4", 50.0 },
                    { 111, "43", "pinkshoes4", 40.0 },
                    { 112, "44", "pinkshoes4", 30.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserId",
                table: "Bill",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_voucherID",
                table: "Bill",
                column: "voucherID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOD_billID",
                table: "DetailOD",
                column: "billID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailOD_productId",
                table: "DetailOD",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsModel_userId",
                table: "NewsModel",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_partnerId",
                table: "Product",
                column: "partnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_productId",
                table: "ProductColor",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_productId",
                table: "ProductComment",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_productId",
                table: "ProductImage",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_productColorId",
                table: "ProductSize",
                column: "productColorId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailOD");

            migrationBuilder.DropTable(
                name: "NewsModel");

            migrationBuilder.DropTable(
                name: "ProductComment");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Partner");
        }
    }
}
