using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partner_User_Id",
                table: "Partner");

            migrationBuilder.DropIndex(
                name: "IX_Partner_Id",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Partner");

            migrationBuilder.AddColumn<string>(
                name: "partnerId",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "4c7627ea-fdc2-4c12-b99c-cd86760cf488", "AQAAAAIAAYagAAAAEAOd4WzqWqYU7Q7px6RPmw/ulYGD8TJQFh7jNATImNhxJ1peK7y9jN/8GqvxBnx67g==", "b2241189-ceab-4009-9110-6ee893242198", new DateTime(2023, 11, 11, 11, 5, 22, 203, DateTimeKind.Local).AddTicks(2548), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "f720c785-6569-4117-9a19-8caeab3b8cc1", "AQAAAAIAAYagAAAAEB02fPcCGbG1bP6TIntsPrwagCHHsQEYUncWOQN22oeyTOnu/5ZyF7r8NADqfMrsFg==", "1659093f-ef88-4c89-9d41-6e7ed6a1fdc3", new DateTime(2023, 11, 11, 11, 5, 22, 659, DateTimeKind.Local).AddTicks(9165), null });

            migrationBuilder.CreateIndex(
                name: "IX_User_partnerId",
                table: "User",
                column: "partnerId",
                unique: true,
                filter: "[partnerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Partner_partnerId",
                table: "User",
                column: "partnerId",
                principalTable: "Partner",
                principalColumn: "partnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Partner_partnerId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_partnerId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "partnerId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Partner",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Partner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3635), null });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3664), null });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3678), null });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3680), null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "b6a7c0b0-442d-4164-baca-d74e0994cca8", "AQAAAAIAAYagAAAAEGo/e1brYBIrUWlwCcLv4XIOz6QAQjwUSCeAEnaPA1U3GWQ5lMxSUWHIiZRzUcyVgw==", "6e8ae938-a75c-4d55-bbf2-384c11cfa3f0", new DateTime(2023, 11, 11, 10, 51, 7, 835, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "8903dc34-6281-4df4-8364-f6be36fb1792", "AQAAAAIAAYagAAAAEKS02UoD0Q22jtNPeVR6Yr76CETC52WO1nDd2u6Y3cYWDLyDgdYMIWGPyasNbRUZ2w==", "61960327-bd2d-4e58-9df8-44f41cbd1b28", new DateTime(2023, 11, 11, 10, 51, 7, 933, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "c192e249-b044-423f-9c81-1a47841c09ef", "AQAAAAIAAYagAAAAEIBFGeInUJ5ugdc4lw2/36Mxzolaij34lMjc2Nbsg2BmCB7xNRYykpB46so0FJtYHA==", "0e233953-7579-45c9-bfbc-7c0e3d04104f", new DateTime(2023, 11, 11, 10, 51, 8, 35, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "a2308414-7ad0-4c25-bf7f-d06054a100c0", "AQAAAAIAAYagAAAAEAq+QmyjaxuKIfYUaxNjIA7y7Xsj9T3tOW/2X/b6NETom5ewao3MmLEl/5XNl2qFNw==", "c126120d-3e3b-4556-b075-9a1147f63023", new DateTime(2023, 11, 11, 10, 51, 7, 738, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "d552662b-1a73-4ca0-bac0-2b618a3c166e", "AQAAAAIAAYagAAAAEPQJ4UvFrONSTcxs72a3FDOD4B0IJdj0OOvjd473MUDar0UCAWx3qJ/Ac+v0igUJpw==", "a84f74f3-9ab1-4cd0-a131-db9d957486e7", new DateTime(2023, 11, 11, 10, 51, 8, 137, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.CreateIndex(
                name: "IX_Partner_Id",
                table: "Partner",
                column: "Id",
                unique: true,
                filter: "[Id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Partner_User_Id",
                table: "Partner",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
