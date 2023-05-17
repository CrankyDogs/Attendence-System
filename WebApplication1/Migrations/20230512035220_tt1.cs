using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class tt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("7b9494fa-efca-4a5c-a214-b46a19f083c2"), "638194603400826531", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("f0504ac7-2603-4fc5-a175-245b0287ae39"), "638194603400830771", "EMPLOYEE", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3f50e61f-a581-441e-88a6-42cdc111ee14"), 0, "8871ab45-9c36-4922-beb1-7278970ad58e", "ApplicationUser", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAECbXlh5xC8T5bT5ZH9HRy2WhVkA3gSuxzLN9MJ8K0zur7s2bx+SUKGUXjMn3JF4iOQ==", null, false, "638194603400851417", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("7b9494fa-efca-4a5c-a214-b46a19f083c2"), new Guid("3f50e61f-a581-441e-88a6-42cdc111ee14") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0504ac7-2603-4fc5-a175-245b0287ae39"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7b9494fa-efca-4a5c-a214-b46a19f083c2"), new Guid("3f50e61f-a581-441e-88a6-42cdc111ee14") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7b9494fa-efca-4a5c-a214-b46a19f083c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f50e61f-a581-441e-88a6-42cdc111ee14"));

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
    }
}
