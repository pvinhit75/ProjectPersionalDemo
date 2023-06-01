using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPersional.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 2, 0, 50, 43, 211, DateTimeKind.Local).AddTicks(9144));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 2, 0, 31, 11, 146, DateTimeKind.Local).AddTicks(2192));
        }
    }
}
