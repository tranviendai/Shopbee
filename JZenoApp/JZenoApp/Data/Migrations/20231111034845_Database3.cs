using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_partnerId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Partner");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "a06bc234-b761-4b20-9518-2eb6fc33d1e7", "AQAAAAIAAYagAAAAEJtaRUPqRvzpohHQp2qBH6+hqU+7UctrBNLeVt1cjx9jPn2bw/HfIvMDWdbaaAt4mQ==", "3c404945-d558-4248-9626-0d328e9e147c", new DateTime(2023, 11, 11, 10, 48, 44, 595, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "ccb6284e-3907-4164-b5af-26ca77f9cdce", "AQAAAAIAAYagAAAAECx1Ws7pRFvloyhXnWDweedvBUDOVhsetfIwsADVV7CDR+0xXEh98PyNBsLWWSn2Bg==", "b934ca2b-1339-486d-aaf1-df749346713a", new DateTime(2023, 11, 11, 10, 48, 44, 693, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "c0ec4933-c092-4cf5-aab2-559ca0c788a5", "AQAAAAIAAYagAAAAEHr8nWpTnUUvqVUMYMUtXDMjPYeErPXMfnECHRbmEd4RojKg2oFQMpk1mlpfzK+d8A==", "db2c7e5c-7978-4da5-a724-3d1e2c2ac9b0", new DateTime(2023, 11, 11, 10, 48, 44, 789, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "c73c854c-791c-4620-bc79-9a5135cfe1d6", "AQAAAAIAAYagAAAAEGN6IqbWwp8BLvCCiU79RmY56Arxvhj6D20cmerpeujxvMlBJgl+QlXNvhLePpkNlw==", "675df515-45ef-49c7-9660-254b54792231", new DateTime(2023, 11, 11, 10, 48, 44, 499, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "f5d05a74-dd94-43d1-b011-450fa9f0f860", "AQAAAAIAAYagAAAAENC+ue30OB/wgV21+FHJT3WsZV1x64BmTfQJZO58iqCL+WUe1hiDCZBi9RpFYkb1qw==", "7efae0cf-4561-4622-80c3-cfdec5654187", new DateTime(2023, 11, 11, 10, 48, 44, 888, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.CreateIndex(
                name: "IX_User_partnerId",
                table: "User",
                column: "partnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_partnerId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Partner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "0f9bf65e-431f-4f59-98da-ac006b2b7a63", "AQAAAAIAAYagAAAAEHQAiLjLxhZC6oQGaAJvlb/oGl+CGKmbRZbzKjCJ3vlEh5hfELYVdfLljkFGRS665g==", "a0827c18-f7b5-4669-b431-01371aff93f9", new DateTime(2023, 11, 11, 10, 47, 26, 876, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "aaf8420b-b4b2-45a2-8ebd-b38178daeb90", "AQAAAAIAAYagAAAAEIEp4iWJqwm0/LbkpyNFRL6GialWdiFySpNDUvZbUKEHbkSTuPQ0a80g5c1mOVFBEg==", "3b5afa4b-b8c3-4320-8929-772a9845f93e", new DateTime(2023, 11, 11, 10, 47, 26, 974, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "827a78c8-43e2-45c0-a623-b35f2ec1b208", "AQAAAAIAAYagAAAAECbTmXsNpXV6KjWPYjBSaP1sItdQZCS+5kIGIk6W8rNx2tg4rd24n/h5fhXZgMkA/A==", "16975b09-3d01-4494-bcc5-86e719fbab48", new DateTime(2023, 11, 11, 10, 47, 27, 83, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "42227ae3-156d-493f-a9b8-c1538df96ffe", "AQAAAAIAAYagAAAAEPfkHv13SAD7JcCL7c29hl/5fWiUvto2CZtOJPYSooQgdw9hPDG48a2hoBnvjAQgBw==", "9321230b-8a37-4318-b0d8-80a5d7ff1240", new DateTime(2023, 11, 11, 10, 47, 26, 777, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "36a0b62b-8ec5-4273-86ad-ec85887850d2", "AQAAAAIAAYagAAAAEMj5n3DfX2qt3fwZ+K79/I0KyoDW0tq6cXQ9v27+wZNfKSk7ofor8lUwFrpbDrrCQw==", "7a8ce3df-16fc-48cf-8e68-308f67e158b6", new DateTime(2023, 11, 11, 10, 47, 27, 190, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.CreateIndex(
                name: "IX_User_partnerId",
                table: "User",
                column: "partnerId",
                unique: true,
                filter: "[partnerId] IS NOT NULL");
        }
    }
}
