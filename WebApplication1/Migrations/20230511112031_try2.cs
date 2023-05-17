using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class try2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5402686d-0d42-47e3-ada8-e9bd762d79be"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c317cd55-1edb-4499-8610-b666dbc7433b"), new Guid("0b983c1c-0613-47f5-a167-5b8866b4bf71") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c317cd55-1edb-4499-8610-b666dbc7433b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b983c1c-0613-47f5-a167-5b8866b4bf71"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("835d046e-147a-4f71-8ae6-6d1dc54aea2a"), "638194008310691375", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6c50f0f0-9c9c-436b-863f-96f959d42fdc"), "638194008310692243", "EMPLOYEE", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9d6d7553-4f93-45e9-9265-c9e0699de0f3"), 0, "a7d35b34-8b17-4e61-842c-a7011024f8dd", "ApplicationUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEE6/8WODJBclDT12I8vnWKvagFNHzM73Ipzw5WlktNUP1BzkmpnHMnwZReWXdV6fEQ==", null, false, "638194008310712532", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("835d046e-147a-4f71-8ae6-6d1dc54aea2a"), new Guid("9d6d7553-4f93-45e9-9265-c9e0699de0f3") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6c50f0f0-9c9c-436b-863f-96f959d42fdc"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("835d046e-147a-4f71-8ae6-6d1dc54aea2a"), new Guid("9d6d7553-4f93-45e9-9265-c9e0699de0f3") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("835d046e-147a-4f71-8ae6-6d1dc54aea2a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d6d7553-4f93-45e9-9265-c9e0699de0f3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("c317cd55-1edb-4499-8610-b666dbc7433b"), "638193919589869510", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("5402686d-0d42-47e3-ada8-e9bd762d79be"), "638193919589870597", "EMPLOYEE", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0b983c1c-0613-47f5-a167-5b8866b4bf71"), 0, "6338618d-5421-4145-b537-0b908438b54f", "ApplicationUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAED0lhuS8aj1HwPOpejTXslJyTokmpP+OfJcWKzjfwfzzMVKPTJko4rEsw6KiWf2E7g==", null, false, "638193919589895653", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c317cd55-1edb-4499-8610-b666dbc7433b"), new Guid("0b983c1c-0613-47f5-a167-5b8866b4bf71") });
        }
    }
}
