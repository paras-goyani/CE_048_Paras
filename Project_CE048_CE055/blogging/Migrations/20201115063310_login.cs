using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blogging.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photopath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.email);
                });

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 12, 3, 10, 185, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 12, 3, 10, 187, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 3,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 12, 3, 10, 187, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 4,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 12, 3, 10, 187, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 5,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 12, 3, 10, 187, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "stories",
                keyColumn: "Id",
                keyValue: 6,
                column: "createdat",
                value: new DateTime(2020, 11, 15, 12, 3, 10, 187, DateTimeKind.Local).AddTicks(2143));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

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
    }
}
