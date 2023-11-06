using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "detailStatic",
                table: "DetailOD",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detailStatic",
                table: "DetailOD");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 10, 31, 18, 50, 1, 144, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "b9b83c11-4210-4d31-8a04-6bb178a256da", "AQAAAAIAAYagAAAAEBK5you2c1mHTvsn4BM/ESFUrFXQ9iroBbbG4tG96tup706CUtsKnPoze+Upx7iPxA==", "f561aede-fb77-48d2-9c7a-8b0f2540a1b9", new DateTime(2023, 10, 31, 18, 50, 0, 733, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "b8d557ef-8994-441a-8273-fd46cbafde7c", "AQAAAAIAAYagAAAAELocU8YyS3uE53eTwg+PFlNjimt/cdVwsuyxu08GQRTNx+JsNNy0hEJbQthSeJLNqQ==", "c37257a8-d9b5-486f-8c10-6498ec4de52a", new DateTime(2023, 10, 31, 18, 50, 0, 869, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "e383677a-f019-4d03-83d5-903c7432f765", "AQAAAAIAAYagAAAAELCLJ2z1zYm0+eHVj4a3IezXFXmRYDOxSmqqMtwSGbSkb+MmUo+6C9IlmzseSFe8rg==", "bac3e185-8711-4b90-9896-6d94a24456ec", new DateTime(2023, 10, 31, 18, 50, 1, 10, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "c9f6e973-7a9c-4394-a5ad-8027bd6c5ac5", "AQAAAAIAAYagAAAAEAi89Gsbh5V4109CyB854MG+0GB18Dr7gu0Use5iD3oq7+MfP8VIVAK88YleAUm0iA==", "061fe8ce-d11c-4e95-bbfb-470fc61020bd", new DateTime(2023, 10, 31, 18, 50, 0, 600, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "6b7bac02-aed3-453c-b371-f35e6a4c4b47", "AQAAAAIAAYagAAAAENc4sIN8eWjyhgIWqpHQko4QAJM4gZhs14Qf94c0l6r3W0rYIZagynBfr9aTbY9G5w==", "2fd15770-e710-4506-a339-9184fbcceabd", new DateTime(2023, 10, 31, 18, 50, 1, 143, DateTimeKind.Local).AddTicks(7418) });
        }
    }
}
