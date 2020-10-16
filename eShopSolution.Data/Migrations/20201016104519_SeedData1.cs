using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 20, 45, 19, 55, DateTimeKind.Local).AddTicks(9326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 16, 20, 39, 25, 675, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SortOrder", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SortOrder", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 16, 20, 45, 19, 73, DateTimeKind.Local).AddTicks(4516));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 16, 20, 39, 25, 675, DateTimeKind.Local).AddTicks(6410),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 16, 20, 45, 19, 55, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.AlterColumn<decimal>(
                name: "SortOrder",
                table: "Categories",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SortOrder", "Status" },
                values: new object[] { 1m, 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SortOrder", "Status" },
                values: new object[] { 2m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 10, 16, 20, 39, 25, 699, DateTimeKind.Local).AddTicks(5042));
        }
    }
}
