using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16064531-fb07-4ec7-affb-8affa7edeec0",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c4eaef-a6bb-45bd-b3bd-47ba27ed20cb", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEFdg0XXTdqsPYMY8DxYnvBQDsfqe7AInQp9xtgT4OZReA1ErHxnC5l/uvzDO7iBZaw==", "9a402b9a-340d-437e-923c-12156832efc0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16064531-fb07-4ec7-affb-8affa7edeec0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b22d9d5-985a-4c35-b57c-fc42afba3450", "AQAAAAIAAYagAAAAEDrDHZpmOzX29+zDMWgJcMvWCX2BuzgZFaUF+OK3wejaMKKiKhWQwdmGSsGGMMuSCA==", "424a2d9f-a597-4c3d-b11a-69392b1cb6b9" });
        }
    }
}
