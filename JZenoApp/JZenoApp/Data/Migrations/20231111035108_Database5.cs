using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 51, 8, 138, DateTimeKind.Local).AddTicks(3680) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "a06bc234-b761-4b20-9518-2eb6fc33d1e7", "AQAAAAIAAYagAAAAEJtaRUPqRvzpohHQp2qBH6+hqU+7UctrBNLeVt1cjx9jPn2bw/HfIvMDWdbaaAt4mQ==", "3c404945-d558-4248-9626-0d328e9e147c", new DateTime(2023, 11, 11, 10, 48, 44, 595, DateTimeKind.Local).AddTicks(1744), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "ccb6284e-3907-4164-b5af-26ca77f9cdce", "AQAAAAIAAYagAAAAECx1Ws7pRFvloyhXnWDweedvBUDOVhsetfIwsADVV7CDR+0xXEh98PyNBsLWWSn2Bg==", "b934ca2b-1339-486d-aaf1-df749346713a", new DateTime(2023, 11, 11, 10, 48, 44, 693, DateTimeKind.Local).AddTicks(2194), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "c0ec4933-c092-4cf5-aab2-559ca0c788a5", "AQAAAAIAAYagAAAAEHr8nWpTnUUvqVUMYMUtXDMjPYeErPXMfnECHRbmEd4RojKg2oFQMpk1mlpfzK+d8A==", "db2c7e5c-7978-4da5-a724-3d1e2c2ac9b0", new DateTime(2023, 11, 11, 10, 48, 44, 789, DateTimeKind.Local).AddTicks(6450), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "c73c854c-791c-4620-bc79-9a5135cfe1d6", "AQAAAAIAAYagAAAAEGN6IqbWwp8BLvCCiU79RmY56Arxvhj6D20cmerpeujxvMlBJgl+QlXNvhLePpkNlw==", "675df515-45ef-49c7-9660-254b54792231", new DateTime(2023, 11, 11, 10, 48, 44, 499, DateTimeKind.Local).AddTicks(7950), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "f5d05a74-dd94-43d1-b011-450fa9f0f860", "AQAAAAIAAYagAAAAENC+ue30OB/wgV21+FHJT3WsZV1x64BmTfQJZO58iqCL+WUe1hiDCZBi9RpFYkb1qw==", "7efae0cf-4561-4622-80c3-cfdec5654187", new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(4511), null });

            migrationBuilder.CreateIndex(
                name: "IX_User_partnerId",
                table: "User",
                column: "partnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Partner_partnerId",
                table: "User",
                column: "partnerId",
                principalTable: "Partner",
                principalColumn: "partnerId");
        }
    }
}
