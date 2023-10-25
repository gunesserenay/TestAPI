using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_API.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "VillaNumbers",
               columns: table => new
               {
                   VillaNo = table.Column<int>(type: "int", nullable: false),
                   SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
               });
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 22, 1, 51, 480, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 22, 1, 51, 480, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 22, 1, 51, 480, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 22, 1, 51, 480, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 22, 1, 51, 480, DateTimeKind.Local).AddTicks(9760));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 20, 15, 47, 98, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 20, 15, 47, 98, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 20, 15, 47, 98, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 20, 15, 47, 98, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 20, 15, 47, 98, DateTimeKind.Local).AddTicks(6810));
        }
    }
}
