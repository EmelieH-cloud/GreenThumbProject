using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumbProject.Migrations
{
    public partial class detailsforplants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1,
                column: "Details",
                value: "Avocado (Persea americana) is a popular fruit with a creamy texture and a rich taste. It is known for its health benefits and is often used in salads, sandwiches, and guacamole.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2,
                column: "Details",
                value: "Chili (Capsicum) is a spicy pepper commonly used in various cuisines around the world. It adds heat and flavor to dishes and is available in different varieties, ranging from mild to extremely hot.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 3,
                column: "Details",
                value: "Sunflower (Helianthus annuus) is a vibrant and tall flowering plant. It is well-known for its large, yellow blooms and is cultivated for its seeds, which are a popular snack and ingredient in various dishes.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 4,
                column: "Details",
                value: "Basil (Ocimum basilicum) is a fragrant herb commonly used in cooking. It is a key ingredient in many Italian dishes and adds a fresh and aromatic flavor to salads, sauces, and soups.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 5,
                column: "Details",
                value: "Fern is a type of non-flowering plant that reproduces via spores. It is known for its feathery leaves and is often used as an ornamental plant in gardens and homes.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 6,
                column: "Details",
                value: "Tulip is a spring-blooming flower known for its vibrant colors and distinctive shape. It is a popular ornamental plant and is often associated with the arrival of spring.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 7,
                column: "Details",
                value: "Cactus is a succulent plant adapted to arid environments. It is characterized by its unique and diverse shapes. Some cacti produce colorful flowers, while others are valued for their resilience and low maintenance.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 8,
                column: "Details",
                value: "Orchid is a diverse and widespread family of flowering plants. Known for their exotic and often fragrant blooms, orchids are popular as ornamental plants and are cultivated for their beauty.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 9,
                column: "Details",
                value: "Mint (Mentha) is a fragrant herb commonly used in culinary and medicinal applications. It adds a refreshing flavor to dishes, beverages, and desserts. Mint is also known for its therapeutic properties.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 10,
                column: "Details",
                value: "Tomato (Solanum lycopersicum) is a widely cultivated fruit/vegetable. It is a key ingredient in many cuisines and is used in salads, sauces, soups, and various dishes. Tomatoes come in a variety of colors and sizes.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 11,
                column: "Details",
                value: "Lily is a beautiful and fragrant flowering plant. It is known for its elegant blooms and is often used in floral arrangements. Lilies are available in various colors and varieties.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 12,
                column: "Details",
                value: "Daisy is a cheerful and simple flowering plant. It is characterized by its white petals surrounding a yellow center. Daisies are popular in gardens and are often associated with innocence and purity.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 13,
                column: "Details",
                value: "Aloe Vera is a succulent plant with medicinal properties. Its gel-like substance is used to soothe and heal skin conditions, burns, and wounds. Aloe Vera is also cultivated as an ornamental plant.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 14,
                column: "Details",
                value: "Bamboo is a versatile and fast-growing plant. It is used for various purposes, including construction, furniture, and as a decorative element in gardens. Bamboo is known for its strength and sustainability.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 15,
                column: "Details",
                value: "Succulent plants are water-retaining plants adapted to arid conditions. They come in various shapes and sizes and are popular for their low maintenance and unique appearance. Succulents are often used in indoor gardens.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 16,
                column: "Details",
                value: "Rosemary (Rosmarinus officinalis) is an aromatic herb with needle-like leaves. It is used in cooking, especially in Mediterranean cuisine, to add flavor to dishes. Rosemary is also known for its fragrant oil.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 17,
                column: "Details",
                value: "Lemon Tree (Citrus limon) produces tart and citrusy fruits. It is cultivated for its lemons, which are used in cooking, beverages, and for their refreshing scent. Lemon trees are popular as ornamental and fruit-bearing plants.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 18,
                column: "Details",
                value: "Snake Plant (Sansevieria) is a hardy and low-maintenance indoor plant. It is known for its upright, sword-like leaves with distinctive patterns. Snake plants are valued for their air-purifying qualities.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 19,
                column: "Details",
                value: "Lavender (Lavandula) is a fragrant herb with purple flowers. It is known for its soothing aroma and is often used in aromatherapy, skincare products, and culinary applications. Lavender is also popular in gardens.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 20,
                column: "Details",
                value: "Spider Plant (Chlorophytum comosum) is a popular indoor plant with arching, spider-like leaves. It is easy to care for and is known for its air-purifying qualities. Spider plants are often chosen for their unique appearance.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 21,
                column: "Details",
                value: "Jasmine is a fragrant flowering plant known for its sweet-scented blossoms. It is often used in perfumes, teas, and as an ornamental plant in gardens. Jasmine flowers are associated with beauty and romance.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 22,
                column: "Details",
                value: "Pothos (Epipremnum aureum) is a popular and easy-to-care-for indoor plant. It has heart-shaped leaves and is known for its trailing vines. Pothos is valued for its air-purifying qualities.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 23,
                column: "Details",
                value: "Chrysanthemum is a colorful and flowering plant. It is often cultivated for its vibrant blooms and is used in floral arrangements. Chrysanthemums come in various colors and are associated with autumn.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 24,
                column: "Details",
                value: "Fiddle Leaf Fig (Ficus lyrata) is a popular indoor tree with large, violin-shaped leaves. It is valued for its attractive foliage and is often used as a statement plant in interior decor.");

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 25,
                column: "Details",
                value: "Peace Lily (Spathiphyllum) is a popular indoor plant known for its elegant white flowers and air-purifying qualities. It thrives in low light conditions and is a favorite choice for homes and offices.");

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
                name: "Details",
                table: "Plants");

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
