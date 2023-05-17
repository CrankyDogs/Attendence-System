using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b71310c1-d6a1-40af-a932-7fa868b9735e"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fd13ee2e-e21a-4360-812a-129089da7637"), new Guid("fd58e0a4-8474-4ec4-97da-5bf2a5abd164") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd13ee2e-e21a-4360-812a-129089da7637"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd58e0a4-8474-4ec4-97da-5bf2a5abd164"));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedOn",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b8a412c8-fa5f-4c88-a668-a63b9c68887a"), "638193803504312472", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("4b051e96-7b55-4b98-a434-c6011bffb757"), "638193803504313180", "EMPLOYEE", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9978f4d0-8728-461d-98fc-894da03e1a84"), 0, "7f9c17c5-7698-4db1-b618-edb921156e70", "ApplicationUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHmykHVsRJ04Zs7U8ceShvsYp72ln1un5/gkANQIRRly9VK7TuUK/DbGKvSkcyn1xA==", null, false, "638193803504331089", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b8a412c8-fa5f-4c88-a668-a63b9c68887a"), new Guid("9978f4d0-8728-461d-98fc-894da03e1a84") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b051e96-7b55-4b98-a434-c6011bffb757"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b8a412c8-fa5f-4c88-a668-a63b9c68887a"), new Guid("9978f4d0-8728-461d-98fc-894da03e1a84") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8a412c8-fa5f-4c88-a668-a63b9c68887a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9978f4d0-8728-461d-98fc-894da03e1a84"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("fd13ee2e-e21a-4360-812a-129089da7637"), "638193062571516198", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b71310c1-d6a1-40af-a932-7fa868b9735e"), "638193062571516850", "EMPLOYEE", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fd58e0a4-8474-4ec4-97da-5bf2a5abd164"), 0, "9048f033-3918-48e5-a288-ebf619105163", "ApplicationUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJlcfGF8a34mBIVRL6jZFy3CKYujCg4dFYuE7bEu0TD4k69v8tavdgv0Mb7CwR7gFA==", null, false, "638193062571533520", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("fd13ee2e-e21a-4360-812a-129089da7637"), new Guid("fd58e0a4-8474-4ec4-97da-5bf2a5abd164") });
        }
    }
}
