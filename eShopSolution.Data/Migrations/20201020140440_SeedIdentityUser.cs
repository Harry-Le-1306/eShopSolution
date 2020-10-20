using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 21, 0, 4, 39, 818, DateTimeKind.Local).AddTicks(4736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 20, 23, 32, 11, 871, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("de2e9c06-53e3-4378-ab03-54a7b24b452d"), "503b8039-802d-4c4a-a1b2-ad8f31f09afe", "Administration role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("513ea9b2-7db6-42ac-8081-92569bdca1d5"), new Guid("de2e9c06-53e3-4378-ab03-54a7b24b452d") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("513ea9b2-7db6-42ac-8081-92569bdca1d5"), 0, "efdb8205-9b80-4529-ad31-beedf4593b81", new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "harry.le@gmail.com", true, "Harry", "Le", false, null, "harry.le@gmail.com", "admin", "AQAAAAEAACcQAAAAEKsLthVoY5ll8HrN6uHY7juQ6XB4HhXNqLsaAEbxKFLaDwkePyaQLnN6PftEV8zoeg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductTranlations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Pierre Cardin Men Shirt", "Pierre Cardin Men Shirt", "Pierre Cardin Men Shirt", "pierre-cardin-men-shirt", "Pierre Cardin Men Shirt", "Pierre Cardin Men Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 21, 0, 4, 39, 842, DateTimeKind.Local).AddTicks(8958));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("de2e9c06-53e3-4378-ab03-54a7b24b452d"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("513ea9b2-7db6-42ac-8081-92569bdca1d5"), new Guid("de2e9c06-53e3-4378-ab03-54a7b24b452d") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("513ea9b2-7db6-42ac-8081-92569bdca1d5"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 20, 23, 32, 11, 871, DateTimeKind.Local).AddTicks(3772),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 21, 0, 4, 39, 818, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductTranlations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Pierre Cardin Men T-Shirt", "Pierre Cardin Men T-Shirt", "Pierre Cardin Men T-Shirt", "pierre-cardin-men-t-shirt", "Pierre Cardin Men T-Shirt", "Pierre Cardin Men T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 20, 23, 32, 11, 892, DateTimeKind.Local).AddTicks(3447));
        }
    }
}
