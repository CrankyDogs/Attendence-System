using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class addedAttndenceConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AttendenceConfigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxPunchIn = table.Column<TimeSpan>(type: "time", nullable: false),
                    MinPunchOut = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendenceConfigs", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendenceConfigs");

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
    }
}
