using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class usergardens : Migration
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "UserName" },
                values: new object[] { 4, "f7GpZqie1tOnESRrxJeVxF+5WN2U/Qle9gD5CaIm1E8=", "User3" });

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 3,
                column: "UserId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 3,
                column: "UserId",
                value: 3);

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
        }
    }
}
