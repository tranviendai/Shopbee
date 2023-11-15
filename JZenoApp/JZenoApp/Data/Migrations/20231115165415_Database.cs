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
                    name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
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
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Voucher",
                columns: table => new
                {
                    voucherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    discount = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    postDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isPublish = table.Column<bool>(type: "bit", nullable: true),
                    sold = table.Column<int>(type: "int", nullable: true),
                    categoryID = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    partnerID = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        name: "FK_Product_Partner_partnerID",
                        column: x => x.partnerID,
                        principalTable: "Partner",
                        principalColumn: "partnerId");
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
                    partnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Partner_partnerId",
                        column: x => x.partnerId,
                        principalTable: "Partner",
                        principalColumn: "partnerId");
                });

            migrationBuilder.CreateTable(
                name: "VoucherPartner",
                columns: table => new
                {
                    vID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    partnerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherPartner", x => x.vID);
                    table.ForeignKey(
                        name: "FK_VoucherPartner_Partner_partnerId",
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
                name: "Bill",
                columns: table => new
                {
                    billID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    shipPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    payment = table.Column<bool>(type: "bit", nullable: true),
                    deliveryForm = table.Column<bool>(type: "bit", nullable: true),
                    voucherID = table.Column<int>(type: "int", nullable: true),
                    note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    billStatic = table.Column<int>(type: "int", nullable: true),
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
                name: "Chat",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    nameActive = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    senderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    receiverId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Chat_User_receiverId",
                        column: x => x.receiverId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chat_User_senderId",
                        column: x => x.senderId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NewsModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "ProductComment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    evaluate = table.Column<int>(type: "int", nullable: true),
                    isComment = table.Column<bool>(type: "bit", nullable: true),
                    dateCmt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_ProductComment_User_userId",
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
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
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
                    size = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    color = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    detailStatic = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    totalPrice = table.Column<double>(type: "float", nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: true),
                    productId = table.Column<string>(type: "nvarchar(15)", nullable: true)
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
                        name: "FK_DetailOD_Product_productId",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChatDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chatId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    sendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChatDetail_Chat_chatId",
                        column: x => x.chatId,
                        principalTable: "Chat",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "icon", "name" },
                values: new object[,]
                {
                    { "camera", "camera.png", "Camera" },
                    { "computer", "computer.png", "Computer" },
                    { "phone", "phone.png", "Phone" },
                    { "sandal", "sandal.png", "Sandal" },
                    { "shirt", "shirt.png", "Shirt" },
                    { "shoes", "shoes.png", "Shoes" },
                    { "short", "short.png", "Short" },
                    { "trouser", "trousers.png", "Trouser" },
                    { "watch", "watch.png", "Watch" }
                });

            migrationBuilder.InsertData(
                table: "Partner",
                columns: new[] { "partnerId", "address", "dateCreated", "description", "image", "isActive", "name" },
                values: new object[,]
                {
                    { "5215212-mx18-4213-h6d1-420b466e4502", "Hồ Chí Minh", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1375), "Chưa Cập Nhật", "default_avt.png", true, "Cửa Hàng A" },
                    { "5dfgsg2-mx18-4213-h6d1-420b466e4502", "Hà Nội", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1392), "Chưa Cập Nhật", "default_avt.png", true, "Cửa Hàng B" },
                    { "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", "Đà Nẵng", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1409), "Chưa Cập Nhật", "default_avt.png", true, "Cửa Hàng C" },
                    { "iosxiof-mx18-4213-h6d1-420b466e4502", "Nam Định", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1412), "Chưa Cập Nhật", "default_avt.png", true, "Cửa Hàng D" }
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "address", "dateCreated", "fullName", "image", "partnerId" },
                values: new object[] { "a79e98b4-d8a6-4640-98eb-5b417ffb2661", 0, "20408f6c-8190-49aa-84df-bf29efa80a33", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEIVXoxfVLa25bU92weFkatkfhboY6WrwYw6A+LH5yLFeIWDGQAXZ/0wrguxrgNMzpQ==", "0582072743", false, "01fc54f7-8ded-440d-ab37-7aa1f3053aff", false, "admin@gmail.com", "Tắc Vân - Cà Mau", new DateTime(2023, 11, 15, 23, 54, 15, 261, DateTimeKind.Local).AddTicks(2129), "Trần Viễn Đại", "shobee-logo.png", null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "categoryID", "description", "discount", "isPublish", "name", "partnerID", "postDate", "price", "sold" },
                values: new object[,]
                {
                    { "camera1", "camera", "Máy ảnh là một thiết bị dùng để ghi lại hình ảnh của thế giới xung quanh. Máy ảnh có thể được chia thành hai loại chính là máy ảnh phim và máy ảnh kỹ thuật số. Máy ảnh phim sử dụng phim ảnh để ghi lại hình ảnh. Phim ảnh là một loại vật liệu nhạy sáng, khi ánh sáng đi qua ống kính sẽ được ghi lại trên phim. Sau đó, phim ảnh cần được mang đi tráng rửa để cho ra một bức ảnh. Máy ảnh kỹ thuật số sử dụng cảm biến điện tử để ghi lại hình ảnh. Cảm biến điện tử sẽ chuyển đổi ánh sáng thành các tín hiệu điện, sau đó các tín hiệu điện này sẽ được lưu trữ dưới dạng file ảnh kỹ thuật số. Máy ảnh có thể được sử dụng để ghi lại những khoảnh khắc quan trọng trong cuộc sống, để lưu giữ những kỷ niệm đẹp, hoặc để thể hiện khả năng sáng tạo của người chụp.", 40, true, "Máy ảnh", "5215212-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1636), 5000000.0, null },
                    { "computer4", "computer", "Máy tính là một thiết bị điện tử có thể thực hiện các phép tính và xử lý thông tin theo một chương trình được viết sẵn. Máy tính có thể được sử dụng cho nhiều mục đích khác nhau, bao gồm tính toán, soạn thảo văn bản, chơi game, nghe nhạc, xem phim, v.v.", 20, true, "Máy tính", "iosxiof-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1691), 10000000.0, null },
                    { "phone2", "phone", "Điện thoại thông minh (smartphone) là một loại thiết bị di động kết hợp điện thoại di động, máy tính cá nhân và các chức năng điện toán di động khác vào một thiết bị. Smartphone có thể thực hiện các chức năng cơ bản của điện thoại di động, chẳng hạn như thực hiện và nhận cuộc gọi, gửi và nhận tin nhắn văn bản, và truy cập Internet. Ngoài ra, smartphone còn có thể chạy các ứng dụng, chơi game, và thực hiện nhiều tác vụ khác.", 5, true, "Điện thoại", "5dfgsg2-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1656), 7500000.0, null },
                    { "sandal2", "sandal", "Giày sandal nữ là một loại giày dép có quai dép đan chéo hoặc buộc xung quanh bàn chân và mắt cá chân. Giày sandal nữ có nhiều loại, từ sandal đế bệt đến sandal đế cao gót, từ sandal quai mảnh đến sandal quai bản to. Giày sandal nữ được làm từ nhiều chất liệu khác nhau, từ da, vải, nhựa đến cao su.", 15, true, "Giày sandal nữ", "5dfgsg2-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1651), 100000.0, null },
                    { "sandal3", "sandal", "Giày sandal nam là loại giày có quai ngang đan chéo giữa các ngón chân, có thể có quai hậu ở gót hoặc không. Giày sandal nam thường được làm từ chất liệu da, vải, hoặc nhựa. Giày sandal nam có ưu điểm là thoáng mát, dễ đi, và phù hợp với nhiều trang phục khác nhau.", 35, true, "Giày sandal nam", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1671), 110000.0, null },
                    { "shirt1", "shirt", "Áo thun nam là một loại trang phục phổ biến dành cho nam giới. Áo được làm từ chất liệu cotton mềm mại, thấm hút mồ hôi tốt, mang lại cảm giác thoải mái cho người mặc. Áo thun nam có nhiều kiểu dáng, màu sắc và họa tiết khác nhau, phù hợp với nhiều phong cách thời trang.", 10, true, "Áo thun nam", "5215212-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1620), 50000.0, null },
                    { "shirt2", "shirt", "Áo sơ mi nữ là một loại trang phục có cổ, tay áo và hàng nút phía trước, dành cho phụ nữ. Áo sơ mi nữ có thể được làm từ nhiều loại vải khác nhau, bao gồm cotton, lanh, lụa, polyester, v.v. Áo sơ mi nữ thường có màu sắc trung tính như trắng, đen, xanh dương, v.v., nhưng cũng có thể có màu sắc sặc sỡ hơn.", 35, true, "Áo sơ mi nữ", "5dfgsg2-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1642), 70000.0, null },
                    { "shirt3", "shirt", "Áo sơ mi nam là một loại áo được làm từ vải cotton, linen, hoặc polyester, có cổ áo, tay áo, và khuy áo. Áo sơ mi nam thường được mặc trong các dịp trang trọng, như đi làm, đi dự tiệc, hoặc đi gặp đối tác. Áo sơ mi nam có nhiều kiểu dáng và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang.", 55, true, "Áo sơ mi nam", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1660), 60000.0, null },
                    { "shirt4", "shirt", "Áo thun nữ là một loại áo được làm từ chất liệu cotton, có kiểu dáng đơn giản, dễ mặc, dễ phối đồ. Áo thun nữ có thể được mặc trong nhiều dịp khác nhau, từ đi chơi, đi làm, đến tập thể thao.", 50, true, "Áo thun nữ", "iosxiof-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1679), 80000.0, null },
                    { "shoes1", "shoes", "Giày thể thao nam là loại giày được thiết kế chủ yếu để phục vụ cho các hoạt động thể thao, thể dục hoặc các hoạt động ngoài trời. Tuy nhiên, ngày nay, giày thể thao nam cũng được sử dụng phổ biến trong đời sống hàng ngày, bởi sự thoải mái, năng động và cá tính của nó.", 30, true, "Giày thể thao nam", "5215212-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1633), 120000.0, null },
                    { "shoes4", "shoes", "Giày thể thao nữ là loại giày được thiết kế dành riêng cho nữ giới, thường được sử dụng để tập thể dục, thể thao, hay đơn giản là để đi lại hàng ngày. Giày thể thao nữ có đặc điểm chung là đế cao su mềm, có độ bám tốt, giúp người sử dụng di chuyển dễ dàng và thoải mái. Ngoài ra, giày thể thao nữ còn có phần thân giày được làm từ nhiều chất liệu khác nhau, như da, vải, hay nhựa, tùy theo sở thích và nhu cầu của người sử dụng.", 30, true, "Giày thể thao nữ", "iosxiof-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1686), 130000.0, null },
                    { "short1", "short", "Quần short nam là một loại quần dáng ngắn, từ đầu gối trở lên, được thiết kế cho nam giới. Quần short nam thường được làm từ các chất liệu thoáng mát, thấm hút mồ hôi tốt như cotton, kaki, jean,... Quần short nam có nhiều kiểu dáng và mẫu mã khác nhau, phù hợp với nhiều phong cách thời trang.", 20, true, "Quần Short nam", "5215212-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1626), 30000.0, null },
                    { "short4", "short", "Quần short nữ là một loại quần ngắn, thường có chiều dài đến đầu gối hoặc trên đầu gối. Quần short nữ có thể được làm từ nhiều chất liệu khác nhau, như cotton, denim, kaki,... Quần short nữ thường được mặc trong những dịp thoải mái, như đi chơi, đi dạo,...", 40, true, "Quần Short nữ", "iosxiof-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1683), 60000.0, null },
                    { "trouser2", "trouser", "Quần dài nữ là một loại quần có chiều dài từ mắt cá chân trở lên, được thiết kế dành riêng cho phụ nữ. Quần dài nữ có nhiều kiểu dáng, chất liệu và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang và mục đích sử dụng.", 25, true, "Quần dài nữ", "5dfgsg2-mx18-4213-h6d1-420b466e4502", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1648), 50000.0, null },
                    { "trouser3", "trouser", "Quần dài nam là một loại trang phục bao phủ phần thân dưới của cơ thể, từ thắt lưng đến mắt cá chân. Quần dài nam có nhiều kiểu dáng, chất liệu và màu sắc khác nhau, phù hợp với nhiều phong cách thời trang.", 45, true, "Quần dài nam", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1665), 40000.0, null },
                    { "watch3", "watch", "Đồng hồ đeo tay là một chiếc đồng hồ được thiết kế để đeo trên cổ tay. Nó được điều khiển bởi một bộ máy cơ học hoặc điện tử và hiển thị thời gian bằng các kim hoặc màn hình điện tử. Đồng hồ đeo tay là một vật dụng thiết yếu trong cuộc sống hiện đại, được sử dụng để theo dõi thời gian, quản lý công việc và thể hiện phong cách cá nhân.", 25, true, "Đồng hồ", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", new DateTime(2023, 11, 15, 23, 54, 15, 627, DateTimeKind.Local).AddTicks(1675), 500000.0, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "address", "dateCreated", "fullName", "image", "partnerId" },
                values: new object[,]
                {
                    { "5215212-mx18-4213-h6d1-420b466e4502", 0, "490c9480-691a-45a1-94ae-1d2b3776bdbf", "partner1@gmail.com", true, false, null, "PARTNER1@GMAIL.COM", "PARTNER1@GMAIL.COM", "AQAAAAIAAYagAAAAEDAUzP02CB5RN+go9ongTHQGYUSabq+1F833yAtBov5DSv5S6SoJznu9oxw8Su8ifA==", "0582012351", false, "62e1413d-79b3-4e33-bcc2-3cd295dd06d7", false, "partner1@gmail.com", "Bình Chánh - Hồ Chí Minh", new DateTime(2023, 11, 15, 23, 54, 15, 351, DateTimeKind.Local).AddTicks(866), "Đối Tác Một", "shobee-logo.png", "5215212-mx18-4213-h6d1-420b466e4502" },
                    { "5dfgsg2-mx18-4213-h6d1-420b466e4502", 0, "6fc7c673-7887-4889-8800-ec1ff4828c40", "partner2@gmail.com", true, false, null, "PARTNER2@GMAIL.COM", "PARTNER2@GMAIL.COM", "AQAAAAIAAYagAAAAEBSbe8DBUaeTodgkOj2Qzq3eqS30k5DHFFZZ/7+b9ZKBV5j3hewzKzi8GQ5fPaquhg==", "0582015681", false, "9b7ba0bc-a5ab-437f-8380-959180b01f47", false, "partner2@gmail.com", "Trảng Bom - Đồng Nai", new DateTime(2023, 11, 15, 23, 54, 15, 442, DateTimeKind.Local).AddTicks(6247), "Đối Tác Hai", "shobee-logo.png", "5dfgsg2-mx18-4213-h6d1-420b466e4502" },
                    { "9f15d62-mx18-4213-h6d1-fdsafdsafdsd", 0, "f2c2f4ed-67b1-4edb-bac7-cc06ef84ac2f", "partner3@gmail.com", true, false, null, "PARTNER3@GMAIL.COM", "PARTNER3@GMAIL.COM", "AQAAAAIAAYagAAAAECOCixk0SOR7L49q/1zmVAZSZWIZKIgz8T2wpfI0UG9WHMD8YWbcExTuLFbDv0lFIQ==", "0582014561", false, "283e3165-55f1-449b-a68d-8989fd7ae91d", false, "partner3@gmail.com", "Quận 1 - Hồ Chí Minh", new DateTime(2023, 11, 15, 23, 54, 15, 533, DateTimeKind.Local).AddTicks(1177), "Đối Tác Ba", "shobee-logo.png", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd" },
                    { "iosxiof-mx18-4213-h6d1-420b466e4502", 0, "680b15da-d2b9-4507-8d7f-0b16c4ec0a1a", "partner4@gmail.com", true, false, null, "PARTNER4@GMAIL.COM", "PARTNER4@GMAIL.COM", "AQAAAAIAAYagAAAAEOseTosvQnRG9iOpaYbqb2hIKVCbhDPodymLOQ3KmJCWCNtYVe0TbuK4TfpynHyQig==", "0582753561", false, "b2f7e0b9-90a8-4fff-9826-540306346a54", false, "partner4@gmail.com", "Quận 10 - Hồ Chí Minh", new DateTime(2023, 11, 15, 23, 54, 15, 626, DateTimeKind.Local).AddTicks(7607), "Đối Tác Bốn", "shobee-logo.png", "iosxiof-mx18-4213-h6d1-420b466e4502" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "07bf1560-b5ff-4702-a9f1-a64026e570cf", "a79e98b4-d8a6-4640-98eb-5b417ffb2661" });

            migrationBuilder.InsertData(
                table: "ProductColor",
                columns: new[] { "Id", "Name", "productId" },
                values: new object[,]
                {
                    { "blackcamera1", "Đen", "camera1" },
                    { "blackcomputer4", "Đen", "computer4" },
                    { "blackshirt1", "Đen", "shirt1" },
                    { "blackshirt3", "Đen", "shirt3" },
                    { "blackshoes1", "Đen", "shoes1" },
                    { "blackshort4", "Đen", "short4" },
                    { "blacktrouser3", "Đen", "trouser3" },
                    { "bluecomputer4", "Xanh Dương", "computer4" },
                    { "bluephone2", "Xanh Dương", "phone2" },
                    { "bluesandal2", "Xanh Dương", "sandal2" },
                    { "blueshort1", "Xanh Dương", "short1" },
                    { "blueshort4", "Xanh Dương", "short4" },
                    { "brownsandal3", "Nâu", "sandal3" },
                    { "greensandal2", "Xanh Lá", "sandal2" },
                    { "greensandal3", "Xanh Lá", "sandal3" },
                    { "greenshirt2", "Xanh Lá", "shirt2" },
                    { "greyshirt4", "Xám", "shirt4" },
                    { "naturalphone2", "Tự Nhiên", "phone2" },
                    { "pinkshirt4", "Hồng", "shirt4" },
                    { "pinkshoes4", "Hồng", "shoes4" },
                    { "pinktrouser2", "Hồng", "trouser2" },
                    { "pinkwatch3", "Hồng", "watch3" },
                    { "purpleshoes4", "Tím", "shoes4" },
                    { "redshort1", "Đỏ", "short1" },
                    { "whitecamera1", "Trắng", "camera1" },
                    { "whiteshirt1", "Trắng", "shirt1" },
                    { "whiteshirt3", "Trắng", "shirt3" },
                    { "whiteshoes1", "Trắng", "shoes1" },
                    { "whitetrouser2", "Trắng", "trouser2" },
                    { "whitetrouser3", "Trắng", "trouser3" },
                    { "whitewatch3", "Trắng", "watch3" },
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
                    { 7, "camera1_black.jpg", "camera1" },
                    { 8, "camera1_white.jpg", "camera1" },
                    { 9, "shirt2_yellow.jpg", "shirt2" },
                    { 10, "shirt2_green.jpg", "shirt2" },
                    { 11, "trouser2_white.jpg", "trouser2" },
                    { 12, "trouser2_pink.jpg", "trouser2" },
                    { 13, "sandal2_blue.jpg", "sandal2" },
                    { 14, "sandal2_green.jpg", "sandal2" },
                    { 15, "phone2_blue.jpg", "phone2" },
                    { 16, "phone2_natural.jpg", "phone2" },
                    { 17, "shirt3_black.jpg", "shirt3" },
                    { 18, "shirt3_white.jpg", "shirt3" },
                    { 19, "trouser3_black.jpg", "trouser3" },
                    { 20, "trouser3_white.jpg", "trouser3" },
                    { 21, "sandal3_brown.jpg", "sandal3" },
                    { 22, "sandal3_green.jpg", "sandal3" },
                    { 23, "watch3_pink.jpg", "watch3" },
                    { 24, "watch3_white.jpg", "watch3" },
                    { 25, "shirt4_grey.jpg", "shirt4" },
                    { 26, "shirt4_pink.jpg", "shirt4" },
                    { 27, "short4_black.jpg", "short4" },
                    { 28, "short4_blue.jpg", "short4" },
                    { 29, "shoes4_purple.jpg", "shoes4" },
                    { 30, "shoes4_pink.jpg", "shoes4" },
                    { 31, "computer4_blue.jpg", "computer4" },
                    { 32, "computer4_black.jpg", "computer4" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "5215212-mx18-4213-h6d1-420b466e4502" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "5dfgsg2-mx18-4213-h6d1-420b466e4502" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "9f15d62-mx18-4213-h6d1-fdsafdsafdsd" },
                    { "5h45cxf3-mx18-4acb-h6d1-420b466e4502", "iosxiof-mx18-4213-h6d1-420b466e4502" }
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
                    { 112, "44", "pinkshoes4", 30.0 },
                    { 113, "64GB", "blackcamera1", 30.0 },
                    { 114, "128GB", "blackcamera1", 20.0 },
                    { 115, "8RAM-128GB", "blackcomputer4", 10.0 },
                    { 116, "8RAM-128GB", "bluecomputer4", 30.0 },
                    { 117, "64GB", "bluephone2", 30.0 },
                    { 118, "128GB", "bluephone2", 30.0 },
                    { 119, "64GB", "naturalphone2", 30.0 },
                    { 120, "128GB", "naturalphone2", 30.0 },
                    { 121, "64GB", "whitecamera1", 30.0 },
                    { 122, "128GB", "whitecamera1", 30.0 },
                    { 123, "64GB", "whitewatch3", 30.0 },
                    { 124, "64GB", "pinkwatch3", 30.0 }
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
                name: "IX_Chat_receiverId",
                table: "Chat",
                column: "receiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_senderId",
                table: "Chat",
                column: "senderId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatDetail_chatId",
                table: "ChatDetail",
                column: "chatId");

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
                name: "IX_Product_partnerID",
                table: "Product",
                column: "partnerID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_productId",
                table: "ProductColor",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_productId",
                table: "ProductComment",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_userId",
                table: "ProductComment",
                column: "userId");

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
                name: "IX_User_partnerId",
                table: "User",
                column: "partnerId",
                unique: true,
                filter: "[partnerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_name",
                table: "Voucher",
                column: "name",
                unique: true,
                filter: "[name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherPartner_partnerId",
                table: "VoucherPartner",
                column: "partnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatDetail");

            migrationBuilder.DropTable(
                name: "DetailOD");

            migrationBuilder.DropTable(
                name: "NewsModel");

            migrationBuilder.DropTable(
                name: "ProductComment");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductSize");

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
                name: "VoucherPartner");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "ProductColor");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Partner");
        }
    }
}
