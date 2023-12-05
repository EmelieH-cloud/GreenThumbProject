using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class addeddetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 1,
                column: "Content",
                value: "Water generously");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2,
                column: "Content",
                value: "Provide high levels of sunlight");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 3,
                column: "Content",
                value: "Must stand close to a window");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4,
                column: "Content",
                value: "Add extra fertilizer once a week");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 5,
                column: "Content",
                value: "No to little water required");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6,
                column: "Content",
                value: "Water 2-3 times a week");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 7,
                column: "Content",
                value: "Keep out of reach for cats");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8,
                column: "Content",
                value: "Keep out of reach for dogs");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 9,
                column: "Content",
                value: "Keep out of reach for children");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10,
                column: "Content",
                value: "Requires only small amounts of sunlight");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 11,
                column: "Content",
                value: "Water daily");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 12,
                column: "Content",
                value: "Soil must be kept moist at all times");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 13,
                column: "Content",
                value: "Spray the leaves with water");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 14,
                column: "Content",
                value: "Repotting should be done once a year");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 15,
                column: "Content",
                value: "Prefers moist environments");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 16,
                column: "Content",
                value: "Prefers dry air");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 17,
                column: "Content",
                value: "Repotting should be done twice a year");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 18,
                column: "Content",
                value: "Remove dead leaves twice a week");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 19,
                column: "Content",
                value: "No fertilizer");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 20,
                column: "Content",
                value: "Prone to dry out, water generously");

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
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Instructions");

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
