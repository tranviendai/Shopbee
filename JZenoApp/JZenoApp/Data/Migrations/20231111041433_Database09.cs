using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 14, 32, 588, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "f6d66e46-ce9f-40c5-809d-54ac8e0d4591", "AQAAAAIAAYagAAAAEFYSKtaztFpVn6gxXA1L+75CA1D0BDSxxAX1y7QiUWxcQmG34yIgxAHtdyVu97ebeg==", "37fd7ba0-3f30-44b2-b44d-f21ef8a9c003", new DateTime(2023, 11, 11, 11, 14, 32, 241, DateTimeKind.Local).AddTicks(2156), "5215212-mx18-4213-h6d1-420b466e4502" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "6a1a99c6-81b0-4931-a607-4392052c95e3", "AQAAAAIAAYagAAAAEJNSLLoNxVUqgCe5GfBwcNq6jKDxl6SJC+iJ/O9KvVUhYmHldHN51+FzMgLHdC9ZLw==", "a3e8ef56-6e2f-4d7f-a209-4ca534908664", new DateTime(2023, 11, 11, 11, 14, 32, 347, DateTimeKind.Local).AddTicks(8650), "5dfgsg2-mx18-4213-h6d1-420b466e4502" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "aa997035-d8da-4953-a6ce-f4be7a600f6f", "AQAAAAIAAYagAAAAELrRE9AM8Nduc0lBtr4lUcliX1RJGsQVaiIj1D7FYcloo4fiaX4rfG/qvZFUbgPa6g==", "4427ba90-352a-4324-900e-5519598ebb4f", new DateTime(2023, 11, 11, 11, 14, 32, 464, DateTimeKind.Local).AddTicks(5496), "9f15d62-mx18-4213-h6d1-fdsafdsafdsd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "f08f801b-2d7c-4817-814b-dd75cb8a1edc", "AQAAAAIAAYagAAAAEMbxXly+hqEFVWmyTEkfcTev8uGV7+PtAkTziqH0lW8WzE1P4zgk1RYYpIlhFWY9Fw==", "fa7e8833-ca13-40a1-a2e9-53a3b9d3cdc6", new DateTime(2023, 11, 11, 11, 14, 32, 133, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "86ae0bcf-da52-4a83-aa09-ddb2d294cd49", "AQAAAAIAAYagAAAAECVDzhNO02yFP9aozzBqib2J62uhni4w7Fe8dph4XFvw9JX14wSnPQp4MbWciJMC/Q==", "ae7b6f7e-b429-47d5-9568-3496674a9bb5", new DateTime(2023, 11, 11, 11, 14, 32, 587, DateTimeKind.Local).AddTicks(7801), "iosxiof-mx18-4213-h6d1-420b466e4502" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 11, 5, 22, 660, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "1e8d4f2f-6360-4dba-a044-ffce771c3862", "AQAAAAIAAYagAAAAEDjcVufxKI6NKDq9YgujdsDd/CkrSjd5iLxB9F0XooP+an69C/XigpcySlSOa/mOzw==", "5581c655-66ab-4818-8968-6c62b78f6847", new DateTime(2023, 11, 11, 11, 5, 22, 318, DateTimeKind.Local).AddTicks(8332), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "3fd63018-616a-4a51-8b88-6962caed4dad", "AQAAAAIAAYagAAAAEDvHWvxyMnlAzGEVIB73/493g4WKLnDaoZ5ZIMXCs6foNw1Hr8ADmKZOLY4SU2Wn5Q==", "39a38b64-2207-4f55-b28d-989041cf4032", new DateTime(2023, 11, 11, 11, 5, 22, 432, DateTimeKind.Local).AddTicks(1030), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "06e6b4c5-058b-4d97-8e7e-d394a3e4d50b", "AQAAAAIAAYagAAAAEEvAZj/rq4wxsIpnwKI3qxE5bvfon4SOAmD+/LixD98JHxqlHmyESELtVNobNdO7kQ==", "d4422e60-5181-42c2-a307-96c66c12bfeb", new DateTime(2023, 11, 11, 11, 5, 22, 543, DateTimeKind.Local).AddTicks(5730), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "4c7627ea-fdc2-4c12-b99c-cd86760cf488", "AQAAAAIAAYagAAAAEAOd4WzqWqYU7Q7px6RPmw/ulYGD8TJQFh7jNATImNhxJ1peK7y9jN/8GqvxBnx67g==", "b2241189-ceab-4009-9110-6ee893242198", new DateTime(2023, 11, 11, 11, 5, 22, 203, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "f720c785-6569-4117-9a19-8caeab3b8cc1", "AQAAAAIAAYagAAAAEB02fPcCGbG1bP6TIntsPrwagCHHsQEYUncWOQN22oeyTOnu/5ZyF7r8NADqfMrsFg==", "1659093f-ef88-4c89-9d41-6e7ed6a1fdc3", new DateTime(2023, 11, 11, 11, 5, 22, 659, DateTimeKind.Local).AddTicks(9165), null });
        }
    }
}
