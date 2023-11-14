using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZenoApp.Migrations
{
    /// <inheritdoc />
    public partial class Database2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partner_User_Id",
                table: "Partner");

            migrationBuilder.DropIndex(
                name: "IX_User_partnerId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Partner_Id",
                table: "Partner");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Partner",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 47, 27, 191, DateTimeKind.Local).AddTicks(296));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_partnerId",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Partner",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "20f3e18e-f277-4a78-8f5a-e22e6d819a76", "AQAAAAIAAYagAAAAEKQhJeu2zp68yp0hRBB578FZeK9DgE3i/5lVRvr/AT6FP/V0dgTHL26Fsr+yqubkBg==", "dd2553b1-a027-4d93-96f0-5bcccb21adc6", new DateTime(2023, 11, 11, 10, 43, 47, 664, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "95923a3f-2776-456a-b4f6-3916beae923d", "AQAAAAIAAYagAAAAEGon36R1p+yy84OnwPtmItfK9rpgyV8dznGdZVpaLNIFp1r7IWhJsaLFsuCNmQvwcQ==", "9a9c9b10-c27a-4230-8400-6c5fd46200e3", new DateTime(2023, 11, 11, 10, 43, 47, 764, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "2fd4d0f5-2d90-4431-a024-a8edec48bde6", "AQAAAAIAAYagAAAAEGnldE1NtD1/oc6rLIKPgB9TNhyr94eMt9uWd7gB69EBNl+rVfptB3rhRNg56Kv35Q==", "ba046b36-68f4-4b35-ac3c-28e6097fed2f", new DateTime(2023, 11, 11, 10, 43, 47, 862, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "69363b1b-7f75-447f-bfc6-e6077a8ee65b", "AQAAAAIAAYagAAAAEJxg8iob1bo91+xOWwRKt44yrhm1NpiqLDEetoeMy7yL0C3Xl5vzcRz+BInW8MY+Hg==", "2debf983-a3d0-459f-ab8b-8bbf85f6c7c4", new DateTime(2023, 11, 11, 10, 43, 47, 562, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "2b0b48ea-5e02-434f-b3ed-8467cb07d0c1", "AQAAAAIAAYagAAAAEIJY5dr3cmK3nw4m3lzvjfXo52P7ZW4vQEKAa6xwnjwD/5iDM4X1Ccp0OBnztdOpTg==", "f1092438-9bd5-4772-ae63-241d63a02577", new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.CreateIndex(
                name: "IX_User_partnerId",
                table: "User",
                column: "partnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Partner_Id",
                table: "Partner",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Partner_User_Id",
                table: "Partner",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
