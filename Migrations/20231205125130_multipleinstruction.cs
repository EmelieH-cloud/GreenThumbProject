using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class multipleinstruction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2,
                column: "PlantId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4,
                column: "PlantId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6,
                column: "PlantId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8,
                column: "PlantId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10,
                column: "PlantId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 12,
                column: "PlantId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 14,
                column: "PlantId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 16,
                column: "PlantId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 18,
                column: "PlantId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 19,
                column: "PlantId",
                value: 20);

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
            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2,
                column: "PlantId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4,
                column: "PlantId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6,
                column: "PlantId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8,
                column: "PlantId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10,
                column: "PlantId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 12,
                column: "PlantId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 14,
                column: "PlantId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 16,
                column: "PlantId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 18,
                column: "PlantId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 19,
                column: "PlantId",
                value: 19);

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
