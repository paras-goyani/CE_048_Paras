using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blogging.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 11, 35, 46, 407, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 11, 35, 46, 408, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 3,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 11, 35, 46, 408, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 4,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 11, 35, 46, 408, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 5,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 11, 35, 46, 408, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 6,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 11, 35, 46, 408, DateTimeKind.Local).AddTicks(5686));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 507, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 3,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 4,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 5,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 6,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8375));
        }
    }
}
