using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blogging.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 18, 10, 5, 507, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.InsertData(
                table: "stories",
                columns: new[] { "Id", "body", "createdat", "status", "title", "userId" },
                values: new object[,]
                {
                    { 2, "cdsgrsdg", new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8295), 0, "blogging", "vfg@gmial.com" },
                    { 3, "cdsgrsdg", new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8363), 0, "blogging", "vfg@gmial.com" },
                    { 4, "cdsgrsdg", new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8368), 0, "blogging", "vfg@gmial.com" },
                    { 5, "cdsgrsdg", new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8372), 0, "blogging", "vfg@gmial.com" },
                    { 6, "cdsgrsdg", new DateTime(2020, 11, 11, 18, 10, 5, 509, DateTimeKind.Local).AddTicks(8375), 0, "blogging", "vfg@gmial.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdat",
                value: new DateTime(2020, 11, 11, 13, 56, 36, 828, DateTimeKind.Local).AddTicks(1747));
        }
    }
}
