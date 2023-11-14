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
            migrationBuilder.AddColumn<string>(
                name: "partnerId",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

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
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6341), null });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6362), null });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6377), null });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "Id", "dateCreated", "userId" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(6379), null });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "20f3e18e-f277-4a78-8f5a-e22e6d819a76", "AQAAAAIAAYagAAAAEKQhJeu2zp68yp0hRBB578FZeK9DgE3i/5lVRvr/AT6FP/V0dgTHL26Fsr+yqubkBg==", "dd2553b1-a027-4d93-96f0-5bcccb21adc6", new DateTime(2023, 11, 11, 10, 43, 47, 664, DateTimeKind.Local).AddTicks(9311), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "95923a3f-2776-456a-b4f6-3916beae923d", "AQAAAAIAAYagAAAAEGon36R1p+yy84OnwPtmItfK9rpgyV8dznGdZVpaLNIFp1r7IWhJsaLFsuCNmQvwcQ==", "9a9c9b10-c27a-4230-8400-6c5fd46200e3", new DateTime(2023, 11, 11, 10, 43, 47, 764, DateTimeKind.Local).AddTicks(6989), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "2fd4d0f5-2d90-4431-a024-a8edec48bde6", "AQAAAAIAAYagAAAAEGnldE1NtD1/oc6rLIKPgB9TNhyr94eMt9uWd7gB69EBNl+rVfptB3rhRNg56Kv35Q==", "ba046b36-68f4-4b35-ac3c-28e6097fed2f", new DateTime(2023, 11, 11, 10, 43, 47, 862, DateTimeKind.Local).AddTicks(8158), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "69363b1b-7f75-447f-bfc6-e6077a8ee65b", "AQAAAAIAAYagAAAAEJxg8iob1bo91+xOWwRKt44yrhm1NpiqLDEetoeMy7yL0C3Xl5vzcRz+BInW8MY+Hg==", "2debf983-a3d0-459f-ab8b-8bbf85f6c7c4", new DateTime(2023, 11, 11, 10, 43, 47, 562, DateTimeKind.Local).AddTicks(1782), null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated", "partnerId" },
                values: new object[] { "2b0b48ea-5e02-434f-b3ed-8467cb07d0c1", "AQAAAAIAAYagAAAAEIJY5dr3cmK3nw4m3lzvjfXo52P7ZW4vQEKAa6xwnjwD/5iDM4X1Ccp0OBnztdOpTg==", "f1092438-9bd5-4772-ae63-241d63a02577", new DateTime(2023, 11, 11, 10, 43, 47, 969, DateTimeKind.Local).AddTicks(2276), null });

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
                name: "FK_Partner_User_Id",
                table: "Partner");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Partner_partnerId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_partnerId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Partner_Id",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "partnerId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Partner");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Partner");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                column: "dateCreated",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "partnerId",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                column: "dateCreated",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "camera1",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "computer4",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "phone2",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal2",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "sandal3",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt1",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt2",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt3",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shirt4",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes1",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "shoes4",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short1",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "short4",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser2",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "trouser3",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: "watch3",
                column: "postDate",
                value: new DateTime(2023, 11, 7, 19, 51, 29, 579, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5215212-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "dbcd1aa2-82aa-44fb-9ada-e97265550505", "AQAAAAIAAYagAAAAELftB5LHwBcz7Jo+eaop8xRukv9FrwGOo0IdFdt5kQwF3Wd84DQYdknFvufzFT53ow==", "bba57756-6b1f-4014-8240-4a450831af5b", new DateTime(2023, 11, 7, 19, 51, 29, 160, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5dfgsg2-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "9743a7ff-b093-4073-bc05-f2411a7be076", "AQAAAAIAAYagAAAAENpAYgkI/93JIvDnuR/Gi1FuP3HG8WgsOjea154xqUF9YXdscNNWkoCCbqTuEpZ3PQ==", "1bb1f857-b70f-431b-8c14-54f54699ba15", new DateTime(2023, 11, 7, 19, 51, 29, 326, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9f15d62-mx18-4213-h6d1-fdsafdsafdsd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "071a6fc8-2593-4982-9fca-aa06470ce240", "AQAAAAIAAYagAAAAEH45wZpVkunEhtup8T3Yjwu9yC4uXTl8hOpJ6rzQfpmM/tIevgWd6ClMlgL9ywoBww==", "6776b753-30fb-4f28-bd4b-c3fd3f76b29f", new DateTime(2023, 11, 7, 19, 51, 29, 456, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a79e98b4-d8a6-4640-98eb-5b417ffb2661",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "41876e0e-079b-4c75-be25-b13545656dde", "AQAAAAIAAYagAAAAECVi+1J+fPJqoBYVr9bonstmRoV2AaqTwKlLNdKzuu2ZJmZJADbXVizXs5XkCxepJg==", "6ec64392-db3a-4d1d-9193-854098cfe866", new DateTime(2023, 11, 7, 19, 51, 29, 28, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "iosxiof-mx18-4213-h6d1-420b466e4502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "dateCreated" },
                values: new object[] { "61cadffd-0e4f-4b52-94f5-2888cec25e43", "AQAAAAIAAYagAAAAED/+Pg4K2wG7xA/73NWGTqCldnA8D12scXxMsOztkBPSydW40tZwb02j/FPqJCl22g==", "bbcd8951-5fdb-40f3-ac02-883c451ed269", new DateTime(2023, 11, 7, 19, 51, 29, 578, DateTimeKind.Local).AddTicks(9383) });
        }
    }
}
