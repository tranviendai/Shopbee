using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Bill",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 20, 15, 26, 539, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "7e992132-fad5-4542-bb27-4f358f6f9583", "AQAAAAIAAYagAAAAEFn53OhCfxWnABonyO7OGtxv6sE6p2TZVj+W6LJ+ryKhMhrryi04HuqhJ8/QxPch4A==", "f4f6dcf3-f6c4-4d7a-a31d-b64584b573c2", new DateTime(2023, 11, 5, 20, 15, 26, 194, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "051bfb47-5de1-415e-a704-14ba7cc82aed", "AQAAAAIAAYagAAAAEMYr+YDC2rijloMhg0PgCzjYO3i9SQ2iGsSjBPLnwaGqgS9p7Kiz0GPHiBMzD1KaNQ==", "9ed24463-0a62-4cfa-b1be-80d9c70877d0", new DateTime(2023, 11, 5, 20, 15, 26, 309, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "fab35a0c-fc49-4542-a54f-cec703179e09", "AQAAAAIAAYagAAAAEJdH6Mu1OXBc+jmglHFdzH5zAvbX1am9gdJcF06U3GTf5HQkkfMiWZFeRqGWG280wQ==", "055bce13-e508-42e3-a173-ae1e0560b2b7", new DateTime(2023, 11, 5, 20, 15, 26, 425, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "6ccd9649-0bcd-47c2-9dc9-3b2deb4d199e", "AQAAAAIAAYagAAAAEDoJFjNusKTaqfPXbg8qyTIkGkiH/9lfh2w0+PaUYJPUkwwa4BIqtpNJFWYddb8o9w==", "26b740d6-7127-4770-821b-47ca92c8b23b", new DateTime(2023, 11, 5, 20, 15, 26, 77, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "bdc71622-17c9-4fe6-ae50-f270d6b8d321", "AQAAAAIAAYagAAAAEH2aiz+arMbZUSSaCQJYS6EUr5YhdsiWKSN9szTDLl1VSGMADxtGd0HsNTwXSYYIaQ==", "8b41236e-de27-425d-82de-d592e06bfd07", new DateTime(2023, 11, 5, 20, 15, 26, 538, DateTimeKind.Local).AddTicks(9704) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "Bill");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "46d0e011-aa19-4da4-925d-e2a37ed32c6c", "AQAAAAIAAYagAAAAEHoFpe0/VOmUDLbi971rtX1mO9oo2amlnwEDmf+sPZpZQje8HdnP3MfsAVe62KSrYg==", "467c2f9b-8137-4f59-bbc0-38c87f1ec99f", new DateTime(2023, 11, 5, 17, 26, 34, 661, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "e77bc643-6ef8-46ec-b152-6b623a60d01f", "AQAAAAIAAYagAAAAEFQ3n8tGipvk+CMhQ7idpPdX4X2Y+EMJ2LhOo8nGcvxWMBjeA6mjtt8e1c0tS0kRCQ==", "19c404de-8489-41fa-8764-38a3731f665f", new DateTime(2023, 11, 5, 17, 26, 34, 756, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "634c37b9-b077-4520-984d-fb9e206d8dc0", "AQAAAAIAAYagAAAAEOfcPY+7++6f+O1XUPNi8/J+YOiWu7IlItlZmCP1O1GxPPc9OGHw799j8BrgzfgOCg==", "87a2d6e9-fbb3-4a8d-8a91-20b62fcd41e5", new DateTime(2023, 11, 5, 17, 26, 34, 850, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "04a25bfc-9a39-4762-bab7-9604b99ef512", "AQAAAAIAAYagAAAAELg1Fcgph4yEU8XtcGui8t8KSrXOuM36qz1y3bLLtZfhgttAb7ZySOfW+vLrmMx8gQ==", "9c89b2b3-b7d8-44dd-a166-414d97377575", new DateTime(2023, 11, 5, 17, 26, 34, 573, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "3f127d42-7ad5-4f0d-807b-01af775dc1b4", "AQAAAAIAAYagAAAAEHod2+6AfyNd0AolNEcol+hhZWOWp7suHw7SFVJG4aV75AygBf0tWgfR8z7nM232Xg==", "d5d3923e-aef0-48f6-ba96-86173f6c66c4", new DateTime(2023, 11, 5, 17, 26, 34, 942, DateTimeKind.Local).AddTicks(3647) });
        }
    }
}
