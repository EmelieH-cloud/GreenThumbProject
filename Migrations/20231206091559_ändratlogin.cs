using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class ändratlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "f7GpZqie1tOnESRrxJeVxGK3spQ4hnD/mK7oOiaaTyo=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "f7GpZqie1tOnESRrxJeVxMFz9kR7JLmicQNL+TGLSMA=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "dWqvyilRa8xuX6cGYGvknQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "f7GpZqie1tOnESRrxJeVxKYlBReYbSiGLAC2K1lMUnQ=", "User4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "f7GpZqie1tOnESRrxJeVxGK3spQ4hnD/mK7oOiaaTyo=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Password",
                value: "f7GpZqie1tOnESRrxJeVxMFz9kR7JLmicQNL+TGLSMA=");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Password",
                value: "dWqvyilRa8xuX6cGYGvknQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Password", "UserName" },
                values: new object[] { "f7GpZqie1tOnESRrxJeVxF+5WN2U/Qle9gD5CaIm1E8=", "User3" });
        }
    }
}
