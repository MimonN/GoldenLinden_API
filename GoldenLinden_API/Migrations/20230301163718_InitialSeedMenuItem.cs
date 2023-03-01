using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoldenLinden_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedMenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "MenuItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Soup", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://img.ccnull.de/1025000/preview/1025542_48f1150dc44ff42996600b34cd34a3fe.jpg", "Ukrainian Borscht", 7.9900000000000002, "" },
                    { 2, "Soup", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://media.30seconds.com/tip/md/Hungarian-Mushroom-Soup-Recipe-39195-c46def2dd2-1644776743.jpg", "Mushroom Soup", 8.9900000000000002, "" },
                    { 3, "Salad", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://hips.hearstapps.com/hmg-prod/images/delish-beet-salad-jpg-1526059794.jpg", "Roasted Beef & Goat Cheese Salad", 8.9900000000000002, "Best Seller" },
                    { 4, "Entrée", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://www.sweetandsavorybyshinee.com/wp-content/uploads/2020/07/Grilled-Pork-Kebabs-Shashlyk-4.jpg", "Mixed Ukrainian Grill", 10.99, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
