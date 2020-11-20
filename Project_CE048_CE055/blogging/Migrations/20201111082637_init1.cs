using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blogging.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "stories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdat", "userId" },
                values: new object[] { new DateTime(2020, 11, 11, 13, 56, 36, 828, DateTimeKind.Local).AddTicks(1747), "vfg@gmial.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "stories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdat", "userId" },
                values: new object[] { new DateTime(2020, 11, 11, 13, 49, 28, 503, DateTimeKind.Local).AddTicks(7165), 1 });
        }
    }
}
