using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "InstructionId", "Content", "PlantId" },
                values: new object[,]
                {
                    { 21, "Prone to dry out, water generously", 2 },
                    { 22, "Prone to dry out, water generously", 4 },
                    { 23, "Prone to dry out, water generously", 6 },
                    { 24, "Prone to dry out, water generously", 12 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 24);

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
