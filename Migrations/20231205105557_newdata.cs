using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 1,
                column: "Name",
                value: "Rose Lily Garden");

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 2,
                column: "Name",
                value: "Zen Garden");

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 3,
                column: "Name",
                value: "Secret Garden");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1,
                column: "PlantName",
                value: "Avocado");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2,
                column: "PlantName",
                value: "Chili");

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "PlantName" },
                values: new object[,]
                {
                    { 3, "Sunflower" },
                    { 4, "Basil" },
                    { 5, "Fern" },
                    { 6, "Tulip" },
                    { 7, "Cactus" },
                    { 8, "Orchid" },
                    { 9, "Mint" },
                    { 10, "Tomato" },
                    { 11, "Lily" },
                    { 12, "Daisy" },
                    { 13, "Aloe Vera" },
                    { 14, "Bamboo" },
                    { 15, "Succulent" }
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
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 1,
                column: "Name",
                value: "Garden1");

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 2,
                column: "Name",
                value: "Garden2");

            migrationBuilder.UpdateData(
                table: "Gardens",
                keyColumn: "GardenId",
                keyValue: 3,
                column: "Name",
                value: "Garden3");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1,
                column: "PlantName",
                value: "Plant1");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2,
                column: "PlantName",
                value: "Plant2");

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
