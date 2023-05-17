using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class t3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendenceConfigs",
                table: "AttendenceConfigs");

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

            migrationBuilder.RenameTable(
                name: "AttendenceConfigs",
                newName: "AttendenceConfiguration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendenceConfiguration",
                table: "AttendenceConfiguration",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("0a951ebd-212f-4755-a6f8-c4bed43e8a03"), "638194014119641608", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("51927773-5e5a-4b09-b020-98736558264e"), "638194014119642402", "EMPLOYEE", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e4ec4285-ab99-4ced-ad9d-aa67955338aa"), 0, "d9328a62-b8ec-4987-89a0-c51d777c2f0e", "ApplicationUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBlRifz/osAvZsRw6geBb4a/UbgXC6zyp6j0tmnK2v8o7REATbSlpN1e9ZgAGcgNIQ==", null, false, "638194014119662400", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0a951ebd-212f-4755-a6f8-c4bed43e8a03"), new Guid("e4ec4285-ab99-4ced-ad9d-aa67955338aa") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendenceConfiguration",
                table: "AttendenceConfiguration");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("51927773-5e5a-4b09-b020-98736558264e"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0a951ebd-212f-4755-a6f8-c4bed43e8a03"), new Guid("e4ec4285-ab99-4ced-ad9d-aa67955338aa") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0a951ebd-212f-4755-a6f8-c4bed43e8a03"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4ec4285-ab99-4ced-ad9d-aa67955338aa"));

            migrationBuilder.RenameTable(
                name: "AttendenceConfiguration",
                newName: "AttendenceConfigs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendenceConfigs",
                table: "AttendenceConfigs",
                column: "Id");

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
    }
}
