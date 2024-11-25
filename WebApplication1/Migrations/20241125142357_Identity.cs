using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10851edb-af4f-429a-8625-b75cc317020a", "10851edb-af4f-429a-8625-b75cc317020a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "204184c3-1522-4570-ab8d-b508249ff317", "204184c3-1522-4570-ab8d-b508249ff317" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10851edb-af4f-429a-8625-b75cc317020a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "204184c3-1522-4570-ab8d-b508249ff317");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10851edb-af4f-429a-8625-b75cc317020a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "204184c3-1522-4570-ab8d-b508249ff317");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "256028ea-6849-441a-91d7-2a45387c02a6", "256028ea-6849-441a-91d7-2a45387c02a6", "admin", "ADMIN" },
                    { "9e9db1c7-12e2-41f2-b523-61e9949bc4df", "9e9db1c7-12e2-41f2-b523-61e9949bc4df", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "256028ea-6849-441a-91d7-2a45387c02a6", 0, "ebbe3397-bd21-4819-9235-a724af4be59d", "hubert@wsei.edu.pl", true, false, null, "HUBERT@WSEI.EDU.PL", "HUBERT", "AQAAAAIAAYagAAAAENIFQSf23gVGXJ1kd+NPkhqWoaj4R3z5NI8eFm8xR3V+GArg3HxaOr5co4QUPqtZfA==", null, false, "43d2f869-414e-450e-a7ee-4cd4f8cbb923", false, "Hubert" },
                    { "9e9db1c7-12e2-41f2-b523-61e9949bc4df", 0, "4d91bf27-a3cd-44be-92f3-791f7ecb3e51", "kuba@wsei.edu.pl", true, false, null, "KUBA@WSEI.EDU.PL", "KUBA", "AQAAAAIAAYagAAAAEKVipGhO+b3XODumpk0vXaXzxU+MSls8MkNF/5CXBdNUtivt79D6h4m04Du30px5Eg==", null, false, "371bb6f7-49d6-45a7-a7a7-518d45b83a8d", false, "Kuba" }
                });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 11, 25, 15, 23, 57, 296, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 11, 25, 15, 23, 57, 296, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address_Street", "Nip", "Regon" },
                values: new object[] { "św Filipa 18", "12423534", "74576364" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address_Street", "Name", "Nip", "Regon" },
                values: new object[] { "Buncha", "WEBCON", "864363", "7254231" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "256028ea-6849-441a-91d7-2a45387c02a6", "256028ea-6849-441a-91d7-2a45387c02a6" },
                    { "9e9db1c7-12e2-41f2-b523-61e9949bc4df", "9e9db1c7-12e2-41f2-b523-61e9949bc4df" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "256028ea-6849-441a-91d7-2a45387c02a6", "256028ea-6849-441a-91d7-2a45387c02a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e9db1c7-12e2-41f2-b523-61e9949bc4df", "9e9db1c7-12e2-41f2-b523-61e9949bc4df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "256028ea-6849-441a-91d7-2a45387c02a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e9db1c7-12e2-41f2-b523-61e9949bc4df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "256028ea-6849-441a-91d7-2a45387c02a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e9db1c7-12e2-41f2-b523-61e9949bc4df");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10851edb-af4f-429a-8625-b75cc317020a", null, "Admin", "ADMIN" },
                    { "204184c3-1522-4570-ab8d-b508249ff317", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10851edb-af4f-429a-8625-b75cc317020a", 0, "96c96336-5854-456f-9261-992b2449a64e", "adam@wsei.edu.pl", true, false, null, "adam@wsei.edu.pl", "ADMIN", "AQAAAAIAAYagAAAAEMsV1+9rM17f+E4q3FezD/wYKMl+3rv4/80fTd6W9X+Svc/dghNInvRpyEob2QDLrg==", null, false, "911c4b7c-4b73-4293-9e9b-a02cd5c73bcf", false, "admin" },
                    { "204184c3-1522-4570-ab8d-b508249ff317", 0, "73d9c25c-9511-4921-816b-f2f4c31187ad", "hubert@wsei.edu.pl", true, false, null, "hubert@wsei.edu.pl", "USER", "AQAAAAIAAYagAAAAEBIYwTFWZmFJ2heJv5W/2VkBZReg6G9E8atucrjH+vfVJH2juIIL00gY0My2ZB2QRQ==", null, false, "12da0741-13a4-4095-8200-72c23a334594", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 11, 19, 12, 16, 13, 844, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 11, 19, 12, 16, 13, 844, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Nip", "Regon", "Address_Street" },
                values: new object[] { "1234567890", "73276", "Długa 1" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Nip", "Regon", "Address_Street" },
                values: new object[] { "POLIBUDA", "1234567894210", "7322134", "Osiedle Zgody 3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "10851edb-af4f-429a-8625-b75cc317020a", "10851edb-af4f-429a-8625-b75cc317020a" },
                    { "204184c3-1522-4570-ab8d-b508249ff317", "204184c3-1522-4570-ab8d-b508249ff317" }
                });
        }
    }
}
