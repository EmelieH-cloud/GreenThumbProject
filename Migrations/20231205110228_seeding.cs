using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "InstructionId", "PlantId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 }
                });

            migrationBuilder.InsertData(
                table: "PlantGardens",
                columns: new[] { "GardenId", "PlantId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 1, 11 },
                    { 2, 12 },
                    { 3, 13 },
                    { 1, 14 },
                    { 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "PlantName" },
                values: new object[,]
                {
                    { 16, "Rosemary" },
                    { 17, "Lemon Tree" },
                    { 18, "Snake Plant" },
                    { 19, "Lavender" },
                    { 20, "Spider Plant" },
                    { 21, "Jasmine" },
                    { 22, "Pothos" },
                    { 23, "Chrysanthemum" },
                    { 24, "Fiddle Leaf Fig" },
                    { 25, "Peace Lily" }
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

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "InstructionId", "PlantId" },
                values: new object[,]
                {
                    { 16, 16 },
                    { 17, 17 },
                    { 18, 18 },
                    { 19, 19 },
                    { 20, 20 }
                });

            migrationBuilder.InsertData(
                table: "PlantGardens",
                columns: new[] { "GardenId", "PlantId" },
                values: new object[,]
                {
                    { 3, 16 },
                    { 1, 17 },
                    { 2, 18 },
                    { 3, 19 },
                    { 1, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "PlantGardens",
                keyColumns: new[] { "GardenId", "PlantId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 20);

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
