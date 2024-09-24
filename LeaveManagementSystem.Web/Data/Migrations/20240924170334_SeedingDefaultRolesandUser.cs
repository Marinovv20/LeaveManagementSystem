using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16064531-fb07-4ec7-affb-8affa7edeec0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5b22d9d5-985a-4c35-b57c-fc42afba3450", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEDrDHZpmOzX29+zDMWgJcMvWCX2BuzgZFaUF+OK3wejaMKKiKhWQwdmGSsGGMMuSCA==", "424a2d9f-a597-4c3d-b11a-69392b1cb6b9", "admin@localhost" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16064531-fb07-4ec7-affb-8affa7edeec0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3d8d17a1-00e1-450a-b468-d1feca35aaeb", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOoal48tF87BxYQpUrU+yRv9yM3O3R9OccV4w54GfKRT3YABKNBYSvRfxFpelxg/TA==", "d06311a4-f63f-40b0-b008-169837d75798", "admin@localhost.com" });
        }
    }
}
